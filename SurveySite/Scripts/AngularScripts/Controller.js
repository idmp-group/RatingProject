// 3- Controller
app.controller("myController", function ($scope, myService) {
    //Generate Store Code
    function GenerateNumbers() {
        return Math.floor((Math.random() * 1000) + 10);
    }
    //Generate Categories list for signup store form
    function PopulateCategories() {
        var result = myService.PopulateCategories();

        result.then(
            function (categories) {
                $scope.categories = [];
                angular.forEach(categories.data, function (item) {
                    $scope.categories.push({ value:item.Code,label:item.Name });
                });
                // you don't need another scope variable
                //$scope.categories = categories.data;
            }
            , function () {
                alert("Error Getting Data");
            });
    }
    PopulateCategories();
    //Search store
    $scope.Search = function () {
        keyword = $scope.keyword;
        category = $scope.selectedCat;
        city = $scope.city;
        var result = myService.Search(keyword, category, city);
        result.then(function (store) {
            if (store.data!="false") {
                
                $scope.storeImages = store.data.Images;
                $scope.storeName = store.data.Name;
                $scope.storeDescription = store.data.Description;
                $scope.storeAddress = store.data.Address;
                $scope.storeEmail = store.data.Email;
            }
            else {
                alert("Sorry, something was wrong :(");
            }
        }, function () {
            alert("Sorry, something was wrong :(");
        });
        // }
       

    };

    //Signup Store and Owner
    $scope.CreateStoreOwner = function () {
        var ownerRecord = {};
        alert($scope.FirstName);
        ownerRecord.FirstName = $scope.FirstName;
        ownerRecord.LastName = $scope.LastName;
        ownerRecord.Username = $scope.Username;
        ownerRecord.Password = $scope.Password;
        ownerRecord.Email = $scope.Email;
        ownerRecord.Phonenumber = $scope.Phonenumber;
        var storeRecord = {};
        storeRecord.StoreCode = GenerateNumbers();
        storeRecord.Name = $scope.Name;
        storeRecord.Description = $scope.Description;
        storeRecord.Address = $scope.Address;
        storeRecord.Email = $scope.StoreEmail;
        storeRecord.Date ="10/02/98";
        storeRecord.Phonenumber = $scope.StorePhoneNumber;
        storeRecord.Latitude = 10;
        storeRecord.Longitude = 10;
        storeRecord.CategoryCode = $scope.selectedCat.value;
        storeRecord.Owner = ownerRecord;
        var result = myService.CreateStoreOwner(storeRecord);
        result.then(function () {
            alert("true");
        }, function () {
            alert("false");
        })
    };
    //Owner Login
    $scope.OwnerLogin = function () {
        username = $scope.loginUsername;
        password = $scope.loginPassword;
        rememberme = $scope.rememberme;
        var result = myService.OwnerLogin(username, password, rememberme);
        result.then(function (owner) {
            alert("Succussfully");
            $scope.loginUsername = "";
            $scope.loginPassword = "";
            $("#LoginModal").modal("hide");
            $scope.FirstName = owner.FirstName;
            $scope.LastName = owner.LastName;
            $scope.Username = owner.Username;
            $scope.wUsername = owner.Username;
            $scope.Password = owner.Password;
            $scope.Email = owner.Email;
            $scope.Phonenumber = owner.Phonenumber;
        }, function () {
            alert("Sorry, something was wrong :(");
        });
        // }
        $scope.DisplayOne = function (record) {
            ownerRecord.FirstName = $scope.FirstName;
            ownerRecord.LastName = $scope.LastName;
            ownerRecord.Username = $scope.Username;
            ownerRecord.Password = $scope.Password;
            ownerRecord.Email = $scope.Email;
            ownerRecord.Phonenumber = $scope.Phonenumber;
            var storeRecord = {};
        };

    };

});