<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="web_eSupport.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>E-Support HYR</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>       
    <link rel="stylesheet" href="style1.css" type="text/css">
</head>
<body>

    <div class="jumbotron text-center">
        <h1 id="df">Online E-Support</h1>
        <p>Hyni me te dhenat tuaja personale per te ndjekur ceshtjet tuaja aktive!</p>
    </div>

    <div class="container">
		<div class="d-flex justify-content-center h-100">
			<div class="user_card bg-primary">
				<div class="d-flex justify-content-center">
					<div class="brand_logo_container">
						<a href="index.aspx" > <img src="Images\e3.png" class="brand_logo" alt="Logo"></a>
		</div>
		</div>
		<div class="d-flex justify-content-center form_container">
		<form runat="server">
		<div class="input-group mb-3">
		<div class="input-group-append">
		<span class="input-group-text"><i class="fas fa-user"></i></span>
		</div>
		<input type="text" name="" class="form-control input_user" value="" placeholder="emaili" id="txt_email" runat="server">
		</div>
		<div class="input-group mb-2">
		<div class="input-group-append">
		<span class="input-group-text"><i class="fas fa-key"></i></span>
		</div>
		<input type="password" name="" class="form-control input_pass" value="" placeholder="fjalekalimi" id="txt_fjalekalimi" runat="server">
		</div>
		
		</div>
		<div class="d-flex justify-content-center mt-3 login_container">
            <asp:Button ID="btn_hyr" name="button" class="btn login_btn" runat="server" Text="Login" OnClick="btn_hyr_Click1" />
		</div>
		</form>
		<div class="d-flex justify-content-center links" runat="server" id="lbl_error_msg">
		</div>
		</div>
		</div>
    </div>
</body>
</html>
