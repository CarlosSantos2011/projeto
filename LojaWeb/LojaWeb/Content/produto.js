$(".botaoExcluirProduto").click(function () {
    event.preventDefault();
    var linha = $(this).parent().parent();
    var linha2 = $(this).data("test");

    $.ajax({
        url: "/Produto/Excluir/",
        dataType: 'json',
        data: { 'ProdutoId': linha2 },
    }).done(function (msg) {
        $(msg).each(function (i) {
            if (msg.erro == true) {
                CriarMsgErro(msg.Mensagem);
            }
            else {
                $("#ProdutoId_" + linha2).remove();
                CriarMsgErro(msg.Mensagem);
            }

        });
    }).fail(function (jqXHR, textStatus, msg) {
        alert("Erro de requisição");
    });