<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.listViewLogs = New System.Windows.Forms.ListView()
        Me.btnRefreshLogs = New System.Windows.Forms.Button()
        Me.btnDeleteLogs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listViewLogs
        '
        Me.listViewLogs.HideSelection = False
        Me.listViewLogs.Location = New System.Drawing.Point(67, 3)
        Me.listViewLogs.Name = "listViewLogs"
        Me.listViewLogs.Size = New System.Drawing.Size(693, 221)
        Me.listViewLogs.TabIndex = 0
        Me.listViewLogs.UseCompatibleStateImageBehavior = False
        '
        'btnRefreshLogs
        '
        Me.btnRefreshLogs.Location = New System.Drawing.Point(349, 230)
        Me.btnRefreshLogs.Name = "btnRefreshLogs"
        Me.btnRefreshLogs.Size = New System.Drawing.Size(107, 42)
        Me.btnRefreshLogs.TabIndex = 1
        Me.btnRefreshLogs.Text = "Refresh Logs"
        Me.btnRefreshLogs.UseVisualStyleBackColor = True
        '
        'btnDeleteLogs
        '
        Me.btnDeleteLogs.Location = New System.Drawing.Point(349, 278)
        Me.btnDeleteLogs.Name = "btnDeleteLogs"
        Me.btnDeleteLogs.Size = New System.Drawing.Size(148, 41)
        Me.btnDeleteLogs.TabIndex = 2
        Me.btnDeleteLogs.Text = "Delete Selected Logs"
        Me.btnDeleteLogs.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnDeleteLogs)
        Me.Controls.Add(Me.btnRefreshLogs)
        Me.Controls.Add(Me.listViewLogs)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listViewLogs As ListView
    Friend WithEvents btnRefreshLogs As Button
    Friend WithEvents btnDeleteLogs As Button
End Class
