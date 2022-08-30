var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
   
  
    .when("/employee", {
        templateUrl : "views/pages/employee.html",
        controller:"employee"
    })
    .when("/tbl_donation", {
        templateUrl : "views/pages/tbl_donation.html",
        controller:"tbl_donation"
    })
    .otherwise({
        redirectTo:"/"
    });
      //$locationProvider.html5Mode(true);
      //$locationProvider.hashPrefix('');
      //if(window.history && window.history.pushState){
      //$locationProvider.html5Mode(true);
  //}

}]);
//  app.factory("interCeptor",function($q,$location){
//      return{
//          'request':function(config){
//              config.headers.Authorization="token"; ,"$httpProvider"
//              //console.log("intercepted");
//              return config;
//          },
//          'reponse':function(rejection){
//          }
//      }
// });
// app.config(function($httpProvider){
//  	$httpProvider.interceptors.push("interCeptor");
//  });