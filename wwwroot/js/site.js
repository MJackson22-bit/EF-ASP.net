// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function loadNoticias(id, event){
    $('.modal').modal('show');
    event.preventDefault();
    fetch('https://localhost:5001/Noticias/Index/' + id)
    .then(response => response.text())
    .then(html => {
        document.getElementById('div_noticias').innerHTML = html;
    });
}

$(document).ready(function(){
    $(".toast").toast('show');
});