<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CeshtjetOnline.aspx.cs" Inherits="web_eSupport.ceshtjetOnline" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ceshtjet Online</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>  
</head>
<body>
    <nav class="navbar navbar-expand-sm bg-dark navbar-dark">
  <!-- Brand -->
  <a class="navbar-brand" href="#"><img src="Images\e3.png" width="30px" /> SUPPORT</a>

  <!-- Links -->
  <ul class="navbar-nav">
    <!-- Dropdown -->
    <li class="nav-item dropdown">
      <a class="nav-link dropdown-toggle" href="#" id="navbardrop" data-toggle="dropdown">
        Katalogje
      </a>
      <div class="dropdown-menu">
        <a class="dropdown-item" href="index.aspx#id_sherbime">Sherbime</a>
        <a class="dropdown-item" href="index.aspx#id_sherbime">Pajisje</a>
      </div>
    </li>
    <li class="nav-item">
      <a class="nav-link" href="Logout.aspx" runat="server">Logout</a>
    </li>
  </ul>
</nav>
</br>
    <div class="jumbotron text-center" >
        <h1 id="df">Online E-Support</h1>
        <p>Ceshtjet tuaja</p>
    </div>
    <div class="container">
        <table class="table">
            <thead>
              <tr>
                <th>Sherbimi</th>
                <th>Statusi</th>
                <th>Pergjegjesi</th>
                <th>Afati</th>
                <th>Afatzgjatje</th>
                <th>Prano</th>
                <th>Refuzo</th>
              </tr>
            </thead>
            <tbody runat="server" id="id_tbody">
              <tr>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
                <td></td>
              </tr>
            </tbody>
        </table>
    </div>
   
</body>
</html>
