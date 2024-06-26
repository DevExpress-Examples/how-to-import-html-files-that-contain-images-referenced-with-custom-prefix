<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128610644/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3123)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# How to: Import HTML Files that Contain Images Referenced with a Custom Prefix

This example illustrates how to obtain an image referenced with the _'cid'_ prefix from an external file in BMP format.

The Rich Text Editor allows you to import HTML files that contain embedded images or links to external images with the **src** attribute specified as an image URL. However, you can have web files where images are referenced in a custom manner (for example, with the prefix 'cid' in the **img src** attribute, as in email files). In this case, you need to implement and register a custom [IUriStreamProvider](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Office.Services.IUriStreamProvider) to import these files into the Rich Text Editor.

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))

## More Examples

* [Rich Text Editor for WinForms - Build a Mail Application with the RichEditControl](https://github.com/DevExpress-Examples/build-a-mail-application-with-the-richeditcontrol)

## Documentation

* [Use Word Processing Document API to Load HTML Files or Export Documents to HTML](https://docs.devexpress.com/OfficeFileAPI/402993/word-processing-document-api/html-import-and-expor)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-import-html-files-that-contain-images-referenced-with-custom-prefix&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-import-html-files-that-contain-images-referenced-with-custom-prefix&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
