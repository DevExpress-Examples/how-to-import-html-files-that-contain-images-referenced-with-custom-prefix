Imports DevExpress.Office.Services
Imports DevExpress.Security
Imports DevExpress.XtraRichEdit
Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms

Namespace RichIUriStreamProviderExample
    Module Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        Private basePath As String = Directory.GetCurrentDirectory() & "\TestDocs\"

        Sub Main(args As String())
            Using wordProcessor As New RichEditDocumentServer()
                ' Custom IUriStreamProvider registration
                Dim uriStreamService As IUriStreamService = wordProcessor.GetService(Of IUriStreamService)()
                uriStreamService.RegisterProvider(New CustomUriStreamProvider(basePath, "bmp"))
                wordProcessor.LoadDocument(basePath & "test.html")
                wordProcessor.SaveDocument("Result.docx", DocumentFormat.OpenXml)
            End Using

            ' Open the result
            Dim p As New Process()
            p.StartInfo = New ProcessStartInfo("Result.docx") With {
                .UseShellExecute = True
            }
            p.Start()
        End Sub
    End Module

    Public Class CustomUriStreamProvider
        Implements IUriStreamProvider

        Private _basePath As String
        Private _imageExtension As String

        Public Property BasePath As String
            Get
                Return _basePath
            End Get
            Set(value As String)
                _basePath = value
            End Set
        End Property

        Public Property ImageExtension As String
            Get
                Return _imageExtension
            End Get
            Set(value As String)
                _imageExtension = value
            End Set
        End Property

        Public Sub New(basePath As String, imageExtension As String)
            Me.BasePath = basePath
            Me.ImageExtension = imageExtension
        End Sub

        Public Function GetStream(url As String) As Stream Implements IUriStreamProvider.GetStream
            Dim fileName As String = String.Format("{0}.{1}", url.Replace("cid:", String.Empty), ImageExtension)
            Dim memoryStream As New MemoryStream()
            Using image As Image = Image.FromFile(BasePath & fileName)
                image.Save(memoryStream, ImageFormat.Bmp)
            End Using
            memoryStream.Seek(0, SeekOrigin.Begin)
            Return memoryStream
        End Function
    End Class
End Namespace
