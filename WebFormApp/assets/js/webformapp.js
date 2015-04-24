function InicializaComponentes() {
    $("#cmbAutor").unbind('change');
    $("#cmbAutor").bind('change', function () {
        CarregaLivros();
    });
}

function CarregaLivros() {
    $.ajax({
        type: 'POST',
        url: "comboajax.aspx",
        data: "acao=livros&codautor=" + $("#cmbAutor").val(),
        datatype: "json",
        success: function (data) {
            $('#cmbLivros').append(data.map(function (value, index) {
                return $('<option>').val(value.Codigo).text(value.Descricao);
            }));
        },
        error: function(XMLHttpRequest, textStatus, errorThrown) {
            alert(textStatus);
        }
    });
}