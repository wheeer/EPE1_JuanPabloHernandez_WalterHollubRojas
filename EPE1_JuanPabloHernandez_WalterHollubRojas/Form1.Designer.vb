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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnCargar = New Button()
        txtDescripcion = New TextBox()
        txtPrecio = New TextBox()
        txtStock = New TextBox()
        cmbProductos = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 15)
        Label1.TabIndex = 0
        Label1.Text = " Borton de Carga C.Box"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 15)
        Label2.TabIndex = 1
        Label2.Text = " Selecc. Cod. Producto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(101, 15)
        Label3.TabIndex = 2
        Label3.Text = " Detalle Producto:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 179)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 15)
        Label4.TabIndex = 3
        Label4.Text = " Nombre del Producto"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(232, 179)
        Label5.Name = "Label5"
        Label5.Size = New Size(114, 15)
        Label5.TabIndex = 4
        Label5.Text = " Precio del Producto"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(371, 179)
        Label6.Name = "Label6"
        Label6.Size = New Size(116, 15)
        Label6.TabIndex = 5
        Label6.Text = " Stock del Preoducto"
        ' 
        ' btnCargar
        ' 
        btnCargar.Location = New Point(167, 37)
        btnCargar.Name = "btnCargar"
        btnCargar.Size = New Size(192, 23)
        btnCargar.TabIndex = 6
        btnCargar.Text = "Cargar Datos al Combo"
        btnCargar.UseVisualStyleBackColor = True
        ' 
        ' txtDescripcion
        ' 
        txtDescripcion.Location = New Point(12, 217)
        txtDescripcion.Name = "txtDescripcion"
        txtDescripcion.Size = New Size(181, 23)
        txtDescripcion.TabIndex = 7
        ' 
        ' txtPrecio
        ' 
        txtPrecio.Location = New Point(232, 217)
        txtPrecio.Name = "txtPrecio"
        txtPrecio.Size = New Size(114, 23)
        txtPrecio.TabIndex = 8
        ' 
        ' txtStock
        ' 
        txtStock.Location = New Point(373, 217)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(114, 23)
        txtStock.TabIndex = 9
        ' 
        ' cmbProductos
        ' 
        cmbProductos.FormattingEnabled = True
        cmbProductos.Location = New Point(167, 82)
        cmbProductos.Name = "cmbProductos"
        cmbProductos.Size = New Size(192, 23)
        cmbProductos.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(584, 314)
        Controls.Add(cmbProductos)
        Controls.Add(txtStock)
        Controls.Add(txtPrecio)
        Controls.Add(txtDescripcion)
        Controls.Add(btnCargar)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnCargar As Button
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents cmbProductos As ComboBox

End Class
