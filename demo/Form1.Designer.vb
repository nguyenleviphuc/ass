<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class demo
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
        Me.btnnhaplai = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnluu = New System.Windows.Forms.Button()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.txtSoluong = New System.Windows.Forms.TextBox()
        Me.txtDongia = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnnhaplai
        '
        Me.btnnhaplai.Location = New System.Drawing.Point(365, 24)
        Me.btnnhaplai.Name = "btnnhaplai"
        Me.btnnhaplai.Size = New System.Drawing.Size(75, 23)
        Me.btnnhaplai.TabIndex = 0
        Me.btnnhaplai.Text = "Nhâp lại"
        Me.btnnhaplai.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(365, 59)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 1
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(474, 24)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 2
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnluu
        '
        Me.btnluu.Location = New System.Drawing.Point(474, 59)
        Me.btnluu.Name = "btnluu"
        Me.btnluu.Size = New System.Drawing.Size(75, 23)
        Me.btnluu.TabIndex = 3
        Me.btnluu.Text = "Lưu"
        Me.btnluu.UseVisualStyleBackColor = True
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(62, 50)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(100, 20)
        Me.txtTenSP.TabIndex = 4
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(62, 24)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(100, 20)
        Me.txtMaSP.TabIndex = 5
        '
        'txtSoluong
        '
        Me.txtSoluong.Location = New System.Drawing.Point(229, 24)
        Me.txtSoluong.Name = "txtSoluong"
        Me.txtSoluong.Size = New System.Drawing.Size(100, 20)
        Me.txtSoluong.TabIndex = 6
        '
        'txtDongia
        '
        Me.txtDongia.Location = New System.Drawing.Point(229, 50)
        Me.txtDongia.Name = "txtDongia"
        Me.txtDongia.Size = New System.Drawing.Size(100, 20)
        Me.txtDongia.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 120)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(512, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'demo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 295)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtDongia)
        Me.Controls.Add(Me.txtSoluong)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.btnluu)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnnhaplai)
        Me.Name = "demo"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnnhaplai As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnluu As System.Windows.Forms.Button
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents txtSoluong As System.Windows.Forms.TextBox
    Friend WithEvents txtDongia As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
