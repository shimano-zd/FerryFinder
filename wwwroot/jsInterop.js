var jsInterop = (function (module) {

    replaceUrl = function (newUrl) {
        try {
            history.replaceState(null, '', newUrl);
        } catch (ex) {
            console.log(ex);
        }
    }

    setUrl = function (newUrl) {
        try {
            history.pushState(null, '', newUrl);
        } catch (ex) {
            console.log(ex);
        }
    }

    module.setUrl = setUrl;
    module.replaceUrl = replaceUrl;

    return module;
})(jsInterop || {});
