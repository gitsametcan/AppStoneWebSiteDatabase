<%@ Control Language="C#" AutoEventWireup="true" CodeFile="anaSayfa.ascx.cs" Inherits="KullaniciUIModuller_anaSayfa" %>


<script src="scripts/kullanici/anaSayfa.js"></script>

    <div class="pagetitle">
      <h1>Ana Sayfa</h1>
      <nav>
        <ol class="breadcrumb">
          <li class="breadcrumb-item"><a href="Default.aspx">Home</a></li>
          <li class="breadcrumb-item">Users</li>
          <li class="breadcrumb-item active">Paylaşılanlar</li>
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


<div class="card">
    <div class="card-body pt-3">
        <div id="divIcerik" class="icerikler" runat="server"></div>

    </div>
</div>


<div class="card">
    <div class="card-body pt-3">
<nav aria-label="Page navigation example">
    <ul id="divPager" runat="server" class="pagination justify-content-center pager">
    
        </ul>
</nav>
    </div>
</div>


    
<%--<div class="row icerikler" id="icerikler" runat="server"> </div>--%>

<div id="myModal" class="modal">
  <span class="close" onclick="modalKapat();">&times;</span>
  <div class="modal-content" align="center" id="modalContent"></div>
  <div id="caption"></div>
</div>

<div id="myModala" class="modal">
  <span class="close" onclick="modalKapata();">&times;</span>
  <div class="modal-content" align="center" id="modalContenta"></div>
  <div id="captiona"></div>
</div>
