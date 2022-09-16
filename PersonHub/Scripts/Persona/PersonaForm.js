$("#Edad").change(function () {
    var value = $("#Edad").val();
    if (value > 17) {
        while (true) {
            var beer = prompt("Cual es tu cerveza favorita?");
            if (beer.length > 30 || /\d/.test(beer)) {
                alert("La respuesta no puede tener mas de 30 caracteres ni numeros");
            } else {
                $("#beer").append("Cerveza favorita: " + beer);
                break;
            }
        }
    }
});