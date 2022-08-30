// app.controller("logout",function(){
//     // localStorage.removeItem('token');
    
//         localStorage.removeItem("token");
// });


app.controller("logout",function($http){
    // localStorage.removeItem('token');
    $http.get("https://localhost:44325/api/logout")
    .then(function(rep){
        console.log("okey");
        localStorage.removeItem("token");
    },function(err){
        console.log(err);
    });
});
