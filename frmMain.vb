Option Strict Off
Imports Python.Runtime

#Disable Warning IDE1006
Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FormBorderStyle = FormBorderStyle.Fixed3D
        Runtime.PythonDLL = "python311.dll"

        lblUsageHints.Text = "The Python scripts to be run in WinForms are located at the
""PyScripts"" folder. Define the Python main function as follows
so that its output can be recieved by the WinForms:"
        lblExampleUsage.Text = "from io import StringIO

# Arguments in the main function are passed internally.
def main(output: StringIO) -> str:
    print(""Hello world!"", file=output)
    return output.getvalue()"
    End Sub

    Private Sub btnRunPyScript_Click(sender As Object, e As EventArgs) Handles btnRunPyScript.Click
        Try
            PythonEngine.Initialize()
            If txtPyScriptName.Text.Length = 0 Then
                Throw New InvalidOperationException("Script name cannot be empty.")
            ElseIf txtPyScriptName.Text.Contains(" "c) Then
                Throw New InvalidOperationException("Script name cannot contain a space.")
            End If
            Using Py.GIL()
                Dim pyScript As Object = Py.Import($"PyScripts.{txtPyScriptName.Text}")
                pyScript.output = CObj(Py.Import("io")).StringIO()
                Dim pyArgList As New PyList, pyOutput As PyObject
                If chkWithArguments.Checked Then
                    Dim argsInput = InputBox("Enter the argument(s) for the main function, 
using a comma to separate each one:")
                    For Each pyArg In argsInput.Split(","c).Select(Function(x) x.Trim())
                        Dim pyInt As New Long, pyFloat As New Double
                        If Long.TryParse(pyArg, pyInt) Then
                            pyArgList.Append(pyInt.ToPython())
                        Else
                            If Double.TryParse(pyArg, pyFloat) Then
                                pyArgList.Append(pyFloat.ToPython())
                            Else
                                pyArgList.Append(pyArg.ToPython())
                            End If
                        End If
                    Next pyArg
                    pyOutput = pyScript.main(pyScript.output, pyArgList)
                Else
                    pyOutput = pyScript.main(pyScript.output)
                End If
                MsgBox(Convert.ToString(pyOutput))
            End Using
        Catch ex As Exception
            MsgBox($"{ex.GetType().Name}: {ex.Message}")
        Finally
            PythonEngine.Shutdown()
        End Try
    End Sub

    Private Sub chkWithArguments_CheckedChanged(sender As Object, e As EventArgs) _
            Handles chkWithArguments.CheckedChanged
        If chkWithArguments.Checked Then
            lblExampleUsage.Text = "from io import StringIO

# Arguments in the main function are passed internally.
def main(output: StringIO, args: list = []) -> str:
    print(str().join(args), file=output)
    return output.getvalue()"
        Else
            lblExampleUsage.Text = "from io import StringIO

# Arguments in the main function are passed internally.
def main(output: StringIO) -> str:
    print(""Hello world!"", file=output)
    return output.getvalue()"
        End If
    End Sub
End Class
#Enable Warning IDE1006