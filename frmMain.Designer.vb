<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtPyScriptName = New TextBox()
        lblFirstPrompt = New Label()
        btnRunPyScript = New Button()
        lblExampleUsage = New Label()
        lblUsageHints = New Label()
        chkWithArguments = New CheckBox()
        SuspendLayout()
        ' 
        ' txtPyScriptName
        ' 
        txtPyScriptName.Font = New Font("Cascadia Mono SemiBold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPyScriptName.Location = New Point(59, 71)
        txtPyScriptName.Name = "txtPyScriptName"
        txtPyScriptName.Size = New Size(646, 32)
        txtPyScriptName.TabIndex = 0
        ' 
        ' lblFirstPrompt
        ' 
        lblFirstPrompt.AutoSize = True
        lblFirstPrompt.Font = New Font("Cascadia Mono", 10.5F, FontStyle.Italic)
        lblFirstPrompt.Location = New Point(59, 25)
        lblFirstPrompt.Name = "lblFirstPrompt"
        lblFirstPrompt.Size = New Size(600, 28)
        lblFirstPrompt.TabIndex = 1
        lblFirstPrompt.Text = "Enter the Python script name (without extension):"
        ' 
        ' btnRunPyScript
        ' 
        btnRunPyScript.Font = New Font("Cascadia Mono", 10.5F, FontStyle.Italic)
        btnRunPyScript.Location = New Point(106, 121)
        btnRunPyScript.Name = "btnRunPyScript"
        btnRunPyScript.Size = New Size(301, 42)
        btnRunPyScript.TabIndex = 2
        btnRunPyScript.Text = "Run Python Script"
        btnRunPyScript.UseVisualStyleBackColor = True
        ' 
        ' lblExampleUsage
        ' 
        lblExampleUsage.AutoSize = True
        lblExampleUsage.Font = New Font("Cascadia Mono SemiBold", 10.5F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblExampleUsage.Location = New Point(29, 284)
        lblExampleUsage.Name = "lblExampleUsage"
        lblExampleUsage.Size = New Size(0, 28)
        lblExampleUsage.TabIndex = 3
        ' 
        ' lblUsageHints
        ' 
        lblUsageHints.AutoSize = True
        lblUsageHints.Font = New Font("Cascadia Mono", 10.5F, FontStyle.Italic)
        lblUsageHints.Location = New Point(29, 193)
        lblUsageHints.Name = "lblUsageHints"
        lblUsageHints.Size = New Size(0, 28)
        lblUsageHints.TabIndex = 4
        ' 
        ' chkWithArguments
        ' 
        chkWithArguments.AutoSize = True
        chkWithArguments.Font = New Font("Cascadia Mono", 10.5F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chkWithArguments.Location = New Point(439, 127)
        chkWithArguments.Name = "chkWithArguments"
        chkWithArguments.Size = New Size(206, 32)
        chkWithArguments.TabIndex = 5
        chkWithArguments.Text = "With Arguments"
        chkWithArguments.UseVisualStyleBackColor = True
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(11F, 24F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 534)
        Controls.Add(chkWithArguments)
        Controls.Add(lblUsageHints)
        Controls.Add(lblExampleUsage)
        Controls.Add(btnRunPyScript)
        Controls.Add(lblFirstPrompt)
        Controls.Add(txtPyScriptName)
        Name = "frmMain"
        Text = "Run Python in WinForms"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtPyScriptName As TextBox
    Friend WithEvents lblFirstPrompt As Label
    Friend WithEvents btnRunPyScript As Button
    Friend WithEvents lblExampleUsage As Label
    Friend WithEvents lblUsageHints As Label
    Friend WithEvents chkWithArguments As CheckBox

End Class
