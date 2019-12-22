var app = angular.module("Homeapp", []);
app.controller("MyFirstController", function ($scope, $location,$timeout) {
    $scope.url = $location.absUrl();
    $scope.protocol = $location.protocol();
    $scope.host = $location.host();
    $scope.port = $location.port();
    $scope.myfunc = function () {
        $timeout(function () {
            $scope.msg = "This msg will be displayed after 2 seconds";
        },2000);
    };
});
