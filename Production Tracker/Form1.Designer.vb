<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        dgvProd = New DataGridView()
        btnLoad = New Button()
        CType(dgvProd, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvProd
        ' 
        dgvProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvProd.Location = New Point(8, 77)
        dgvProd.Name = "dgvProd"
        dgvProd.Size = New Size(1347, 779)
        dgvProd.TabIndex = 0
        ' 
        ' btnLoad
        ' 
        btnLoad.Location = New Point(1245, 24)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(108, 30)
        btnLoad.TabIndex = 1
        btnLoad.Text = "Load Data"
        btnLoad.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1365, 866)
        Controls.Add(btnLoad)
        Controls.Add(dgvProd)
        Name = "Form1"
        Text = "Form1"
        CType(dgvProd, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgvProd As DataGridView
    Friend WithEvents btnLoad As Button

End Class
