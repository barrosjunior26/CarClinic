// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function fecharJanela() {
    window.close();
}

setTimeout(function () {
    $(".alert").fadeOut("slow", function () {
        $(document).alert("close");
    });
},5000);