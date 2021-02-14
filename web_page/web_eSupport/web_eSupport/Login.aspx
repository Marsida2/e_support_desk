<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="web_eSupport.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>E-Support HYR</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>       
    
</head>
<body>

    <div class="jumbotron text-center">
        <h1 id="df">Online E-Support</h1>
        <p>Hyni me te dhenat tuaja personale per te ndjekur ceshtjet tuaja aktive!</p>
    </div>

    <div class="container">
        <form id="form1" runat="server">
            <div>
                <table class="col-md-8 mx-auto">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_email" runat="server" Width="276px" Height="25px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="Label2" runat="server" Text="Fjalekalimi"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txt_fjalekalimi" runat="server" Width="276px" Height="25px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <asp:Button ID="btn_hyr" runat="server" Text="Hyr" OnClick="btn_hyr_Click" Width="110px" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td>
                            <asp:Label ID="lbl_error_msg" Visible="False" runat="server" Text="Te dhenat nuk jane te sakta!" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </form>
    </div>
</body>
</html>
