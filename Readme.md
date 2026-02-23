<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3123)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Import HTML files containing images referenced using custom prefix
By default, `RichEditControl` can import HTML files that contain embedded images or links to external images specified via the `src` attribute as an image URL. In some cases, a web file may reference images in a custom manner (for example, using the `cid` prefix in the `img src` attribute, as commonly found in email files).

In such scenarios, you should implement and register a custom **IUriStreamProvider** to ensure that these files are imported into the `RichEditControl` correctly. This example demonstrates how to retrieve an image referenced with the `"cid"` prefix from an external file in **BMP** format.

**See Also**

- [Building a mail application with the RichEditControl](https://www.devexpress.com/Support/Center/p/E2216)

<!-- feedback -->
<!-- default file list -->
## Files to look at

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->

## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-import-html-files-that-contain-images-referenced-with-custom-prefix&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-import-html-files-that-contain-images-referenced-with-custom-prefix&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
