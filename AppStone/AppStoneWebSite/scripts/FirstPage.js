function signup() {
    beklemeyeAl();
    FIRSTPAGE_AJAX.signup(

        $("#imgBlogKapakFoto").attr("pathValue"),

        $("#txtHead").val(), $("#txtSummary").val(), $("#txtArticle").val(), _signupSonuc);
}

function _signupSonuc(res) {

    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }
    else
    {
        mesajGoster("Teşekkürler", "Yazınız Kaydedildi", "Kayıt Başarılı");
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
                    klasor: "articleImages"
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


$(document).ready(function () {
    $('.summernote').summernote();
});



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
    FIRSTPAGE_AJAX.FotoPathAyarla(src, _fotoUploadSonuc);
}