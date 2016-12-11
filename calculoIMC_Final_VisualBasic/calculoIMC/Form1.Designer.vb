<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbPeso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbAltura = New System.Windows.Forms.TextBox()
        Me.btCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbPeso
        '
        Me.tbPeso.Location = New System.Drawing.Point(195, 24)
        Me.tbPeso.Name = "tbPeso"
        Me.tbPeso.Size = New System.Drawing.Size(93, 20)
        Me.tbPeso.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese su peso (Kg)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(85, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingrese su altura (m)"
        '
        'tbAltura
        '
        Me.tbAltura.Location = New System.Drawing.Point(195, 59)
        Me.tbAltura.Name = "tbAltura"
        Me.tbAltura.Size = New System.Drawing.Size(93, 20)
        Me.tbAltura.TabIndex = 2
        '
        'btCalcular
        '
        Me.btCalcular.Location = New System.Drawing.Point(195, 97)
        Me.btCalcular.Name = "btCalcular"
        Me.btCalcular.Size = New System.Drawing.Size(93, 28)
        Me.btCalcular.TabIndex = 4
        Me.btCalcular.Text = "Calcular"
        Me.btCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 180)
        Me.Controls.Add(Me.btCalcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbAltura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbPeso)
        Me.Name = "Form1"
        Me.Text = "Cálculo del Indice de Masa Corporal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPeso As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbAltura As TextBox
    Friend WithEvents btCalcular As Button
End Class
