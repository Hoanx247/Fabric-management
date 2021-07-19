Public Class KhoSanXuatDTO
    Private _xml As String
    Private _sqlcommand As String
    Private _Command As String
    '//
    Private _codeid As String
    Private _code As String
    Private _codename As String
    '//
    Public Property CodeID() As String
        Get
            Return _codeid
        End Get
        Set(ByVal value As String)
            _codeid = value
        End Set
    End Property
    Public Property Code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property

    Public Property CodeName() As String
        Get
            Return _codename
        End Get
        Set(ByVal value As String)
            _codename = value
        End Set
    End Property
    '//
    Public Property Command() As String
        Get
            Return _Command
        End Get
        Set(ByVal value As String)
            _Command = value
        End Set
    End Property

    Public Property xml() As String
        Get
            Return _xml
        End Get
        Set(ByVal value As String)
            _xml = value
        End Set
    End Property

    Public Property sqlcommand() As String
        Get
            Return _sqlcommand
        End Get
        Set(ByVal value As String)
            _sqlcommand = value
        End Set
    End Property

    '//XML
    Public Sub New(ByVal Wsqlcommand As String, ByVal Wxml As String, ByVal WCommand As String)
        Me._sqlcommand = Wsqlcommand
        Me._xml = Wxml
        Me._Command = WCommand
    End Sub
    '//
    Public Sub New(ByVal wcodeid As String, ByVal wcommand As String)
        Me._codeid = wcodeid
        Me._Command = wcommand
    End Sub
End Class
