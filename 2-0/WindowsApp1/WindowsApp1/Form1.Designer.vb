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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.txtFicha = New System.Windows.Forms.TextBox()
        Me.lblIrLogin = New System.Windows.Forms.Label()
        Me.lblIrTest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 94)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(475, 195)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(232, 25)
        Me.txtNombre.TabIndex = 2
        '
        'txtDocumento
        '
        Me.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDocumento.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtDocumento.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumento.Location = New System.Drawing.Point(475, 267)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(232, 25)
        Me.txtDocumento.TabIndex = 3
        '
        'txtFicha
        '
        Me.txtFicha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFicha.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtFicha.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFicha.Location = New System.Drawing.Point(475, 336)
        Me.txtFicha.Name = "txtFicha"
        Me.txtFicha.Size = New System.Drawing.Size(232, 25)
        Me.txtFicha.TabIndex = 4
        '
        'lblIrLogin
        '
        Me.lblIrLogin.AutoSize = True
        Me.lblIrLogin.BackColor = System.Drawing.Color.Transparent
        Me.lblIrLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIrLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIrLogin.Location = New System.Drawing.Point(688, 11)
        Me.lblIrLogin.Name = "lblIrLogin"
        Me.lblIrLogin.Size = New System.Drawing.Size(114, 25)
        Me.lblIrLogin.TabIndex = 6
        Me.lblIrLogin.Text = "                 "
        '
        'lblIrTest
        '
        Me.lblIrTest.AutoSize = True
        Me.lblIrTest.BackColor = System.Drawing.Color.Transparent
        Me.lblIrTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblIrTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIrTest.Location = New System.Drawing.Point(462, 393)
        Me.lblIrTest.Name = "lblIrTest"
        Me.lblIrTest.Size = New System.Drawing.Size(263, 33)
        Me.lblIrTest.TabIndex = 7
        Me.lblIrTest.Text = "                               "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(815, 488)
        Me.Controls.Add(Me.lblIrTest)
        Me.Controls.Add(Me.lblIrLogin)
        Me.Controls.Add(Me.txtFicha)
        Me.Controls.Add(Me.txtDocumento)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents txtFicha As TextBox
    Friend WithEvents lblIrLogin As Label
    Friend WithEvents lblIrTest As Label
End Class
