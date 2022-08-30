app.controller("employee",function($scope,ajax){
    function success(response){
        $scope.employee = response.data;
    }
    function failure (error){

    }
    ajax.get("https://localhost:44325/api/employee",success,failure);
});
