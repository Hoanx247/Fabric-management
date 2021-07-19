Public Class ClsCustomer
    Private _customerId As String
    Private _customername As String
    Private _customerAddress As String
    Private _customertax As String
    Private _customerComments As String

    Public Sub New()

    End Sub
    Public Sub New(ByVal mssv$, ByVal hoten$, ByVal diemtoan As Double, ByVal diemly As Double, ByVal diemhoa As Double)


    End Sub
    Public Property customerId() As String
        Get
            Return _customerId
        End Get
        Set(ByVal value As String)
            _customerId = value
        End Set
    End Property
    Public Property customername() As String
        Get
            Return _customername
        End Get
        Set(ByVal value As String)
            _customername = value
        End Set
    End Property
    Public Property customerAddress() As String
        Get
            Return _customerAddress
        End Get
        Set(ByVal value As String)
            _customerAddress = value
        End Set
    End Property
    Public Property customertax() As String
        Get
            Return _customertax
        End Get
        Set(ByVal value As String)
            _customertax = value
        End Set
    End Property
    Public Property customerComments() As String
        Get
            Return _customerComments
        End Get
        Set(ByVal value As String)
            _customerComments = value
        End Set
    End Property
End Class
