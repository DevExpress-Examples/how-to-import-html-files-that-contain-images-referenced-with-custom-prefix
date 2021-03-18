<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->

# How to import HTML files that contain images referenced with a custom prefix

<p>The Rich Text Editor allows you to import HTML files that contain embedded images or links to external images with the <b>src</b> attribute specified as an image URL. However, you can have web files where images are referenced in a custom manner (for example, with the prefix 'cid' in the <b>img src</b> attribute, as in email files). In this case, you need to implement and register a custom <b>IUriStreamProvider</b> to import these files into the Rich Text Editor. This example illustrates how to obtain an image referenced with the 'cid' prefix from an external file in BMP format.</p>

<p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E2216">Building a mail application with the RichEditControl</a></p>
