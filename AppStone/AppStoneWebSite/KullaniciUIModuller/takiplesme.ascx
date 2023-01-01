<%@ Control Language="C#" AutoEventWireup="true" CodeFile="takiplesme.ascx.cs" Inherits="KullaniciUIModuller_takiplesme" %>


 <script src="lib/ajaxupload/ajaxupload.js"></script>
    <script src="scripts/kullanici/takiplesme.js"></script>


<div class="pagetitle">
      <h1>Kimi Takip Etmeli</h1>
      <nav>
        <ol class="breadcrumb">
          <li class="breadcrumb-item"><a href="Default.aspx">Home</a></li>
          <li class="breadcrumb-item">Users</li>
          <li class="breadcrumb-item active">Takipleşme</li>
        </ol>
      </nav>
    </div>
<div class="search-bar">
    <div class="row">

        <div class="col" runat="server" id="divArama">                        
        </div>
        <div class="col-auto" id="aramaButonu" runat="server">
                    
        </div>


    </div>
</div>
<br/>

 <div class="row kisiler" id="kisiler" runat="server"> </div>

<div class="card">
    <div class="card-body pt-3">
<nav aria-label="Page navigation example">
    <ul id="divPager" runat="server" class="pagination justify-content-center pager">
    
        </ul>
</nav>
    </div>
</div>