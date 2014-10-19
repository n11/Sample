class Books {
    title: KnockoutObservable<string>;

    constructor(title: string) {
        this.title = ko.observable(title);
    }
}

$(document).ready(function () {
    var vm: Books;
    vm = new Books("hogehoge");
    ko.applyBindings(vm, document.getElementById('hoge2'));
});
