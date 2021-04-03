function disable_button(element) {
    
    $("#formularz").submit();
    console.log(element);
    element.setAttribute("disabled", "true");
}