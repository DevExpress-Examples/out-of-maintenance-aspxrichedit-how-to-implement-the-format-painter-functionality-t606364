Option Infer On

Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page

	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Not IsPostBack Then
			ASPxRichEdit1.Open(Server.MapPath("CharacterFormatting.rtf"))
		End If

		ASPxRichEdit1.CreateDefaultRibbonTabs(True)

		Dim copyItem = New RibbonButtonItem("Copy format")
		copyItem.LargeImage.IconID = "edit_copy_32x32office2013"
		copyItem.Size = RibbonItemSize.Large
		ASPxRichEdit1.RibbonTabs(1).Groups(1).Items.Add(copyItem)

		Dim pasteItem = New RibbonButtonItem("Paste format")
		pasteItem.LargeImage.IconID = "edit_paste_32x32office2013"
		pasteItem.Size = RibbonItemSize.Large
		ASPxRichEdit1.RibbonTabs(1).Groups(1).Items.Add(pasteItem)
	End Sub
End Class