var categoria = (function() {
    var configs = {
        urls: {
            index: '',
            cadastrar: '',
            excluir: '',
            editar: ''
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

    var Editar = function() {
        var model = $('#formEditarCategoria').serializeObject();
        $.post(configs.urls.editar, model).done(() => {
            site.toast.success('Categoria editada com sucesso!');
            location.href = configs.urls.index;
        }).fail((msg) => {
            site.toast.error(msg);
        });
    }

    return {
        init: init,
        Cadastrar: Cadastrar,
        Excluir: Excluir,
        Editar: Editar
    }
})();
