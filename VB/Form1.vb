Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms
Imports DevExpress.Office.Services

Namespace RichIUriStreamProviderExample
    Partial Public Class Form1
        Inherits DevExpress.XtraEditors.XtraForm

        Private basePath As String

        Public Sub New()
            InitializeComponent()

            basePath = Directory.GetCurrentDirectory() & "\..\..\TestDocs\"

            ' Custom IUriStreamProvider registration
            Dim uriStreamService As IUriStreamService = richEditControl1.GetService(Of IUriStreamService)()
            uriStreamService.RegisterProvider(New CustomUriStreamProvider(basePath, "bmp"))
        End Sub

        Private Sub btnImportFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnImportFile.Click
            richEditControl1.LoadDocument(basePath & "test.html")
        End Sub
    End Class

    Public Class CustomUriStreamProvider
        Implements IUriStreamProvider

        Private basePath_Renamed As String

        Private imageExtension_Renamed As String
        Public Property BasePath() As String
            Get
                Return basePath_Renamed
            End Get
            Set(ByVal value As String)
                basePath_Renamed = value
            End Set
        End Property
        Public Property ImageExtension() As String
            Get
                Return imageExtension_Renamed
            End Get
            Set(ByVal value As String)
                imageExtension_Renamed = value
            End Set
        End Property

        Public Sub New(ByVal basePath As String, ByVal imageExtenssion As String)
            Me.BasePath = basePath
            ImageExtension = imageExtenssion
        End Sub

        Public Function GetStream(ByVal url As String) As Stream Implements IUriStreamProvider.GetStream
            Dim fileName As String = String.Format("{0}.{1}", url.Replace("cid:", String.Empty), ImageExtension)
            Dim memoryStream As New MemoryStream()
            Using image As Image = System.Drawing.Image.FromFile(BasePath & fileName)
                image.Save(memoryStream, ImageFormat.Bmp)
            End Using
            memoryStream.Seek(0, SeekOrigin.Begin)
            Return memoryStream
        End Function
    End Class
End Namespace