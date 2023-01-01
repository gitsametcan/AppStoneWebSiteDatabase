<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="lib/bootstrap_5.1/css/bootstrap.css" rel="stylesheet" />
    <link href="lib/jquery-ui-1.13.1/jquery-ui.css" rel="stylesheet" />
    <link href="lib/jquery-ui-1.13.1/jquery-ui.structure.css" rel="stylesheet" />
    <link href="lib/jquery-ui-1.13.1/jquery-ui.theme.css" rel="stylesheet" />       
    <link href="lib/sweetAlet2_11.4.8/sweetalert2.css" rel="stylesheet" />
    
    
    <script src="lib/bootstrap_5.1/js/bootstrap.bundle.js"></script>    
    <script src="lib/jQuery_3.6.0/jquery-3.6.0.min.js"></script>
    <script src="lib/jquery-ui-1.13.1/jquery-ui.min.js"></script>
    <script src="lib/sweetAlet2_11.4.8/sweetalert2.all.min.js"></script>


    <link href="css/login.css" rel="stylesheet" />

    <script src="scripts/login.js"></script>
    <script src="scripts/genel.js"></script>
</head>
<body>
    <form id="form1" runat="server">
          <section class="vh-100 gradient-custom">
  <div class="container py-5 h-100">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-12 col-md-8 col-lg-6 col-xl-5">
        <div class="card bg-dark text-white" style="border-radius: 1rem;">
          <div class="card-body p-5 text-center">

            <div class="mb-md-5 mt-md-4 pb-5">

              <h2 class="fw-bold mb-2 text-uppercase">Login</h2>
              <p class="text-white-50 mb-5">Please enter your login and password!</p>

              <div class="form-outline form-white mb-4">
                <input type="email" id="typeEmailX" class="form-control form-control-lg" onkeypress="sifreyeGec(event);" />
                <label class="form-label" for="typeEmailX">Email</label>
              </div>

              <div class="form-outline form-white mb-4">
                <input type="password" id="typePasswordX" class="form-control form-control-lg" onkeypress="logineTikla(event);"/>
                <label class="form-label" for="typePasswordX">Password</label>
              </div>

              <button class="btn btn-primary" id="girisButonu" type="button" onclick="Giris();">Login</button>


            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
    </form>
</body>
</html>
