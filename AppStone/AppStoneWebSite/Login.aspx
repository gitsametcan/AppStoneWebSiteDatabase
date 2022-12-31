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

              <p class="small mb-5 pb-lg-2"><a class="text-white-50" href="#!">Forgot password?</a></p>

              <button class="btn btn-primary" id="girisButonu" type="button" onclick="Giris();">Login</button>

              <div class="d-flex justify-content-center text-center mt-4 pt-1">
                <a href="facebook.com" class="text-white"><i class="fab fa-facebook-f fa-lg"></i></a>
                <a href="#!" class="text-white"><i class="fab fa-twitter fa-lg mx-4 px-2"></i></a>
                <a href="#!" class="text-white"><i class="fab fa-google fa-lg"></i></a>
              </div>


            </div>

            <div>
              <p class="mb-0">Don't have an account? <a href="#!" onclick="KayıtEkraniGoster();" class="text-white-50 fw-bold">Sign Up</a>
              </p>
            </div>



                <!-- Modal -->
                <div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
                    <div class="modal-dialog modal-lg">
                        <div class="modal-content gradient-custom">
                            <div class="modal-header">
                                <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                            </div>
                            <div class="modal-body">
                                <!-- Section: Design Block -->
                                <section class="">
                                    <!-- Jumbotron -->
                                    <div class="px-4 py-5 px-md-5 text-center text-lg-start" style="background-color: hsl(0, 0%, 96%)">
                                        <div class="container">
                                            <div class="row gx-lg-5 align-items-center">
                                                <div class="col-lg-6 mb-5 mb-lg-0">
                                                    <h1 class="my-5 display-3 fw-bold ls-tight">HELLOO!!
                                                        <br />
                                                        <span class="text-primary">welcome real social media</span>
                                                    </h1>
                                                    <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.svg" class="img-fluid" alt="Phone image">
                                                </div>

                                                <div class="col-lg-6 mb-5 mb-lg-0">
                                                    <div class="card">
                                                        <div class="card-body py-5 px-md-5">
                                                            <form>
                                                                <!-- 2 column grid layout with text inputs for the first and last names -->
                                                                <div class="row">
                                                                    <div class="col-md-6 mb-4">
                                                                        <div class="form-outline">
                                                                            <label class="form-label" style="color:black" for="form3Example1">Ad</label>
                                                                            <input type="text" id="txtAd" class="form-control" />                                                                            
                                                                        </div>
                                                                    </div>
                                                                    <div class="col-md-6 mb-4">
                                                                        <div class="form-outline">
                                                                            <label class="form-label" style="color:black" for="form3Example2">Soyad</label>
                                                                            <input type="text" id="txtSoyad" class="form-control" />                                                                            
                                                                        </div>
                                                                    </div>
                                                                </div>

                                                                <!-- Email input -->
                                                                <div class="form-outline mb-4">
                                                                    <label class="form-label" style="color:black" for="form3Example3">Eposta Adresi</label>
                                                                    <input type="email" id="txtMail" class="form-control" />
                                                                    
                                                                </div>

                                                                <!-- Password input -->
                                                                <div class="form-outline mb-4">
                                                                    <label class="form-label" style="color:black" for="form3Example4">Şifre</label>
                                                                    <input type="password" id="txtSifre" class="form-control" />
                                                                    
                                                                </div>

                                                                <!-- Checkbox -->
                                                                <div class="form-outline mb-4">
                                                                    <label class="form-label" style="color:black" for="form3Example5">Şifre Yeniden</label>
                                                                    <input type="password" id="txtSifreYeniden" class="form-control" />
                                                                    
                                                                </div>

                                                                <!-- Submit button -->
                                                                <button type="button" class="btn btn-primary btn-block mb-4" onclick="KullaniciKaydet();">
                                                                    KAYDOL
                                                                </button>
                                                            </form>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>                                
                                </section>
                            </div>
                        </div>
                    </div>
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
