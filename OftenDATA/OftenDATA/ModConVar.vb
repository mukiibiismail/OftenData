
Imports System.Data.OleDb
Imports System.Configuration

Module ModConVar
    Public sqL As String
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public conn As OleDbConnection

   
    Public Sub ConnDB()
        Try

            Dim strcon As String = ConfigurationManager.ConnectionStrings("ConString").ConnectionString
            conn = New OleDbConnection(strcon)
            conn.Open()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Function CurrentLogin()

        Dim currentlog As String
        currentlog = frmLogin. LoginUserName

        Return currentlog
    End Function

    'Public Function CurrentFullName()

    '    Dim currentfn As String
    '    ' currentfn = frmMain.lblloggedFullName.Text

    '    Return currentfn
    'End Function

    'Public Function StringEnteredIn(x As Control, ByRef dispalyMsg As String)
    '    Dim rtnString As String = "Please Enter " + dispalyMsg
    '    If x.Text.Length > 0 Then
    '        rtnString = ""

    '    End If
    '    Return rtnString
    'End Function
End Module



Module ConvertToNumbers
        Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
            'Let's make sure entered value is numeric)
            If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

            Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
                tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
            nAmount = Replace(nAmount, tempDecValue, String.Empty)

            Try
                Dim intAmount As Long = nAmount
                If intAmount > 0 Then
                    nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                     > (CLng(intAmount.ToString.Trim.Length / 3)), _
                      CLng(intAmount.ToString.Trim.Length / 3) + 1, _
                       CLng(intAmount.ToString.Trim.Length / 3))
                    Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim, _
                      (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                    Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                    Dim Ones() As String = _
                    {"", "One", "Two", "Three", _
                      "Four", "Five", _
                      "Six", "Seven", "Eight", "Nine"}
                    Dim Teens() As String = {"", _
                    "Eleven", "Twelve", "Thirteen", _
                      "Fourteen", "Fifteen", _
                      "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                    Dim Tens() As String = {"", "Ten", _
                    "Twenty", "Thirty", _
                      "Forty", "Fifty", "Sixty", _
                      "Seventy", "Eighty", "Ninety"}
                    Dim HMBT() As String = {"", "", _
                    "Thousand", "Million", _
                      "Billion", "Trillion", _
                      "Quadrillion", "Quintillion"}

                    intAmount = eAmount

                    Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                    Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                    Dim nOne As Integer = intAmount \ 1

                    If nHundred > 0 Then wAmount = wAmount & _
                    Ones(nHundred) & " Hundred " 'This is for hundreds                
                    If nTen > 0 Then 'This is for tens and teens
                        If nTen = 1 And nOne > 0 Then 'This is for teens 
                            wAmount = wAmount & Teens(nOne) & " "
                        Else 'This is for tens, 10 to 90
                            wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, "-", " ")
                            If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                        End If
                    Else 'This is for ones, 1 to 9
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                    wAmount = wAmount & HMBT(nSet) & " "
                    wAmount = AmountInWords(CStr(CLng(nAmount) - _
                      (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
                Else
                    If Val(nAmount) = 0 Then nAmount = nAmount & _
                    tempDecValue : tempDecValue = String.Empty
                    If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount = _
                      Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100), _
                      wAmount.Trim & "", 1)) & " Cents"
                End If
            Catch ex As Exception
                MessageBox.Show("Error Encountered: " & ex.Message, _
                  "Convert Currency To Words", _
                  MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return "!Error"
            End Try

            'Trap null values
            If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount = _
              IIf(InStr(wAmount.Trim.ToLower, ""), _
              wAmount.Trim, wAmount.Trim & "")

            'Display the result
            Return wAmount
        End Function

    End Module

    Public Class Cypher
        Private _shiftCount As Integer
        Public Property ShiftCount() As Integer
            Get
                Return _shiftCount
            End Get
            Set(ByVal value As Integer)
                _shiftCount = value
            End Set
        End Property
        Public Sub New()
            Me.New(3)
        End Sub
        Public Sub New(ByVal shiftCount As Integer)
            Me.ShiftCount = shiftCount
        End Sub
        Public Function Encipher(ByVal plainText As String) As String
            Dim cipherText As String = String.Empty
            Dim cipherInChars(plainText.Length) As Char
            For i As Integer = 0 To plainText.Length - 1
                cipherInChars(i) = Convert.ToChar((Convert.ToInt32(Convert.ToChar(plainText(i))) + Me.ShiftCount))
            Next
            cipherText = New String(cipherInChars)
            Return cipherText
        End Function
        Public Function Decipher(ByVal cipherText As String) As String
            Dim plainText As String = String.Empty
            Dim cipherInChars(cipherText.Length) As Char
            For i As Integer = 0 To cipherText.Length - 1
                cipherInChars(i) = Convert.ToChar((Convert.ToInt32(Convert.ToChar(cipherText(i))) - Me.ShiftCount))
            Next
            plainText = New String(cipherInChars)
            Return plainText
        End Function
    End Class



