'Project Name: The style store
'Purpose: The online purchase store for clothes.
'created/edited: 12/15/2016- srikanth.bandi

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private item_price As String
    'two-dimensioanl array to store elements
    Private clothes(,) As String = {{"shirts", "50"},
                                    {"pants", "55"},
                                    {"tshirts", "25"},
                                    {"shorts", "15"},
                                    {"shoes", "60"},
                                    {"caps", "9"}}

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        shoppingitemsListBox.Items.Add("Shirts")
        shoppingitemsListBox.Items.Add("Pants")
        shoppingitemsListBox.Items.Add("Tshirts")
        shoppingitemsListBox.Items.Add("Shorts")
        shoppingitemsListBox.Items.Add("Shoes")
        shoppingitemsListBox.Items.Add("Caps")

        addtocartButton.Enabled = False
        searchButton.Enabled = False
        checkoutButton.Enabled = False
    End Sub

    'code to search for a particular item in the application
    Private Sub searchButton_Click(sender As Object, e As EventArgs) Handles searchButton.Click
        Dim name_of_item As String
        Dim price_of_item As String
        Dim row As Integer
        Dim highRow As Integer = clothes.GetUpperBound(0)
        Dim found As Boolean

        name_of_item = searchTextBox.Text.ToLower

        Do While row <= highRow AndAlso found = False
            If name_of_item = clothes(row, 0) Then
                price_of_item = clothes(row, 1)
                pricedisplayLabel.Text = price_of_item.ToString
                found = True
            Else
                row += 1
            End If

            If row > highRow Then
                MessageBox.Show("Sorry! The item doesn't exist!", "Error message", MessageBoxButtons.OK)
            End If
        Loop

    End Sub


    'codeto add the selected items to the cart
    Private Sub addtocartButton_Click(sender As Object, e As EventArgs) Handles addtocartButton.Click

        Dim price As Integer
        Dim adding_item As String
        Dim outFile As IO.StreamWriter

        'Dim Heading As String = "Item Name" & Strings.Space(12) & "Price"
        outFile = IO.File.AppendText("shoppingcart.txt")
        price = shoppingitemsListBox.SelectedIndex

        Select Case price
            Case 0
                item_price = clothes(price, 1)
            Case 1
                item_price = clothes(price, 1)
            Case 2
                item_price = clothes(price, 1)
            Case 3
                item_price = clothes(price, 1)
            Case 4
                item_price = clothes(price, 1)
            Case 5
                item_price = clothes(price, 1)
        End Select

        adding_item = CStr(shoppingitemsListBox.SelectedItem)
        shopingcartListBox.Items.Add(adding_item & "," & item_price)
        'writing the selecteditems to the file
        outFile.WriteLine(clothes(price, 0))
        outFile.Close()

    End Sub

    'code to calculate the total priceof the selected items by reading from the file

    Private Sub checkoutButton_Click(sender As Object, e As EventArgs) Handles checkoutButton.Click

        Dim read As String
        Dim i As Integer = clothes.GetUpperBound(0)
        Dim total As Double = 0
        Dim totalPrice As Double
        Dim checkout As New shoppingcart
        Dim inFile As IO.StreamReader
        'checking whether cart exists or not'
        If IO.File.Exists("Shoppingcart.txt") Then
            inFile = IO.File.OpenText("Shoppingcart.txt")
            'reading from file'
            Do Until inFile.Peek = -1
                read = inFile.ReadLine
                'calculations using class'
                For row As Integer = 0 To i
                    If read = clothes(row, 0) Then
                        checkout.total_price = total
                        checkout.price = Val(clothes(row, 1))
                        totalPrice += checkout.total()
                    End If
                Next row
            Loop
            inFile.Close()
        Else
            MessageBox.Show("the required file doesn't exist", "file error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        'displaying output'
        totaldisplayLabel.Text = totalPrice.ToString("c2")
    End Sub


    'code to validate the login credentials

    Private Sub LoginToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem1.Click
        Dim password As String
        password = InputBox("Please enter Password")
        password = password.ToUpper()
        If password.Length = 6 Then
            If password Like "[A-D][0-9][0-9][M-T][0-9][A-Z]" Then
                searchButton.Enabled = True
                addtocartButton.Enabled = True
                checkoutButton.Enabled = True
            Else
                MessageBox.Show("The Password is not valid,Please try again", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("The Password is not valid,Please try again", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    'to exit the appliaction from menu
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
