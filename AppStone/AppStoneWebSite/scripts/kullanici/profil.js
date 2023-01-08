function addProject() {


    beklemeyeAl();
    PROFIL_AJAX.addProject($("#ProjName").val(), $("#StarDate").val(), $("#EndDate").val(), _addProject);
}

function _addProject() {
    beklemedenCik();
}


function addSalCon() {


    beklemeyeAl();
    PROFIL_AJAX.addSalCon($("#DeliveryDate").val(), $("#Company").val(), $("#ProjId").val(), $("#TotalPrice").val(), $("#StarDateCon").val(),
        $("#EndDateCon").val(), $("#CstId").val(), _addSalCon);
}

function _addSalCon() {
    beklemedenCik();
}

function addCustomer() {


    beklemeyeAl();
    PROFIL_AJAX.addCustomer($("#CmpName").val(), $("#City").val(), $("#Street").val(), $("#Housenumber").val(), $("#Email").val(), $("#TelNumber").val(), _addCustomer);
}

function _addCustomer() {
    beklemedenCik();
}

function addPayment() {


    beklemeyeAl();
    PROFIL_AJAX.addPayment($("#Amount").val(), $("#PaymentDate").val(), $("#SaleId").val(), $("#ContractId").val(),_addPayment);
}

function _addPayment() {
    beklemedenCik();
}
