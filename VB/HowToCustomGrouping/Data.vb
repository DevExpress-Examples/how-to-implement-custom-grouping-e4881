Public Class Data
    Public Class Product
        Public Property ProductName() As String
            Get
                Return m_ProductName
            End Get
            Set(value As String)
                m_ProductName = Value
            End Set
        End Property
        Private m_ProductName As String
        Public Property Supplier() As String
            Get
                Return m_Supplier
            End Get
            Set(value As String)
                m_Supplier = Value
            End Set
        End Property
        Private m_Supplier As String
        Public Property UnitPrice() As Integer
            Get
                Return m_UnitPrice
            End Get
            Set(value As Integer)
                m_UnitPrice = Value
            End Set
        End Property
        Private m_UnitPrice As Integer
        Public Property Quantity() As Integer
            Get
                Return m_Quantity
            End Get
            Set(value As Integer)
                m_Quantity = Value
            End Set
        End Property
        Private m_Quantity As Integer
    End Class

    Public Class ProductList
        Inherits ObservableCollection(Of Product)
        Public Sub New()
            MyBase.New()

            Add(New Product() With { _
                .ProductName = "Chang", _
                .Supplier = "Exotic Liquids", _
                .UnitPrice = 19, _
                .Quantity = 10 _
            })
            Add(New Product() With { _
                .ProductName = "Gravad lax", _
                .Supplier = "Svensk Sjöföda AB", _
                .UnitPrice = 8, _
                .Quantity = 16 _
            })
            Add(New Product() With { _
                .ProductName = "Ravioli Angelo", _
                .Supplier = "Pasta Buttini s.r.l.", _
                .UnitPrice = 62, _
                .Quantity = 12 _
            })
            Add(New Product() With { _
                .ProductName = "Tarte au sucre", _
                .Supplier = "Forêts d'érables", _
                .UnitPrice = 42, _
                .Quantity = 50 _
            })
            Add(New Product() With { _
                .ProductName = "Steeleye Stout", _
                .Supplier = "Bigfoot Breweries", _
                .UnitPrice = 78, _
                .Quantity = 20 _
            })
            Add(New Product() With { _
                .ProductName = "Pavlova", _
                .Supplier = "Pavlova, Ltd.", _
                .UnitPrice = 21, _
                .Quantity = 52 _
            })
            Add(New Product() With { _
                .ProductName = "Longlife Tofu", _
                .Supplier = "Mayumi's", _
                .UnitPrice = 4, _
                .Quantity = 120 _
            })
            Add(New Product() With { _
                .ProductName = "Alice Mutton", _
                .Supplier = "Pavlova, Ltd.", _
                .UnitPrice = 34, _
                .Quantity = 15 _
            })
            Add(New Product() With { _
                .ProductName = "Aniseed Syrup", _
                .Supplier = "Exotic Liquids", _
                .UnitPrice = 6, _
                .Quantity = 49 _
            })
            Add(New Product() With { _
                .ProductName = "Tunnbröd", _
                .Supplier = "PB Knäckebröd AB", _
                .UnitPrice = 91, _
                .Quantity = 38 _
            })
            Add(New Product() With { _
                .ProductName = "Ipoh Coffee", _
                .Supplier = "Leka Trading", _
                .UnitPrice = 29, _
                .Quantity = 3 _
            })
            Add(New Product() With { _
                .ProductName = "Filo Mix", _
                .Supplier = "G'day, Mate", _
                .UnitPrice = 117, _
                .Quantity = 14 _
            })
        End Sub
    End Class
End Class
