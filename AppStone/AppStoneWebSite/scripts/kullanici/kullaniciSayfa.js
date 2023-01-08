function update() {


    beklemeyeAl();
    KULLANICISAYFASI_AJAX.updateEmployee($("#street").val(), $("#HouseNo").val(), $("#City").val(), $("#Department").val(), _addEmployeeResult);
}

function _addEmployeeResult() {
    beklemedenCik();
}