$(document).ready(function () {
    $("#myTab li a").click(function (e) {
        e.preventDefault();
        $(this).tab('show');
    });
});

document.getElementById('myTab').innerHTML = out;