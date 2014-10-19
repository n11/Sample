var Books = (function () {
    function Books(title) {
        this.title = ko.observable(title);
    }
    return Books;
})();

$(document).ready(function () {
    var vm;
    vm = new Books("hogehoge");
    ko.applyBindings(vm, document.getElementById('hoge2'));
});
//# sourceMappingURL=test.js.map
