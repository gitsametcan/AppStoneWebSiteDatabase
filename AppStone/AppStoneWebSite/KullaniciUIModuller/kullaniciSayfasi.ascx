<%@ Control Language="C#" AutoEventWireup="true" CodeFile="kullaniciSayfasi.ascx.cs" Inherits="KullaniciUIModuller_kullaniciSayfasi" %>


    <script src="lib/ajaxupload/ajaxupload.js"></script>
    <script src="scripts/kullanici/kullaniciSayfa.js"></script>

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
      <h1>My Informations</h1>
      <nav>
        <ol class="breadcrumb">
          <li class="breadcrumb-item"><a href="Default.aspx">Home</a></li>
          <li class="breadcrumb-item">Users</li>
          <li class="breadcrumb-item active">Personal Page</li>
        </ol>
      </nav>
    </div><!-- End Page Title -->

    <section class="section profile">
      <div class="row">
        <div class="col-xl-11">

          <div class="card">
            <div class="card-body pt-3">
              <!-- Bordered Tabs -->

<ul class="nav nav-tabs" id="myTab" role="tablist">
  <li class="nav-item" role="presentation">
    <button class="nav-link active" id="home-tab" data-bs-toggle="tab" data-bs-target="#home" type="button" role="tab" aria-controls="home" aria-selected="true">My Informations</button>
  </li>
</ul>
<div class="tab-content" id="myTabContent">
  <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
      <h5 class="card-title">About</h5>
                  <p class="small fst-italic">Sunt est soluta temporibus accusantium neque nam maiores cumque temporibus. Tempora libero non est unde veniam est qui dolor. Ut sunt iure rerum quae quisquam autem eveniet perspiciatis odit. Fuga sequi sed ea saepe at unde.</p>

                  <h5 class="card-title">Profile Details</h5>

                  <div class="row">
                    <div class="col-lg-3 col-md-4 label ">Full Name</div>
                    <div class="col-lg-9 col-md-8" id="kullaniciIsmi" runat="server"> </div>
                  </div>

                  <div class="row">
                    <div class="col-lg-3 col-md-4 label">Department</div>
                    <div class="col-lg-9 col-md-8" id="department" runat="server">Lueilwitz, Wisoky and Leuschke</div>
                  </div>

                  <div class="row">
                    <div class="col-lg-3 col-md-4 label">BirthDate</div>
                    <div class="col-lg-9 col-md-8" id="birthdate" runat="server">Web Designer</div>
                  </div>

                  <div class="row">
                    <div class="col-lg-3 col-md-4 label">Hourly Rate</div>
                    <div class="col-lg-9 col-md-8" id="hourlyrate" runat="server">USA</div>
                  </div>

                  <div class="row">
                    <div class="col-lg-3 col-md-4 label">Address</div>
                    <div class="col-lg-9 col-md-8" id="address" runat="server">A108 Adam Street, New York, NY 535022</div>
                  </div>

                  <div class="row">
                    <div class="col-lg-3 col-md-4 label">EmploymentType</div>
                    <div class="col-lg-9 col-md-8" id="emptip" runat="server">(436) 486-3538 x29071</div>
                  </div>

                    <div class="row">
                    <div class="col-lg-3 col-md-4 label">Managed By</div>
                    <div class="col-lg-9 col-md-8" id="manager" runat="server">(436) 486-3538 x29071</div>
                  </div>

                  <div class="row">
                    <div class="col-lg-3 col-md-4 label">Email</div>
                    <div class="col-lg-9 col-md-8" id="kullaniciMail" runat="server"></div>
                  </div>

                    <div class="row">
                    <div class="col-lg-9 col-md-8" id="Div1" runat="server"></div>
                  </div>

  </div>
  <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">

      <div id="icerikBu" runat="server"> </div>

  </div>




              
              </div><!-- End Bordered Tabs -->

            </div>
          </div>

        </div>
      </div>
    </section>



<!-- Modal Form -->
<div class="modal fade" id="ModalForm" tabindex="-1" aria-hidden="true">
  <div class="modal-dialog modal-dialog-centered">
    <div class="modal-content">
        <!-- Login Form -->
        <form action="">
          <div class="modal-header">
            <h5 class="modal-title">İÇERİK PAYLAŞ</h5>
            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
          </div>
          <div class="modal-body">
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label w-100" align="center">İÇERİK</label>
                <input type ="text" class="form-control" id="icerik" placeholder="Kullanıcı Adı" value="">
            </div>

            <div class="mb-3" align="center">
                <label for="exampleFormControlTextarea1" class="form-label">Görseli Buradan Yükleyebilirsiniz</label>
                <div id="divFoto" style="width: 480px; height: 360px; border: solid" align="center"></div>
                <input type = "button" id="btnFotoYukle" onclick="fotoYukle();" value="Yükle" />
            </div>
          </div>
          <div class="modal-footer pt-4">                 
            <button type="button" class="btn btn-success mx-auto w-100" onclick=paylas();>PAYLAŞ</button>
          </div>
      </form>
    </div>
  </div>
</div>

<div id="divIcerik" runat="server"></div>

<div id="myModal" class="modal">
  <span class="close" onclick="modalKapat();">&times;</span>
  <div class="modal-content" align="center" id="modalContent"></div>
  <div id="caption"></div>
</div>