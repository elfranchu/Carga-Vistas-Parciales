$(document).ready(function () {
    function LoadPartial(obj) {
        //Cargar la url de la parcial
        var url = $(obj).attr('href')
        console.debug(url);
        $("#contenidocentral").load(url);
    }

    $(".contactlink").click(function (e) {
        LoadPartial(this);
        e.preventDefault();
    });

    if (window.location.href.endsWith("AllInOne/Index") == false)
        $("#indexdiv").hide();
    if (window.location.href.endsWith("AllInOne/Info") == false)
        $("#infodiv").hide();
    if (window.location.href.endsWith("AllInOne/Contact") == false)
        $("#contactdiv").hide();

    function ShowPartial(obj) {
        var url = $(obj).attr('href')
        // Ocultamos todas las capas
        $("#indexdiv").hide();
        $("#infodiv").hide();
        $("#contactdiv").hide();

        if (url.indexOf('/Index') > 0) {
            $("#indexdiv").show();
            history.pushState(null, "Inicio", "Index");
        }
        if (url.indexOf('/Contact') > 0) {
            $("#contactdiv").show();
            history.pushState(null, "Contacto", "Contact");
        }
        if (url.indexOf('/Info') > 0) {
            $("#infodiv").show();
            history.pushState(null, "Info", "Info");
        }
    }

    $(".contactlinkjquery").click(function (e) {
        ShowPartial(this);
        e.preventDefault();
    });
});