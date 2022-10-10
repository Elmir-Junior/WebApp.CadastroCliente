var cep = $("#cep");

$('#botao').click(function () {
    $.ajax({
        type: 'GET',
        url: 'https://apps.widenet.com.br/busca-cep/api/cep.json',
        data: 'code=' + cep.val(),
        success: function (html) {
            console.log(html);
            $("#rua").val(html.address);
            $("#cidade").val(html.city);
            $("#estado").val(html.state);
            $("#bairro").val(html.district);
        }
    });
});