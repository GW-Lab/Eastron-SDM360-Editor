'Below Is an example of Modbus RTU Request And Response messages with explanation of each item.
' First, a master sends a request telling the slave 1 to return the value of one Holding register (function 3) starting at address 2.
'
'  slave id                                    (1 byte)
'  |  function code read holding registers     (1 byte)
'  |  |      address of first register to read (2 bytes)
'  |  |      |     number of registers to read (1 byte)
'  |  |      |     |     checksum              (2 bytes)
'  |  |      |     |     |
'  01 03 00 02 00 01 25 CA

' The request also includes a checksum which Is used To make sure the messaged Is Not corrupted On the way To the slave.
' All slaves except For 1 must ignore the message. Slave 1 Is expected To send a response message similar To the following
'
'  slave id (repeats own id)                          (1 byte)
'  |  function code (repeats requested function code) (1 byte)
'  |  |   number of bytes of data (payload)           (1 byte)
'  |  |   |     the value of the register (0x07FF)    (2 bytes)
'  |  |   |     |     checksum                        (2 bytes)
'  |  |   |     |     |
'  01 03 02 07 FF FA 34

Public Class ModBusPacket : Inherits List(Of Byte)
   Public Sub AddCRC()
      AddRange(CRC16(ToArray, inclCRCBytes:=False)) ' Add the CRC to the Packet
   End Sub

   Public Shared Function CRC16(data As Byte()) As Boolean
      Dim crc = CRC16(data, inclCRCBytes:=True)                      ' Check CRC (buffer has CRC bytes)
      Return If(crc(0) = data(data.Length - 2) AndAlso crc(1) = data(data.Length - 1), True, False)
   End Function

   Public Shared Function CRC16(data As Byte(), Optional inclCRCBytes As Boolean = False) As Byte()
      Dim crc As UShort = &HFFFF

      For ndx = 0 To data.Length - If(inclCRCBytes, 3, 1)
         crc = crc Xor data(ndx)

         For j = 0 To 7
            If (crc And &H1) > 0 Then
               crc >>= 1
               crc = CUShort(crc Xor &HA001)
            Else
               crc >>= 1
            End If
         Next
      Next

      Return BitConverter.GetBytes(crc)
   End Function
End Class