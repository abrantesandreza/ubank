var categoria = (function() {
    var configs = {
        urls: {
            index: '',
            cadastrar: ''
        }
    }

    var init = function($configs) {
        configs = $configs;
    };

    var Cadastrar = function() {
        var model = $('#formCadastrarCategoria').serializeObject();
        $.post(configs.urls.cadastrar, model).done(() => {
            site.toast.success('Categoria cadastrada com sucesso')
        }).fail((msg) => {
            site.toast.error(msg);
        });
    };

    return {
        init: init,
        Cadastrar: Cadastrar
    }
})();
