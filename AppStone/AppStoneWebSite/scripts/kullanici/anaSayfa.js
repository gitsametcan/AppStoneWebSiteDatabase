var _icerikId = -1;

function begen(icerikId) {

    beklemeyeAl();
    _icerikId = icerikId
    ANASAYFA_AJAX.icerikBegen(_icerikId, _begenSonuc)
}

function _begenSonuc(res) {

    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }
    else {
        
        /*$("#begenButonu_" + _icerikId).removeClass("begeni");
        $("#begenButonu_" + _icerikId).addClass("begenildi");
        $("#begenmeButonu_" + _icerikId).removeClass("begenilmedi");
        $("#begenmeButonu_" + _icerikId).addClass("begenme");
        $("#begenenler_" + _icerikId).css('display', 'block');
        $("#begenmeyenler_"+_icerikId).css('display', 'block');*/
        location.reload();
        return;

    }
}

function begenme(icerikId) {

    beklemeyeAl();
    _icerikId = icerikId
    ANASAYFA_AJAX.icerikBegenme(_icerikId, _begenmeSonuc)
}

function _begenmeSonuc(res) {

    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }
    else {

        /*$("#begenButonu_" + _icerikId).removeClass("begenildi");
        $("#begenButonu_" + _icerikId).addClass("begeni");
        $("#begenmeButonu_" + _icerikId).removeClass("begenme");
        $("#begenmeButonu_" + _icerikId).addClass("begenilmedi");*/
        location.reload();
        return;

    }
}


function modalGoster(id) {

    ANASAYFA_AJAX.modalOlustur(id, _modalGosterSonuc);


}

function _modalGosterSonuc(res) {


        $("#modalContent").html(res.value);

    $("#myModal").css("display", "block");
}

function modalGostera(icerikId) {

    ANASAYFA_AJAX.BegenmeleriOlustur(icerikId, _modalGosterSonuca);


}

function modalGosterb(icerikId) {

    ANASAYFA_AJAX.BegenenleriOlustur(icerikId, _modalGosterSonuca);


}

function _modalGosterSonuca(res) {


    $("#modalContenta").html(res.value);

    $("#myModala").css("display", "block");
}


function modalKapat() {
    $("#myModal").css("display", "none");

}

function modalKapata() {
    $("#myModala").css("display", "none");

}

function icerikAra() {


    beklemeyeAl();
    ANASAYFA_AJAX.icerikBul($("#aranacakIcerik").val(), _aramasonuc);

}

function _aramasonuc(res) {

    beklemedenCik();

    $(".icerikler").html(res.value.Icerik);
    $(".pager").html(res.value.PagerIcerik);

}

function aramayaTikla(e) {

    var keyc = e.keyCode || e.which;
    if (keyc == 13) {
        icerikAra();
        /*$("#aramaButonu").click();*/
    }
}