<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.shoppingitemsListBox = New System.Windows.Forms.ListBox()
        Me.shopingcartListBox = New System.Windows.Forms.ListBox()
        Me.mainPictureBox = New System.Windows.Forms.PictureBox()
        Me.maintitleLabel = New System.Windows.Forms.Label()
        Me.itemsLabel = New System.Windows.Forms.Label()
        Me.cartLabel = New System.Windows.Forms.Label()
        Me.addtocartButton = New System.Windows.Forms.Button()
        Me.checkoutButton = New System.Windows.Forms.Button()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.searchLabel = New System.Windows.Forms.Label()
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.pricedisplayLabel = New System.Windows.Forms.Label()
        Me.totallabel = New System.Windows.Forms.Label()
        Me.totaldisplayLabel = New System.Windows.Forms.Label()
        Me.loginMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.exitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.mainPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loginMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'shoppingitemsListBox
        '
        Me.shoppingitemsListBox.FormattingEnabled = True
        Me.shoppingitemsListBox.Location = New System.Drawing.Point(32, 160)
        Me.shoppingitemsListBox.Name = "shoppingitemsListBox"
        Me.shoppingitemsListBox.Size = New System.Drawing.Size(110, 173)
        Me.shoppingitemsListBox.TabIndex = 0
        '
        'shopingcartListBox
        '
        Me.shopingcartListBox.FormattingEnabled = True
        Me.shopingcartListBox.Location = New System.Drawing.Point(455, 160)
        Me.shopingcartListBox.Name = "shopingcartListBox"
        Me.shopingcartListBox.Size = New System.Drawing.Size(110, 173)
        Me.shopingcartListBox.TabIndex = 1
        '
        'mainPictureBox
        '
        Me.mainPictureBox.Image = CType(resources.GetObject("mainPictureBox.Image"), System.Drawing.Image)
        Me.mainPictureBox.Location = New System.Drawing.Point(32, 35)
        Me.mainPictureBox.Name = "mainPictureBox"
        Me.mainPictureBox.Size = New System.Drawing.Size(110, 94)
        Me.mainPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.mainPictureBox.TabIndex = 2
        Me.mainPictureBox.TabStop = False
        '
        'maintitleLabel
        '
        Me.maintitleLabel.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maintitleLabel.Location = New System.Drawing.Point(250, 37)
        Me.maintitleLabel.Name = "maintitleLabel"
        Me.maintitleLabel.Size = New System.Drawing.Size(238, 33)
        Me.maintitleLabel.TabIndex = 3
        Me.maintitleLabel.Text = "THE STYLE STORE."
        '
        'itemsLabel
        '
        Me.itemsLabel.AutoSize = True
        Me.itemsLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemsLabel.Location = New System.Drawing.Point(29, 132)
        Me.itemsLabel.Name = "itemsLabel"
        Me.itemsLabel.Size = New System.Drawing.Size(102, 17)
        Me.itemsLabel.TabIndex = 4
        Me.itemsLabel.Text = "Items for SALE!"
        '
        'cartLabel
        '
        Me.cartLabel.AutoSize = True
        Me.cartLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cartLabel.Location = New System.Drawing.Point(455, 132)
        Me.cartLabel.Name = "cartLabel"
        Me.cartLabel.Size = New System.Drawing.Size(106, 17)
        Me.cartLabel.TabIndex = 5
        Me.cartLabel.Text = "Shoppping cart."
        '
        'addtocartButton
        '
        Me.addtocartButton.Location = New System.Drawing.Point(169, 272)
        Me.addtocartButton.Name = "addtocartButton"
        Me.addtocartButton.Size = New System.Drawing.Size(75, 23)
        Me.addtocartButton.TabIndex = 6
        Me.addtocartButton.Text = "Add to cart"
        Me.addtocartButton.UseVisualStyleBackColor = True
        '
        'checkoutButton
        '
        Me.checkoutButton.Location = New System.Drawing.Point(336, 272)
        Me.checkoutButton.Name = "checkoutButton"
        Me.checkoutButton.Size = New System.Drawing.Size(75, 23)
        Me.checkoutButton.TabIndex = 7
        Me.checkoutButton.Text = "&Chekout"
        Me.checkoutButton.UseVisualStyleBackColor = True
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(252, 222)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(75, 23)
        Me.searchButton.TabIndex = 8
        Me.searchButton.Text = "&Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(166, 171)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(100, 22)
        Me.searchTextBox.TabIndex = 9
        '
        'searchLabel
        '
        Me.searchLabel.AutoSize = True
        Me.searchLabel.Location = New System.Drawing.Point(166, 152)
        Me.searchLabel.Name = "searchLabel"
        Me.searchLabel.Size = New System.Drawing.Size(100, 13)
        Me.searchLabel.TabIndex = 10
        Me.searchLabel.Text = "Enter search value"
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(310, 152)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(34, 13)
        Me.priceLabel.TabIndex = 11
        Me.priceLabel.Text = "Price:"
        '
        'pricedisplayLabel
        '
        Me.pricedisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pricedisplayLabel.Location = New System.Drawing.Point(310, 171)
        Me.pricedisplayLabel.Name = "pricedisplayLabel"
        Me.pricedisplayLabel.Size = New System.Drawing.Size(87, 22)
        Me.pricedisplayLabel.TabIndex = 12
        '
        'totallabel
        '
        Me.totallabel.AutoSize = True
        Me.totallabel.Location = New System.Drawing.Point(252, 319)
        Me.totallabel.Name = "totallabel"
        Me.totallabel.Size = New System.Drawing.Size(34, 13)
        Me.totallabel.TabIndex = 13
        Me.totallabel.Text = "Total:"
        '
        'totaldisplayLabel
        '
        Me.totaldisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totaldisplayLabel.Location = New System.Drawing.Point(255, 341)
        Me.totaldisplayLabel.Name = "totaldisplayLabel"
        Me.totaldisplayLabel.Size = New System.Drawing.Size(72, 23)
        Me.totaldisplayLabel.TabIndex = 14
        '
        'loginMenuStrip
        '
        Me.loginMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.loginMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.loginMenuStrip.Name = "loginMenuStrip"
        Me.loginMenuStrip.Size = New System.Drawing.Size(610, 24)
        Me.loginMenuStrip.TabIndex = 15
        Me.loginMenuStrip.Text = "File"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem1, Me.exitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'LoginToolStripMenuItem1
        '
        Me.LoginToolStripMenuItem1.Name = "LoginToolStripMenuItem1"
        Me.LoginToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoginToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem1.Text = "login"
        '
        'exitToolStripMenuItem
        '
        Me.exitToolStripMenuItem.Name = "exitToolStripMenuItem"
        Me.exitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.exitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.exitToolStripMenuItem.Text = "exit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 391)
        Me.Controls.Add(Me.totaldisplayLabel)
        Me.Controls.Add(Me.totallabel)
        Me.Controls.Add(Me.pricedisplayLabel)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.searchLabel)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.checkoutButton)
        Me.Controls.Add(Me.addtocartButton)
        Me.Controls.Add(Me.cartLabel)
        Me.Controls.Add(Me.itemsLabel)
        Me.Controls.Add(Me.maintitleLabel)
        Me.Controls.Add(Me.mainPictureBox)
        Me.Controls.Add(Me.shopingcartListBox)
        Me.Controls.Add(Me.shoppingitemsListBox)
        Me.Controls.Add(Me.loginMenuStrip)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.loginMenuStrip
        Me.Name = "MainForm"
        Me.Text = "Form1"
        CType(Me.mainPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loginMenuStrip.ResumeLayout(False)
        Me.loginMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents shoppingitemsListBox As System.Windows.Forms.ListBox
    Friend WithEvents shopingcartListBox As System.Windows.Forms.ListBox
    Friend WithEvents mainPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents maintitleLabel As System.Windows.Forms.Label
    Friend WithEvents itemsLabel As System.Windows.Forms.Label
    Friend WithEvents cartLabel As System.Windows.Forms.Label
    Friend WithEvents addtocartButton As System.Windows.Forms.Button
    Friend WithEvents checkoutButton As System.Windows.Forms.Button
    Friend WithEvents searchButton As System.Windows.Forms.Button
    Friend WithEvents searchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents searchLabel As System.Windows.Forms.Label
    Friend WithEvents priceLabel As System.Windows.Forms.Label
    Friend WithEvents pricedisplayLabel As System.Windows.Forms.Label
    Friend WithEvents totallabel As System.Windows.Forms.Label
    Friend WithEvents totaldisplayLabel As System.Windows.Forms.Label
    Friend WithEvents loginMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents exitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
