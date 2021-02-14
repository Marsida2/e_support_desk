<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="web_eSupport.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>  
</head>
<body>
    <nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <!-- Brand -->
  <a class="navbar-brand" href="#"><img src="e2.png" width="30px" /> SUPPORT</a>

  <!-- Links -->
  <ul class="navbar-nav">
    <li class="nav-item">
      <a class="nav-link" href="#">Login</a>
    </li>

    <!-- Dropdown -->
    <li class="nav-item dropdown">
      <a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">
        Katalogje
      </a>
      <div class="dropdown-menu">
        <a class="dropdown-item" href="#">Sherbime</a>
        <a class="dropdown-item" href="#">Pajisje</a>
      </div>
    </li>
  </ul>
</nav>
<br>
    <div class="jumbotron text-center" >
        <h1 id="df">Online E-Support</h1>
        <p>Te ne do te gjeni sherbimin me te mire!</p>
    </div>

    <div class="container">
    <h5>Katalogu i sherbimeve</h5>
    <div class="row" id="div_sherbimet" runat="server">
    </div>
        </br>
        <hr>
        </br>
    <h5>Katalogu i produkteve</h5>
    <div class="row" id="div_pajisjet" runat="server">
    </div>
</div>
</body>
</html>
