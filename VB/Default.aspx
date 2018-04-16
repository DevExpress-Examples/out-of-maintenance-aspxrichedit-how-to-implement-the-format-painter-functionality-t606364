<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.ASPxRichEdit.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRichEdit" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v17.2, Version=17.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function onCustomCommandExecuted(s, e) {
            if (e.commandName == 'Copy format') {
                var savedIntervals = richEdit.selection.intervals;
                richEdit.selection.intervals = [new ASPx.Interval(savedIntervals[0].start, 1)];
                fontFormatting = richEdit.commands.changeFontFormatting.getState().value;
                paragraphFormatting = richEdit.commands.changeParagraphFormatting.getState().value;
                richEdit.selection.intervals = savedIntervals;
            }
            else if (e.commandName == 'Paste format') {
                richEdit.commands.changeParagraphFormatting.execute(paragraphFormatting);
                richEdit.commands.changeFontFormatting.execute(fontFormatting);
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxRichEdit ID="ASPxRichEdit1" runat="server" WorkDirectory="~\App_Data\WorkDirectory" ClientInstanceName="richEdit">
            <Settings>
                <Behavior Save="Hidden" SaveAs="Hidden" Open="Hidden" />
            </Settings>
            <ClientSideEvents CustomCommandExecuted="onCustomCommandExecuted" />
        </dx:ASPxRichEdit>
    </form>
</body>
</html>