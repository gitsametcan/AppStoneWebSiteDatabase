function addProject() {


    beklemeyeAl();
    ADMINSAYFASI_AJAX.addEmployee($("#fName").val(), $("#lName").val(), $("#Department").val(), $("#BirthDate").val(), $("#HourlyRate").val(),
        $("#City").val(), $("#Street").val(), $("#HouseNumber").val(), $("#Gender").val(), _addProject);
}

function _addProject() {
    beklemedenCik();
}


function addSalCon() {


    beklemeyeAl();
    ADMINSAYFASI_AJAX.addEmployee($("#fName").val(), $("#lName").val(), $("#Department").val(), $("#BirthDate").val(), $("#HourlyRate").val(),
        $("#City").val(), $("#Street").val(), $("#HouseNumber").val(), $("#Gender").val(), _addSalCon);
}

function _addSalCon() {
    beklemedenCik();
}

function addCustomer() {


    beklemeyeAl();
    ADMINSAYFASI_AJAX.addEmployee($("#fName").val(), $("#lName").val(), $("#Department").val(), $("#BirthDate").val(), $("#HourlyRate").val(),
        $("#City").val(), $("#Street").val(), $("#HouseNumber").val(), $("#Gender").val(), _addCustomer);
}

function _addCustomer() {
    beklemedenCik();
}

function addPayment() {


    beklemeyeAl();
    ADMINSAYFASI_AJAX.addEmployee($("#fName").val(), $("#lName").val(), $("#Department").val(), $("#BirthDate").val(), $("#HourlyRate").val(),
        $("#City").val(), $("#Street").val(), $("#HouseNumber").val(), $("#Gender").val(), _addPayment);
}

function _addPayment() {
    beklemedenCik();
}
