function update() {


    beklemeyeAl();
    KULLANICISAYFASI_AJAX.updateEmployee($("#Department").val(),  $("#HouseNo").val(), $("#City").val(), $("#street").val(), _addEmployeeResult);
}

function _addEmployeeResult() {
    beklemedenCik();
}