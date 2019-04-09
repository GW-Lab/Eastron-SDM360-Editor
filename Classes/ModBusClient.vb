Imports System.IO.Ports

Public Class ModBusClient : Inherits ModBusDSM360
   Public Event Port_Status_Changed(isOpen As Boolean, message As String)

   Public Sub New(comPort As String, baudRate As Integer, dataBits As Integer, stopBits As StopBits, parity As Parity, readTimeOutms As Integer, writeTimeOutms As Integer)
      Me.PortName = comPort
      Me.BaudRate = baudRate
      Me.DataBits = dataBits
      Me.StopBits = stopBits
      Me.Parity = parity
      Me.ReadTimeout = readTimeOutms
      Me.WriteTimeout = writeTimeOutms
   End Sub

   Public Overloads Sub Open()
      Try
         MyBase.Open()
         RaiseEvent Port_Status_Changed(IsOpen, PortName + ": Open")
      Catch ex As Exception
         RaiseEvent Port_Status_Changed(IsOpen, PortName + ": not available!!")
      End Try
   End Sub

   Public Shared Function ConvertToFloat(registers As Byte()) As Single
      If registers.Length = 4 Then
         Return BitConverter.ToSingle({registers(3), registers(2), registers(1), registers(0)}, 0)
      Else
         Throw New ArgumentException("Input Array length invalid - Array length must be '4'")
      End If
   End Function

   Public Shared Function ConvertToInt(registers As Byte()) As Integer
      If registers.Length = 4 Then
         Return BitConverter.ToInt32({registers(3), registers(2), registers(1), registers(0)}, 0)
      Else
         Throw New ArgumentException("Input Array length invalid - Array length must be '4'")
      End If
   End Function
End Class