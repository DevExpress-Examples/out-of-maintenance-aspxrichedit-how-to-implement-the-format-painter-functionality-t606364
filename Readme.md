<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128545378/17.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T606364)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# ASPxRichEdit - How to implement the Format Painter functionality
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t606364/)**
<!-- run online end -->


<p>Currently, ASPxRichEdit doesn't provide the Format Painter feature out of the box. This example illustrates a possible solution to implement this functionality in a custom way by using custom ribbon buttons and the ASPxRichEdit's client-side API.<br><br>For this purpose, handle the editor's client-side <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.Scripts.ASPxClientRichEdit.CustomCommandExecuted.event">CustomCommandExecuted</a> event to check if a custom ribbon item is clicked, and get the font and paragraph formatting applied to the currently selected content via the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.Scripts.RichEditCommands.changeFontFormatting.property">changeFontFormatting.getState()</a>, <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.Scripts.RichEditCommands.changeParagraphFormatting.property">changeParagraphFormatting.getState()</a> commands. <br>To achieve the behavior similar to that the MS Word Format Painter's provides, the ASPxRichEdit selection is changed programmatically to select only the selected text's first symbol before calling corresponding commands in order to get its formatting as the formatting of the selected interval. After retrieving formatting information for this symbol, the control's selection is restored to its original state.<br>After that, the saved formatting can be applied to the new selected content on a ribbon item click via the <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.Scripts.RichEditCommands.changeFontFormatting.property">changeFontFormatting</a> and <a href="https://documentation.devexpress.com/AspNet/DevExpress.Web.ASPxRichEdit.Scripts.RichEditCommands.changeParagraphFormatting.property">changeParagraphFormatting</a> commands.</p>

<br/>


