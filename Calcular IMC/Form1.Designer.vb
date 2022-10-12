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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.altura = New System.Windows.Forms.TextBox()
        Me.peso = New System.Windows.Forms.TextBox()
        Me.calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(77, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Altura"
        Me.Label1.UseWaitCursor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(77, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Peso Kg"
        Me.Label2.UseWaitCursor = True
        '
        'altura
        '
        Me.altura.Location = New System.Drawing.Point(77, 51)
        Me.altura.Name = "altura"
        Me.altura.Size = New System.Drawing.Size(100, 23)
        Me.altura.TabIndex = 2
        Me.altura.UseWaitCursor = True
        '
        'peso
        '
        Me.peso.Location = New System.Drawing.Point(77, 109)
        Me.peso.Name = "peso"
        Me.peso.Size = New System.Drawing.Size(100, 23)
        Me.peso.TabIndex = 3
        Me.peso.UseWaitCursor = True
        '
        'calcular
        '
        Me.calcular.Location = New System.Drawing.Point(77, 154)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(100, 33)
        Me.calcular.TabIndex = 4
        Me.calcular.Text = "Calcular"
        Me.calcular.UseVisualStyleBackColor = True
        Me.calcular.UseWaitCursor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(259, 228)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.peso)
        Me.Controls.Add(Me.altura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calcular IMC"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents altura As TextBox
    Friend WithEvents peso As TextBox
    Friend WithEvents calcular As Button
End Class
