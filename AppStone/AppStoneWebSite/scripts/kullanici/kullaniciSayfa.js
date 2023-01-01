function icerikSil(id) {


    beklemeyeAl();
    KULLANICISAYFASI_AJAX.icerikSil(id, _paylasSonuc);
}

function paylas() {


    beklemeyeAl();
    KULLANICISAYFASI_AJAX.Kaydet($("#icerik").val(), $("#imgBlogKapakFoto").attr("pathValue"), _paylasSonuc);
}

function takiptenCik(idTakipEdilen) {


    beklemeyeAl();
    PROFIL_AJAX.takiptenCik(idTakipEdilen, _paylasSonuc);
}

function takipEt(takipEdielcekKullaniciId) {


    beklemeyeAl();
    KULLANICISAYFASI_AJAX.takipEkle(takipEdielcekKullaniciId, _takipSonuc);
}

function _paylasSonuc(res) {

    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }
    else {
        $("#ModalForm .btn-close").click();

        mesajGoster("Teşekkürler", "Paylaşıldı", "Kayıt Başarılı");
        return;
    }

}

function _takipSonuc(res) {

    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }
    else {
        $("#ModalForm .btn-close").click();

        mesajGoster("Teşekkürler", "Kişi Takip Edildi", "Kayıt Başarılı");
        return;
    }

}

$(document).ready(
    function fotoYukle() {
        new AjaxUpload("btnFotoYukle",
            {
                action: "handlers/UploadHandler.ashx",
                name: "userfile",
                data:
                {
                    klasor: "profilFotoImages"
                },
                autoSubmit: true,
                responseType: false,
                onChange: function (file, extension) { },
                onSubmit: function (file, extension) { beklemeyeAl(); },
                onComplete: function (file, response) {
                    beklemedenCik();
                    fotoDosyaYuklemeSonuc(response);
                }
            });
    }


);

function _fotoUploadSonuc(res) {

    beklemedenCik();
    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata: " + res.error.Message, "Hata");
        return;
    }

    $("#divFoto").html(res.value);
}

function fotoDosyaYuklemeSonuc(response) {

    response = response.substr(5, response.length - 11);
    if (response.indexOf("dosyaok") == -1) {
        mesajGoster("Hata", "Görsel .png , .jpg veya .jpeg formatında olmalı");
        return;
    }

    beklemeyeAl();
    var src = response.split("~")[1];
    KULLANICISAYFASI_AJAX.FotoPathAyarla(src, _fotoUploadSonuc);
}

function modalGoster(id) {

    KULLANICISAYFASI_AJAX.modalOlustur(id, _modalGosterSonuc);


}

function _modalGosterSonuc(res) {


    $("#modalContent").html(res.value);

    $("#myModal").css("display", "block");
}



function modalKapat() {
    $("#myModal").css("display", "none");

}