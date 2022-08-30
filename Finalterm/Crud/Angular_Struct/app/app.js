var app = angular.module("myApp", ["ngRoute"]);
app.config(["$routeProvider","$locationProvider","$httpProvider",function($routeProvider,$locationProvider) {

    $routeProvider
    .when("/", {
        templateUrl : "views/pages/demopage.html"
    })
    .when("/demo", {
        templateUrl : "views/pages/demopage.html",
        controller: 'demo'
    })
   
    .when("/login", {
        templateUrl : "views/pages/login.html",
        controller: 'login'
    })
    .when("/employee", {
        templateUrl : "views/pages/employee.html",
        controller:"employee"
    })
    .when("/tbl_donation", {
        templateUrl : "views/pages/tbl_donation.html",
        controller:"tbl_donation"
    })

    .when("/logout", {
        templateUrl : "views/pages/login.html",
        controller:"logout"
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
//              config.headers.Authorization="token";
//              console.log("intercepted");
//              return config;
//          },
//          'reponse':function(rejection){
//          }
//      }
// });
app.config(function($httpProvider){
 	$httpProvider.interceptors.push("interCeptor");
 });