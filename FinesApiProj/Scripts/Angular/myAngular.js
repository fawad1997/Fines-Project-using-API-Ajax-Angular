var app = angular.module("Homeapp", []);
app.controller("MyFirstController", function ($scope, $location) {
    $scope.url = $location.absUrl();
    $scope.protocol = $location.protocol();
    $scope.host = $location.host();
    $scope.port = $location.port();
});
