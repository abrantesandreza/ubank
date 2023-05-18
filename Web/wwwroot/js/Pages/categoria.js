var categoria = (function() {
    var configs = {
        urls: {
            index: '',
            cadastrar: '',
            mostrarViewExcluir: '',
            excluir: ''
        }
    }

    var init = function($configs) {
        configs = $configs;
    };

    var Cadastrar = function() {
        var model = $('#formCadastrarCategoria').serializeObject();
        $.post(configs.urls.cadastrar, model).done(() => {
            site.toast.success('Categoria cadastrada com sucesso!');
            location.href = configs.urls.index;
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    var Excluir = function(id) {
        var model = {id: id};
        $.post(configs.urls.excluir, model).done(() => {
            site.toast.success('Categoria excluida com sucesso!');
            location.href = configs.urls.index;
        }).fail((msg) => {
            site.toast.error(msg);
        });
    }

    return {
        init: init,
        Cadastrar: Cadastrar,
        Excluir: Excluir
    }
})();
