/*$(function () {
    $("#divMesaj").dialog({
        autoOpen: false,
        show: {
            effect: "blind",
            duration: 1000
        },
        hide: {
            effect: "explode",
            duration: 1000
        }
    });

    $("#divBekleme").dialog({
        autoOpen: false,
        modal: true,
        buttons: {}
    });
});*/

function KayıtEkraniGoster() {

    $("#exampleModal").modal("show");
}

function KullaniciKaydet() {


    beklemeyeAl();
    LOGIN_AJAX.KullaniciKaydet($("#txtAd").val(), $("#txtSoyad").val(), $("#txtMail").val(), $("#txtSifre").val(), $("#txtSifreYeniden").val(), _kullaniciKaydetSonuc);

}

function _kullaniciKaydetSonuc(res) {

    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }

    window.location = res.value;
}

function Giris() {

    //beklemeyeAl();
    LOGIN_AJAX.KullaniciGiris($("#typeEmailX").val(), $("#typePasswordX").val(), _girisSonuc);
}

function _girisSonuc(res) {
    //beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        if (res.error.Message == "Kullanıcı adı ve/veya şifre yanlış!")
            mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        else
            mesajGoster("İZİNSİZ GİRİŞ", "Cezalı Kullanıcı: " + res.error.Message, "warning");
        return;
    }
    window.location = res.value;
}

function sifreyeGec(e) {


    var key = e.keyCode || e.which;
    if (key == 13) {
        $("#typePasswordX").focus();
    }

}

function logineTikla(e) {


    var keyb = e.keyCode || e.which;
    if (keyb == 13) {
        Giris();
        /*$("#girisButonu").click();*/
    }

}
