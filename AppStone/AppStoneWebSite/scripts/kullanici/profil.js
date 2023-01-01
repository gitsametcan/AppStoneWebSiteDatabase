function takipSil(idTakipEdilen) {


    beklemeyeAl();
    PROFIL_AJAX.takiptenCik(idTakipEdilen, _paylasSonuc);
}

function _paylasSonuc(res) {

    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }
    else {
        $("#ModalForm .btn-close").click();

        mesajGoster("Teşekkürler", "Takipten Çıkıldı", "Kayıt Başarılı");
        return;
    }

}

function kaydet(id) {


    beklemeyeAl();
    PROFIL_AJAX.Kaydet($("#imgBlogKapakFoto").attr("pathValue"), $("#txtAd").val(), $("#txtSoyad").val(), $("#txtMail").val(), _kaydetSonuc);
}

function sifreDegistir() {


    beklemeyeAl();

    PROFIL_AJAX.SifreDegistir($("#eskiSifre").val(), $("#sifre").val(), $("#sifreYeniden").val(), _kaydetSonuc);
}

function _kaydetSonuc(res) {

    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }
    else {
        $("#ModalForm .btn-close").click();

        mesajGoster("Teşekkürler", "Bilgiler Güncellendi", "Kayıt Başarılı");
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
    PROFIL_AJAX.FotoPathAyarla(src, _fotoUploadSonuc);
}