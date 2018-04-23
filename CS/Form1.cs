using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using DevExpress.Office.Services;

namespace RichIUriStreamProviderExample {
    public partial class Form1 : Form {
        private string basePath;
        
        public Form1() {
            InitializeComponent();

            basePath = Directory.GetCurrentDirectory() + @"\..\..\TestDocs\";

            // Custom IUriStreamProvider registration
            IUriStreamService uriStreamService = richEditControl1.GetService<IUriStreamService>();
            uriStreamService.RegisterProvider(new CustomUriStreamProvider(basePath, "bmp"));
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            richEditControl1.LoadDocument(basePath + "test.html");
        }
    }

    public class CustomUriStreamProvider : IUriStreamProvider {
        private string basePath;
        private string imageExtension;
        public string BasePath { get { return basePath; } set { basePath = value; } }
        public string ImageExtension { get { return imageExtension; } set { imageExtension = value; } }

        public CustomUriStreamProvider(string basePath, string imageExtenssion) {
            BasePath = basePath;
            ImageExtension = imageExtenssion;
        }

        public Stream GetStream(string url) {
            string fileName = string.Format("{0}.{1}", url.Replace("cid:", string.Empty), ImageExtension);
            MemoryStream memoryStream = new MemoryStream();
            Image image = Image.FromFile(BasePath + fileName);

            image.Save(memoryStream, ImageFormat.Bmp);
            memoryStream.Seek(0, SeekOrigin.Begin);

            return memoryStream;
        }
    }
}