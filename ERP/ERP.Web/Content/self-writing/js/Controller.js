app.controller('hanghoaCtrl', function (hanghoaService, $scope) {
    $scope.loadHangHoa = function () {
        hanghoaService.get_hanghoa().then(function (d) {
            $scope.danhsachhanghoa = d;
        });
    };
    $scope.loadHangHoa();

    $scope.edit = function (item) {
        $scope.item = item;

    }

    $scope.get_tonkho = function (id) {
        hanghoaService.get_tonkho(id).then(function (a) {
            $scope.danhsachtonkho = a;
        });
    };

    $scope.getTotal = function (type) {
        var total = 0;
        angular.forEach($scope.danhsachtonkho, function (el) {
            total += el[type];
        });
        return total;
    };
});