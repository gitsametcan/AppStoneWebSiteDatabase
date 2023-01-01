var _takipEdilenId = -1;

function takipEt(takipEdilecekKullaniciId) {

    
    beklemeyeAl();
    _takipEdilenId  = takipEdilecekKullaniciId;
    TAKIPLESME_AJAX.takipEkle(takipEdilecekKullaniciId, _paylasSonuc);
}

function _paylasSonuc(res) {

    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }
    else {
        //$("#ModalForm .btn-close").click();

        $("#takipButonu_" + _takipEdilenId).html("sdasdasdasdasd");
        $("#takipButonu_" + _takipEdilenId).hide();


        //mesajGoster("Teşekkürler", "Kişi Takip Edildi", "Kayıt Başarılı");
        //location.reload();

        //$("#takipButonu").click(function () { $(this).css("color", "green"); };

        return;

    }

}

function kullaniciAra() {


    beklemeyeAl();
    TAKIPLESME_AJAX.kullaniciBul($("#aranacakKullanici").val(), _aramasonuc);

}

function _aramasonuc(res) {

    beklemedenCik();


    $(".kisiler").html(res.value.Icerik);
    $(".pager").html(res.value.PagerIcerik);
}