var app = angular.module("Homeapp", []);
app.controller("MyFirstController", function ($scope) {
    $scope.students = [
        {"name":"Ali","reg":"bcs123456"},
        {"name":"Zohaib","reg":"bcs191001"},
        {"name":"Bilal","reg":"bcs183456"},
        {"name":"Mubashir","reg":"bce161456"},
        {"name":"Hamdan","reg":"bse143001"}
    ];
});
