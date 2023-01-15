<%@ Control Language="C#" AutoEventWireup="true" CodeFile="adminSayfasi.ascx.cs" Inherits="KullaniciUIModuller_adminSayfasi" %>

<script src="scripts/kullanici/adminSayfasi.js"></script>

<div class="col-xl-8">

          <div class="card">
            <div class="card-body pt-3">
              <!-- Bordered Tabs -->

<ul class="nav nav-tabs" id="myTab" role="tablist">
  <li class="nav-item" role="presentation">
    <button class="nav-link active" id="home-tab" data-bs-toggle="tab" data-bs-target="#home" type="button" role="tab" aria-controls="home" aria-selected="true">All Project</button>
  </li>
  <li class="nav-item" role="presentation">
    <button class="nav-link" id="profile-tab" data-bs-toggle="tab" data-bs-target="#profile" type="button" role="tab" aria-controls="profile" aria-selected="false">All Sales</button>
  </li>
<li class="nav-item" role="presentation">
    <button class="nav-link" id="profile-tabe" data-bs-toggle="tab" data-bs-target="#employee" type="button" role="tab" aria-controls="employee" aria-selected="false">All Employees</button>
  </li>
</ul>

<div class="tab-content" id="myTabContent">
  <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
      <div id="kullanicilar" runat="server"> </div>

  </div>
  <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">

      <div id="icerikler" runat="server"> </div>

  </div>
    <div class="tab-pane fade" id="employee" role="tabpanel" aria-labelledby="profile-tabe">

      <div class="mb-3">
                <input type ="text" class="form-control" id="fName" placeholder="First Name" value="">
            </div>
              <div class="mb-3">
                <input type ="text" class="form-control" id="lName" placeholder="Last Name" value="">
            </div>
              <div class="mb-3">
                <input type ="text" class="form-control" id="Department" placeholder="Department" value="">
            </div>
              <div class="mb-3">
                <input type ="text" class="form-control" id="BirthDate" placeholder="BirthDate YYYY-MM-DD" value="">
            </div>
               <div class="mb-3">
                <input type ="text" class="form-control" id="HourlyRate" placeholder="HourlyRate in £" value="">
            </div>
               <div class="mb-3">
                <input type ="text" class="form-control" id="City" placeholder="City" value="">
            </div>
              <div class="mb-3">
                <input type ="text" class="form-control" id="Street" placeholder="Street" value="">
            </div>
              <div class="mb-3">
                <input type ="text" class="form-control" id="HouseNumber" placeholder="House Number" value="">
            </div>
              <div class="mb-3">
                <input type ="text" class="form-control" id="Gender" placeholder="Gender: m or f" value="">
            </div>

         <div class="modal-footer pt-4">                 
            <button type="button" class="btn btn-success mx-auto w-100" onclick=addEmployee();>Add Employee</button>
          </div>

  </div>




              
              </div><!-- End Bordered Tabs -->

            </div>
          </div>

        </div>

<div class="modal fade" id="ModalForm" tabindex="-1" aria-hidden="true">
  <div class="modal-dialog modal-dialog-centered">
    <div class="modal-content">
        <!-- Login Form -->
        <form action="">
          <div class="modal-header">
            <h5 class="modal-title">Add Employee</h5>
            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
          </div>
          <div class="modal-body">
            
            

          </div>
          <div class="modal-footer pt-4">                 
            <button type="button" class="btn btn-success mx-auto w-100" onclick=addEmployee();>Add Employee</button>
          </div>
      </form>
    </div>
  </div>
</div>
