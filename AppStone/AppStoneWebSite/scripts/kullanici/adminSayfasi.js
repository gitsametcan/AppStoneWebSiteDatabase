﻿function addEmployee() {


    beklemeyeAl();
    ADMINSAYFASI_AJAX.addEmployee($("#fName").val(), $("#lName").val(), $("#Department").val(), $("#BirthDate").val(), $("#HourlyRate").val(),
        $("#City").val(), $("#Street").val(), $("#HouseNumber").val(), $("#Gender").val(), _addEmployeeResult);
}

function _addEmployeeResult() {
    beklemedenCik();
}

function updateEmployee(empId) {


    beklemeyeAl();
    ADMINSAYFASI_AJAX.updateEmployee(empId, $("#Department").val(), $("#HourlyRate").val(),
        $("#City").val(), $("#Street").val(), $("#HouseNo".val(), _updateEmployeeResult);
}

function _updateEmployeeResult() {
    beklemedenCik();
}

function blokla(kullaniciId) {

    beklemeyeAl();
    _kullaniciId = kullaniciId;
    ADMINSAYFASI_AJAX.KullaniciBlokla(kullaniciId,$("#blokTarihi").val(), _bloklaSonuc);
}

function _bloklaSonuc(res) {
    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }
    else {
        $("#blokButonu_" + _kullaniciId).html(res.value);
        return;
    }
}

function blokKaldir(kullaniciId) {

    beklemeyeAl();
    _kullaniciId = kullaniciId;
    ADMINSAYFASI_AJAX.KullaniciBlokKaldir(kullaniciId, _blokKaldirSonuc);
}

function _blokKaldirSonuc(res) {
    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }
    else {
        $("#blokKaldirButonu_" + _kullaniciId).html(res.value);
        return;
    }
}

function icerikblokla(kullaniciId) {

    beklemeyeAl();
    _kullaniciId = kullaniciId;
    ADMINSAYFASI_AJAX.IcerikBlokla(kullaniciId, _icerikbloklaSonuc);
}

function _icerikbloklaSonuc(res) {
    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }
    else {
        $("#icerikblokButonu_" + _kullaniciId).html(res.value);
        return;
    }
}

function icerikblokKaldir(kullaniciId) {

    beklemeyeAl();
    _kullaniciId = kullaniciId;
    ADMINSAYFASI_AJAX.IcerikBlokla(kullaniciId, _icerikblokKaldirSonuc);
}

function _icerikblokKaldirSonuc(res) {
    beklemedenCik();

    if (res.error != null && res.error.Status != 200) {
        mesajGoster("Hata", "Hata olustu: " + res.error.Message, "error");
        return;
    }
    else {
        $("#icerikblokKaldirButonu_" + _kullaniciId).html(res.value);
        return;
    }
}

function modalGoster(id) {

    ADMINSAYFASI_AJAX.modalOlustur(id, _modalGosterSonuc);


}

function _modalGosterSonuc(res) {


    $("#modalContent").html(res.value);

    $("#myModal").css("display", "block");
}

function modalKapat() {
    $("#myModal").css("display", "none");

}