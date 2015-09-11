var app = angular.module("clinicaltrials", [])
    .controller('ProtocolCtrl', function ($scope, $http) {
        $scope.alpha = false;
        $scope.title = "loading question...";
        $scope.options = [];
        $scope.correctAnswer = false;
        $scope.working = false;

        $scope.answer = function () {
            return $scope.correctAnswer ? 'correct' : 'incorrect';
        };
    });