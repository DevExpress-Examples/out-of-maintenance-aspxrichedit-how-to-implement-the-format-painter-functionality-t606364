using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ASPxRichEdit1.Open(Server.MapPath("CharacterFormatting.rtf"));
        }

        ASPxRichEdit1.CreateDefaultRibbonTabs(true);

        var copyItem = new RibbonButtonItem("Copy format");
        copyItem.LargeImage.IconID = "edit_copy_32x32office2013";
        copyItem.Size = RibbonItemSize.Large;
        ASPxRichEdit1.RibbonTabs[1].Groups[1].Items.Add(copyItem);

        var pasteItem = new RibbonButtonItem("Paste format");
        pasteItem.LargeImage.IconID = "edit_paste_32x32office2013";
        pasteItem.Size = RibbonItemSize.Large;
        ASPxRichEdit1.RibbonTabs[1].Groups[1].Items.Add(pasteItem);
    }
}