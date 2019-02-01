// 2-Service
app.service("myService", function ($http) {
    this.PopulateCategories = function () {
        return $http.get("/Home/PopulateCategories");
    };

    this.CreateStoreOwner = function (storeRecord) {
        return $http({
            method: "POST",
            url: "/Home/CreateStoreOwner",
            //params: {ownerRecord, storeRecord},
            data: JSON.stringify({ storeRecord}),
            dataType: "json"
        });
    };
    this.OwnerLogin = function (username,password,rememberme) {
        return $http({
            method: "POST",
            enctype: "multipart/form-data",
            url: "/Account/Signin",
            params: { username, password, rememberme },
            dataType: "json"
        });
    };
    this.Search = function (keyword,category,city) {
        return $http({
            method: "POST",
            enctype: "multipart/form-data",
            url: "/Home/Search",
            params: { keyword, category, city },
            dataType: "json"
        });
    };

});