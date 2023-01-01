<%@ Control Language="C#" AutoEventWireup="true" CodeFile="profil.ascx.cs" Inherits="KullaniciUIModuller_profil" %>


    <script src="lib/ajaxupload/ajaxupload.js"></script>
    <script src="scripts/kullanici/profil.js"></script>


    <link href="lib/bootstrap_5.1/css/bootstrap.css" rel="stylesheet" />
    <link href="lib/jquery-ui-1.13.1/jquery-ui.css" rel="stylesheet" />
    <link href="lib/jquery-ui-1.13.1/jquery-ui.structure.css" rel="stylesheet" />
    <link href="lib/jquery-ui-1.13.1/jquery-ui.theme.css" rel="stylesheet" />       
    <link href="lib/sweetAlet2_11.4.8/sweetalert2.css" rel="stylesheet" />
    
    
    <script src="lib/bootstrap_5.1/js/bootstrap.bundle.js"></script>    
    <script src="lib/jQuery_3.6.0/jquery-3.6.0.min.js"></script>
    <script src="lib/jquery-ui-1.13.1/jquery-ui.min.js"></script>
    <script src="lib/sweetAlet2_11.4.8/sweetalert2.all.min.js"></script>



  
    <div class="pagetitle">
      <h1>Profil</h1>
      <nav>
        <ol class="breadcrumb">
          <li class="breadcrumb-item"><a href="Default.aspx">Home</a></li>
          <li class="breadcrumb-item">Users</li>
          <li class="breadcrumb-item active">Profile</li>
        </ol>
      </nav>
    </div><!-- End Page Title -->

    <section class="section profile">
      <div class="row">
        <div class="col-xl-4">

          <div class="card">
            <div class="card-body profile-card pt-4 d-flex flex-column align-items-center" id="fotovead" runat="server">

              
            </div>
          </div>

        </div>

        <div class="col-xl-8">

          <div class="card">
            <div class="card-body pt-3">

                <ul class="nav nav-tabs" id="myTab" role="tablist">
  <li class="nav-item" role="presentation">
    <button class="nav-link active" id="home-tab" data-bs-toggle="tab" data-bs-target="#home" type="button" role="tab" aria-controls="home" aria-selected="true">Takip Edilenler</button>
  </li>
  <li class="nav-item" role="presentation">
    <button class="nav-link" id="profile-tab" data-bs-toggle="tab" data-bs-target="#profile" type="button" role="tab" aria-controls="profile" aria-selected="false">Takipçiler</button>
  </li>
  <li class="nav-item" role="presentation">
    <button class="nav-link" id="contact-tab" data-bs-toggle="tab" data-bs-target="#contact" type="button" role="tab" aria-controls="contact" aria-selected="false">Profil</button>
  </li>
   <li class="nav-item" role="presentation">
    <button class="nav-link" id="contact-taba" data-bs-toggle="tab" data-bs-target="#contacta" type="button" role="tab" aria-controls="contacta" aria-selected="false">Şifre Değiştir</button>
  </li>
</ul>
<div class="tab-content" id="myTabContent">
  <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
      <div id="takipEdilenler" runat="server"> </div>
  </div>
  <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">
      <div  id="takipEdenler" runat="server"> </div>
  </div>
  <div class="tab-pane fade" id="contact" role="tabpanel" aria-labelledby="contact-tab">
       <form>
                    
                    <div id="fotoVeBilgi" runat="server"> </div>

                    <div class="row mb-3">
                      <label for="about" class="col-md-4 col-lg-3 col-form-label">About</label>
                      <div class="col-md-8 col-lg-9">
                        <textarea name="about" class="form-control" id="about" style="height: 100px">Sunt est soluta temporibus accusantium neque nam maiores cumque temporibus. Tempora libero non est unde veniam est qui dolor. Ut sunt iure rerum quae quisquam autem eveniet perspiciatis odit. Fuga sequi sed ea saepe at unde.</textarea>
                      </div>
                    </div>

                    <div class="row mb-3">
                      <label for="company" class="col-md-4 col-lg-3 col-form-label">Company</label>
                      <div class="col-md-8 col-lg-9">
                        <input name="company" type="text" class="form-control" id="company" value="Lueilwitz, Wisoky and Leuschke">
                      </div>
                    </div>

                    <div class="row mb-3">
                      <label for="Job" class="col-md-4 col-lg-3 col-form-label">Job</label>
                      <div class="col-md-8 col-lg-9">
                        <input name="job" type="text" class="form-control" id="Job" value="Web Designer">
                      </div>
                    </div>

                    <div class="row mb-3">
                      <label for="Country" class="col-md-4 col-lg-3 col-form-label">Country</label>
                      <div class="col-md-8 col-lg-9">
                        <input name="country" type="text" class="form-control" id="Country" value="USA">
                      </div>
                    </div>

                    <div class="row mb-3">
                      <label for="Address" class="col-md-4 col-lg-3 col-form-label">Address</label>
                      <div class="col-md-8 col-lg-9">
                        <input name="address" type="text" class="form-control" id="Address" value="A108 Adam Street, New York, NY 535022">
                      </div>
                    </div>

                    <div class="row mb-3">
                      <label for="Phone" class="col-md-4 col-lg-3 col-form-label">Phone</label>
                      <div class="col-md-8 col-lg-9">
                        <input name="phone" type="text" class="form-control" id="Phone" value="(436) 486-3538 x29071">
                      </div>
                    </div>

                    <div class="row mb-3">
                      <label for="Twitter" class="col-md-4 col-lg-3 col-form-label">Twitter Profile</label>
                      <div class="col-md-8 col-lg-9">
                        <input name="twitter" type="text" class="form-control" id="Twitter" value="https://twitter.com/#">
                      </div>
                    </div>

                    <div class="row mb-3">
                      <label for="Facebook" class="col-md-4 col-lg-3 col-form-label">Facebook Profile</label>
                      <div class="col-md-8 col-lg-9">
                        <input name="facebook" type="text" class="form-control" id="Facebook" value="https://facebook.com/#">
                      </div>
                    </div>

                    <div class="row mb-3">
                      <label for="Instagram" class="col-md-4 col-lg-3 col-form-label">Instagram Profile</label>
                      <div class="col-md-8 col-lg-9">
                        <input name="instagram" type="text" class="form-control" id="Instagram" value="https://instagram.com/#">
                      </div>
                    </div>

                    <div class="row mb-3">
                      <label for="Linkedin" class="col-md-4 col-lg-3 col-form-label">Linkedin Profile</label>
                      <div class="col-md-8 col-lg-9">
                        <input name="linkedin" type="text" class="form-control" id="Linkedin" value="https://linkedin.com/#">
                      </div>
                    </div>

                    
                  </form>


  </div>
    <div class="tab-pane fade" id="contacta" role="tabpanel" aria-labelledby="contacta-tab">

        <form>

                    <div class="row mb-3">
                      <label for="EskiSifre" class="col-md-4 col-lg-3 col-form-label">Current Password</label>
                      <div class="col-md-8 col-lg-9">
                        <input name="password" type="password" class="form-control" id="eskiSifre">
                      </div>
                    </div>

                    <div class="row mb-3">
                      <label for="sifre" class="col-md-4 col-lg-3 col-form-label">New Password</label>
                      <div class="col-md-8 col-lg-9">
                        <input name="newpassword" type="password" class="form-control" id="sifre">
                      </div>
                    </div>

                    <div class="row mb-3">
                      <label for="sifreYeniden" class="col-md-4 col-lg-3 col-form-label">Re-enter New Password</label>
                      <div class="col-md-8 col-lg-9">
                        <input name="renewpassword" type="password" class="form-control" id="sifreYeniden">
                      </div>
                    </div>

                    <div class="text-center">
                      <button type="submit" class="btn btn-primary" onclick=sifreDegistir()>Change Password</button>
                    </div>
                  </form>



  </div>
</div>
              <!-- Bordered Tabs -->
              <!-- End Bordered Tabs -->

            </div>
          </div>
          </div>

        </div>
      
    </section>

<div id="divIcerik" runat="server"></div>  


