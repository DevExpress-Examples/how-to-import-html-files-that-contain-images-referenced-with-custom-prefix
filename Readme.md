<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128610644/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3123)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
<!-- default file list end -->

# How to import HTML files that contain images referenced with a custom prefix

<p>The Rich Text Editor allows you to import HTML files that contain embedded images or links to external images with the <b>src</b> attribute specified as an image URL. However, you can have web files where images are referenced in a custom manner (for example, with the prefix 'cid' in the <b>img src</b> attribute, as in email files). In this case, you need to implement and register a custom <b>IUriStreamProvider</b> to import these files into the Rich Text Editor. This example illustrates how to obtain an image referenced with the 'cid' prefix from an external file in BMP format.</p>

<p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E2216">Building a mail application with the RichEditControl</a></p>
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-import-html-files-that-contain-images-referenced-with-custom-prefix&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-import-html-files-that-contain-images-referenced-with-custom-prefix&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
