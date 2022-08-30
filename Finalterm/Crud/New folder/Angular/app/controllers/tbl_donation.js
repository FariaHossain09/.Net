app.controller("tbl_donation",function($scope,ajax){
     function success(response){
         $scope.tbl_donation = response.data;
     }
     function failure (error){

     }
     ajax.get("https://localhost:44325/api/edonation",success,failure);
 });


// app.controller('tbl_donation',function($scope,$http){
//     $http.get("https://localhost:44325/api/edonation")
//     .then(function(response){
//         //debugger;
//         $scope. tbl_donation= response.data;
//     });
// });