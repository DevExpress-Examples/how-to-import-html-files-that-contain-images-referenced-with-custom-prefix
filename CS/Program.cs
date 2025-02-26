using DevExpress.Office.Services;
using DevExpress.Security;
using DevExpress.XtraRichEdit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace RichIUriStreamProviderExample {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static string basePath = Directory.GetCurrentDirectory() + @"\TestDocs\";
        static void Main(string[] args) {
            using (RichEditDocumentServer wordProcessor = new RichEditDocumentServer())
            {
                // Custom IUriStreamProvider registration
                IUriStreamService uriStreamService = wordProcessor.GetService<IUriStreamService>();
                uriStreamService.RegisterProvider(new CustomUriStreamProvider(basePath, "bmp"));
                wordProcessor.LoadDocument(basePath + "test.html");
                wordProcessor.SaveDocument("Result.docx", DocumentFormat.OpenXml);
            }
            //Open the result
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(@"Result.docx")
            {
                UseShellExecute = true
            };
            p.Start();
        }
    }
    public class CustomUriStreamProvider : IUriStreamProvider
    {
        private string basePath;
        private string imageExtension;
        public string BasePath { get { return basePath; } set { basePath = value; } }
        public string ImageExtension { get { return imageExtension; } set { imageExtension = value; } }

        public CustomUriStreamProvider(string basePath, string imageExtension)
        {
            BasePath = basePath;
            ImageExtension = imageExtension;
        }

        public Stream GetStream(string url)
        {
            string fileName = string.Format("{0}.{1}", url.Replace("cid:", string.Empty), ImageExtension);
            MemoryStream memoryStream = new MemoryStream();
            using (Image image = Image.FromFile(BasePath + fileName))
                image.Save(memoryStream, ImageFormat.Bmp);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return memoryStream;
        }
    }
}