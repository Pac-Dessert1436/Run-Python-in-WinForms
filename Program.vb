Imports System.IO

Friend Module Program
    Sub New()
        Try
            Dim pyScriptPath As String = Path.GetFullPath("../../../PyScripts")
            Dim targetPath As String = Path.GetFullPath("PyScripts")
            If Not Directory.Exists(targetPath) Then Directory.CreateDirectory("PyScripts")
            For Each pyScript As String In Directory.GetFiles(pyScriptPath)
                Dim fileName As String = Path.GetFileName(pyScript)
                File.Copy(pyScript, Path.Combine(targetPath, fileName), True)
            Next pyScript
        Catch
        End Try
    End Sub

    <STAThread()> Friend Sub Main()
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New frmMain)
    End Sub
End Module
