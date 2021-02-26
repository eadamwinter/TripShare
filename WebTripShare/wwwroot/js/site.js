
function changemember() {
    var name = document.getElementById("member").value;
    var members = document.getElementById("members");

    for (var i = 0; i < members.options.length; i++) {
        members.options[i].removeAttribute("disabled");

        if (members.options[i].text == name) {
            members.options[i].disabled = true;
            $("#members :disabled").prop('selected', false);
        }
    }

    $('#members').selectpicker('refresh');
}
