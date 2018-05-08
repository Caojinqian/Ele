<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.生成IO符号表 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.输入映射SCL = New System.Windows.Forms.Button()
        Me.输出映射SCL = New System.Windows.Forms.Button()
        Me.电机故障诊断SCL = New System.Windows.Forms.Button()
        Me.IOSheet = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '生成IO符号表
        '
        Me.生成IO符号表.Location = New System.Drawing.Point(54, 64)
        Me.生成IO符号表.Name = "生成IO符号表"
        Me.生成IO符号表.Size = New System.Drawing.Size(130, 74)
        Me.生成IO符号表.TabIndex = 0
        Me.生成IO符号表.Text = "生成IO符号表"
        Me.生成IO符号表.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(583, 412)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "电气部出品V1.1"
        '
        '输入映射SCL
        '
        Me.输入映射SCL.Location = New System.Drawing.Point(246, 64)
        Me.输入映射SCL.Name = "输入映射SCL"
        Me.输入映射SCL.Size = New System.Drawing.Size(130, 74)
        Me.输入映射SCL.TabIndex = 2
        Me.输入映射SCL.Text = "输入映射SCL"
        Me.输入映射SCL.UseVisualStyleBackColor = True
        '
        '输出映射SCL
        '
        Me.输出映射SCL.Location = New System.Drawing.Point(464, 64)
        Me.输出映射SCL.Name = "输出映射SCL"
        Me.输出映射SCL.Size = New System.Drawing.Size(130, 74)
        Me.输出映射SCL.TabIndex = 5
        Me.输出映射SCL.Text = "输出映射SCL"
        Me.输出映射SCL.UseVisualStyleBackColor = True
        '
        '电机故障诊断SCL
        '
        Me.电机故障诊断SCL.Location = New System.Drawing.Point(54, 211)
        Me.电机故障诊断SCL.Name = "电机故障诊断SCL"
        Me.电机故障诊断SCL.Size = New System.Drawing.Size(130, 74)
        Me.电机故障诊断SCL.TabIndex = 8
        Me.电机故障诊断SCL.Text = "电机故障诊断SCL"
        Me.电机故障诊断SCL.UseVisualStyleBackColor = True
        '
        'IOSheet
        '
        Me.IOSheet.Location = New System.Drawing.Point(464, 237)
        Me.IOSheet.Multiline = True
        Me.IOSheet.Name = "IOSheet"
        Me.IOSheet.Size = New System.Drawing.Size(116, 40)
        Me.IOSheet.TabIndex = 10
        Me.IOSheet.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 377)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 67)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("宋体", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(301, 246)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(157, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "输入子表名称："
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(603, 432)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "20180109"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 456)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.IOSheet)
        Me.Controls.Add(Me.电机故障诊断SCL)
        Me.Controls.Add(Me.输出映射SCL)
        Me.Controls.Add(Me.输入映射SCL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.生成IO符号表)
        Me.Name = "Form1"
        Me.Text = "上海音锋机器股份有限公司"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 生成IO符号表 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents 输入映射SCL As Button
    Friend WithEvents 输出映射SCL As Button
    Friend WithEvents 电机故障诊断SCL As Button
    Friend WithEvents IOSheet As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
