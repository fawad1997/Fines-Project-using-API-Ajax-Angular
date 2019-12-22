var app = angular.module("Homeapp", []);
app.controller("MyFirstController", function ($scope) {
    $scope.color = "pink";
    $scope.countries = ['Pakistan', 'India', 'China', 'Afghanistan'];
    $scope.calculateWidth = function () {
        width = parseInt($scope.hw) + (parseInt($scope.hw)/2);
        return width;
    };
});