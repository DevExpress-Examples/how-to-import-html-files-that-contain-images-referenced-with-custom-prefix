# How to import HTML files containing images referenced using custom prefix


<p>By default, RichEditControl can import HTML files containing embedded images or links to external images with the src attribute specified as an image URL. Occasionally, you may have a web file where images are referenced in a custom manner (e.g. using the prefix 'cid' in the img src attribute, as in email files). In this scenario, you should implement and register a custom <strong>IUriStreamProvider</strong> to import these files into a RichEditControl correctly. This example illustrates the technique used to get an image referenced with the "cid" prefix from an external file in "bmp" format.</p><p>This approach is similar to the technique mentioned in the <a href="http://community.devexpress.com/blogs/theonewith/archive/2011/01/20/business-letters-and-mail-merge-with-rich-text-edit-part-1.aspx"><u>Business Letters and Mail Merge with Rich Text Edit (Part 1)</u></a> blog post. The reverse approach (i.e. modifying image references when exporting) implies using a custom <strong>IUriProvider</strong><strong>,</strong> as described in the <a href="http://community.devexpress.com/blogs/theonewith/archive/2011/01/20/business-letters-and-mail-merge-with-rich-text-edit-part-2.aspx"><u>Business Letters and Mail Merge with Rich Text Edit (Part 2)</u></a> blog post.</p><p><strong>See Also:</strong><br />
<a href="https://www.devexpress.com/Support/Center/p/E2216">Building a mail application with the RichEditControl</a></p>

<br/>


