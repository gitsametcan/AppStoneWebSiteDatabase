function mesajGoster(baslik, icerik, icon) {
    Swal.fire({
        icon: icon,
        title: baslik,
        text: icerik
    })

}

function beklemeyeAl() {
    $("#divBekleme").dialog("open");
}

function beklemedenCik() {
    $("#divBekleme").dialog("close");
}