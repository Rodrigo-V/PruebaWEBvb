<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="PruebaWEBvb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Prueba de VB</title>
</head>
<body>
    <h5>Hola Mundo</h5>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            
        </asp:DropDownList>
        <br />
        <br />
        <br />
      <asp:TextBox runat="server" ID="TextBox1"  CausesValidation="true" ValidationGroup="okButton" Width="132px" onkeypress="javascript:return solonumeros(event)"></asp:TextBox>
        
        <asp:TextBox ID="TextBox2" onkeypress="return isNumberKey(event)" runat="server"></asp:TextBox>
    </form>

    <form id="form2">
        <div>
            
        </div>
    </form>
</body>
    <script>
        function solonumeros(e) {
 
            var key;
 
            if (window.event) // IE
            {
                key = e.keyCode;
            }
            else if (e.which) // Netscape/Firefox/Opera
            {
                key = e.which;
            }
 
            if (key < 48 || key > 57) {
                return false;
            }
 
            return true;
        }
 
    </script>
    <SCRIPT >
     <!--
     function isNumberKey(evt)
     {
        var charCode = (evt.which) ? evt.which : event.keyCode
        if (charCode > 31 && (charCode < 48 || charCode > 57))
           return true;
 
        return false;
     }
     //-->
  </SCRIPT>
</html>
