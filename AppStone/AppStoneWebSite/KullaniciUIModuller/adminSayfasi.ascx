<%@ Control Language="C#" AutoEventWireup="true" CodeFile="adminSayfasi.ascx.cs" Inherits="KullaniciUIModuller_adminSayfasi" %>

<script src="scripts/kullanici/adminSayfasi.js"></script>

<div class="col-xl-8">

          <div class="card">
            <div class="card-body pt-3">
              <!-- Bordered Tabs -->

<ul class="nav nav-tabs" id="myTab" role="tablist">
  <li class="nav-item" role="presentation">
    <button class="nav-link active" id="home-tab" data-bs-toggle="tab" data-bs-target="#home" type="button" role="tab" aria-controls="home" aria-selected="true">Kullanıcılar</button>
  </li>
  <li class="nav-item" role="presentation">
    <button class="nav-link" id="profile-tab" data-bs-toggle="tab" data-bs-target="#profile" type="button" role="tab" aria-controls="profile" aria-selected="false">İçerikler</button>
  </li>
</ul>

<div class="tab-content" id="myTabContent">
  <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
      <div id="kullanicilar" runat="server"> </div>

  </div>
  <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">

      <div id="icerikler" runat="server"> </div>

  </div>




              
              </div><!-- End Bordered Tabs -->

            </div>
          </div>

        </div>

<div id="myModal" class="modal">
  <span class="close" onclick="modalKapat();">&times;</span>
  <div class="modal-content" align="center" id="modalContent"></div>
  <div id="caption"></div>
</div>