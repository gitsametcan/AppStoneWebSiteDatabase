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
      <h1>Add Page</h1>
      <nav>
        <ol class="breadcrumb">
          <li class="breadcrumb-item"><a href="Default.aspx">Home</a></li>
          <li class="breadcrumb-item">Add Page</li>
          <li class="breadcrumb-item active">Add Page</li>
        </ol>
      </nav>
    </div><!-- End Page Title -->

    <section class="section profile">
      <div class="row">

        <div class="col-xl-11">

          <div class="card">
            <div class="card-body pt-3">

                <ul class="nav nav-tabs" id="myTab" role="tablist">
  <li class="nav-item" role="presentation">
    <button class="nav-link active" id="home-tab" data-bs-toggle="tab" data-bs-target="#home" type="button" role="tab" aria-controls="home" aria-selected="true">Project</button>
  </li>
  <li class="nav-item" role="presentation">
    <button class="nav-link" id="profile-tab" data-bs-toggle="tab" data-bs-target="#profile" type="button" role="tab" aria-controls="profile" aria-selected="false">Customer</button>
  </li>
  <li class="nav-item" role="presentation">
    <button class="nav-link" id="contact-tab" data-bs-toggle="tab" data-bs-target="#contact" type="button" role="tab" aria-controls="contact" aria-selected="false">Sale/Contract</button>
  </li>
   <li class="nav-item" role="presentation">
    <button class="nav-link" id="contact-taba" data-bs-toggle="tab" data-bs-target="#contacta" type="button" role="tab" aria-controls="contacta" aria-selected="false">Payment</button>
  </li>
</ul>
<div class="tab-content" id="myTabContent">
  <div class="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
      <div id="takipEdilenler" runat="server"> 
          <div class="mb-3">
                  <label for="exampleFormControlInput1" class="form-label w-100" align="center">Project Id</label>
                <input type ="text" class="form-control" id="StarDate" placeholder="Please Integer" value="">
            </div>
          <div class="mb-3">
              <label for="exampleFormControlInput1" class="form-label w-100" align="center">Project Name</label>
                <input type ="text" class="form-control" id="ProjName" placeholder="Project Name" value="">
            </div>
              
              <div class="mb-3">
                  <label for="exampleFormControlInput1" class="form-label w-100" align="center">Project End Date</label>
                <input type ="text" class="form-control" id="EndDate" placeholder="YYYY-MM-DD" value="">
            </div>

          <div class="modal-footer pt-4">                 
            <button type="button" class="btn btn-success mx-auto w-100" onclick=addProject();>Add Project</button>
          </div>
             
      </div>
  </div>
  <div class="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">
      <div  id="takipEdenler" runat="server"> </div>
       <div class="mb-3">
           <label for="exampleFormControlInput1" class="form-label w-100" align="center">Company Name</label>
                <input type ="text" class="form-control" id="CmpName" placeholder="Company" value="">
            </div>
               <div class="mb-3">
                   <label for="exampleFormControlInput1" class="form-label w-100" align="center">City</label>
                <input type ="text" class="form-control" id="City" placeholder="City" value="">
            </div>
               <div class="mb-3">
                   <label for="exampleFormControlInput1" class="form-label w-100" align="center">Street</label>
                <input type ="text" class="form-control" id="Street" placeholder="Street" value="">
            </div>
              
              <div class="mb-3">
                  <label for="exampleFormControlInput1" class="form-label w-100" align="center">House Number</label>
                <input type ="text" class="form-control" id="Housenumber" placeholder="House Number" value="">
            </div>
              <div class="mb-3">
                  <label for="exampleFormControlInput1" class="form-label w-100" align="center">E-Mail</label>
                <input type ="text" class="form-control" id="Email" placeholder="Contact E- Mail" value="">
            </div>
            <div class="mb-3">
                  <label for="exampleFormControlInput1" class="form-label w-100" align="center">Tel Number</label>
                <input type ="text" class="form-control" id="TelNumber" placeholder="Tel Number" value="">
            </div>

      <div class="modal-footer pt-4">                 
            <button type="button" class="btn btn-success mx-auto w-100" onclick=addCustomer();>Add Customer</button>
          </div>

  </div>
  <div class="tab-pane fade" id="contact" role="tabpanel" aria-labelledby="contact-tab">

       <div class="mb-3">
                  <label for="exampleFormControlInput1" class="form-label w-100" align="center">Sale Id</label>
                <input type ="text" class="form-control" id="StarDateCon" placeholder="Give Integer" value="">
            </div>
      <div class="mb-3">
           <label for="exampleFormControlInput1" class="form-label w-100" align="center">Delivery Date</label>
                <input type ="text" class="form-control" id="DeliveryDate" placeholder="YYYY-MM-DD" value="">
            </div>
               <div class="mb-3">
                   <label for="exampleFormControlInput1" class="form-label w-100" align="center">Company</label>
                <input type ="text" class="form-control" id="Company" placeholder="Company" value="">
            </div>
               <div class="mb-3">
                   <label for="exampleFormControlInput1" class="form-label w-100" align="center">Project</label>
                <input type ="text" class="form-control" id="ProjId" placeholder="Project Id" value="">
            </div>
              
              <div class="mb-3">
                  <label for="exampleFormControlInput1" class="form-label w-100" align="center">Price</label>
                <input type ="text" class="form-control" id="TotalPrice" placeholder="Total Price" value="">
            </div>
            
              <div class="mb-3">
                  <label for="exampleFormControlInput1" class="form-label w-100" align="center">Conctract End Date</label>
                <input type ="text" class="form-control" id="EndDateCon" placeholder="YYYY-MM-DD" value="">
            </div>
            <div class="mb-3">
                   <label for="exampleFormControlInput1" class="form-label w-100" align="center">Customer</label>
                <input type ="text" class="form-control" id="CstId" placeholder="Customer Id" value="">
            </div>

      <div class="modal-footer pt-4">                 
            <button type="button" class="btn btn-success mx-auto w-100" onclick=addSalCon();>Add Sale/Contract</button>
          </div>

  </div>
    <div class="tab-pane fade" id="contacta" role="tabpanel" aria-labelledby="contacta-tab">

        <div class="mb-3">
                  <label for="exampleFormControlInput1" class="form-label w-100" align="center">Amount</label>
                <input type ="text" class="form-control" id="Amount" placeholder="Amount" value="">
            </div>
             <div class="mb-3">
                  <label for="exampleFormControlInput1" class="form-label w-100" align="center">Pay Date</label>
                <input type ="text" class="form-control" id="PaymentDate" placeholder="YYYY-MM-DD" value="">
            </div>
             <div class="mb-3">
                   <label for="exampleFormControlInput1" class="form-label w-100" align="center">Sale</label>
                <input type ="text" class="form-control" id="SaleId" placeholder="Sale Id" value="">
            </div>
            <div class="mb-3">
                   <label for="exampleFormControlInput1" class="form-label w-100" align="center">Contract</label>
                <input type ="text" class="form-control" id="ContractId" placeholder="Contract Id" value="">
            </div>

      <div class="modal-footer pt-4">                 
            <button type="button" class="btn btn-success mx-auto w-100" onclick=addPayment();>Add Payment</button>
          </div>


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


