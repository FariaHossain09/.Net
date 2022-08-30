app.controller("login",function($scope,$http){
    $scope.login = function(){
        
        $http.post("https://localhost:44325/api/login",$scope.data)
        .then(function(resp){
             console.log(resp.data);
             localStorage.setItem("token",resp.data.TokenKey);
        },function(err){
            console.log(err);
        });
    };
});
