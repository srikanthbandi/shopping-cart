'project: The style store
'purpose: to calculate the total price of the items purchased.
'created/edited : Srikanth.bandi/(12/16/2016)


Option Explicit On
Option Strict On
Option Infer Off

Public Class shoppingcart
    Public price As Double
    Public total_price As Double

   

    Public Sub New()
        price = 0
        total_price = 0
    End Sub

    'function to add the total amount
    Public Function total() As Double
        Return total_price + price
    End Function

End Class
