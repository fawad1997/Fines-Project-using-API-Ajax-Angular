var app = angular.module("Homeapp", []);
app.controller("MyFirstController", function ($scope) {
    $scope.color = "pink";
    $scope.countries = ['Pakistan', 'India', 'China', 'Afghanistan'];
    $scope.calculateWidth = function () {
        width = parseInt($scope.hw) + (parseInt($scope.hw)/2);
        return width;
    };
});

app.run(function ($rootScope) {
    $rootScope.msg = "Hello, I am root Scope, I can be accessed outside controller too";
});
app.directive("myCustomColorList", function () {
    var content = "<select ng-model='color'>";
    content += "<option>red</option>";
    content += "<option>blue</option>";
    content += "<option>yellow</option>";
    content += "<option>green</option>";
    content += "</select>";
    return {
        template: content
    };
});