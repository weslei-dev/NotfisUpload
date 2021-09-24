
jQuery(function ($) {
    $("input[name='Cep']").change(function () {
        var cep_code = $(this).val();
        if (cep_code.length <= 0) return;
        $.get("http://apps.widenet.com.br/busca-cep/api/cep.json", { code: cep_code }, function (result) {
            if (result.status != 1) {
                alert(result.message || "Houve um erro desconhecido");
                return;
            }
            $("input[name='Cep']").val(result.code);
            $("input[name='Estado']").val(result.state);
            $("input[name='Cidade']").val(result.city);
            $("“input[name = 'Bairro']").val(result.district);
            $("input [name='Endereco']").val(result.address);
        });
    });
});
