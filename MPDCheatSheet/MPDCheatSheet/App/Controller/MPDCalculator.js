app.controller('MPDCalculator', function ($scope, $http, $filter) {

    $scope.FelonyLaws = [];
    $scope.MisdemeanorLaws = [];
    $scope.MinorLaws = [];

    $scope.TotalSentenceTime = 0;
    $scope.TotalSentenceAmmount = 0;

    $scope.FelonySentenceResult = 0;
    $scope.MisdemeanorSentenceResult = 0;
    $scope.MinorSentenceResult = 0;

    $scope.TotalPrisonSentence = 0;
    $scope.pleadedGuilty = false;

    $scope.GuiltyFactor = 0;
    $scope.AdjustedSentence = 0;


    //slider options
    $scope.slider = {
        value: 0,
        options: {
            floor: 0,
            ceil: 50,
            step: 1
        }
    };



    // felonies added by user
    $scope.FelonyAdded = [];
    // misdemeanors Added
    $scope.MisdemeanorsAdded = [];
    // minors added by users
    $scope.MinorsAdded = [];

    // watch for an added felony
    $scope.$watch('FelonyAdded',
        function() {
            var totalSentence = 0;
            // loop through each felony and add the ammount to total
            for (var i = 0; i < $scope.FelonyAdded.length; i++) {
                totalSentence += $scope.FelonyAdded[i].Ammount;
            }
            $scope.FelonySentenceResult = totalSentence;
            $scope.TotalPrisonSentence = $scope.FelonySentenceResult + $scope.MisdemeanorSentenceResult;


        },true);

    $scope.$watch('MisdemeanorsAdded',
        function () {
            var totalSentence = 0;
            // loop through each Misdemeanor andd add the ammount to total
            for (var i = 0; i < $scope.MisdemeanorsAdded.length; i++) {
                totalSentence += $scope.MisdemeanorsAdded[i].Ammount;
            }
            $scope.MisdemeanorSentenceResult = totalSentence;
            $scope.TotalPrisonSentence = $scope.FelonySentenceResult + $scope.MisdemeanorSentenceResult;
        },true);

    $scope.$watch('MinorsAdded',
        function () {
            var totalSentence = 0;
            // loop through each Misdemeanor andd add the ammount to total
            for (var i = 0; i < $scope.MinorsAdded.length; i++) {
                totalSentence += $scope.MinorsAdded[i].Ammount;
            }
            $scope.MinorSentenceResult = totalSentence;
        }, true);

    $scope.$watch('slider',
        function () {
            $scope.GuiltyFactor = $scope.slider.value / 100;
            if ($scope.TotalPrisonSentence > 0) {
                $scope.AdjustedSentence = $scope.TotalPrisonSentence * $scope.GuiltyFactor;
            }
        }, true);



    $scope.Init = function() {

        $http.get('/laws/GetFelonyCharges').then(function(data) {
                $scope.FelonyLaws = data.data;
            },
            function(error) {
                console.log(error);
            });

        $http.get('/laws/GetMisdemeanorCharges').then(function (data) {
            $scope.MisdemeanorLaws = data.data;
        },
            function (error) {
                console.log(error);
            });

        $http.get('/laws/MinorMisdemeanors').then(function (data) {
            $scope.MinorLaws = data.data;
        },
            function (error) {
                console.log(error);
            });

    }

    ///////////////////////////////////////////////////////// FELONY /////////////////////////////////////////////////////

    $scope.AddFelonyAtFull = function(felony)
    {
        var felonyAdded = {
            Ammount: felony.Sentence,
            Name : felony.Name
        }
        felony.QtyAmmount += 1;
        $scope.FelonyAdded.push(felonyAdded);
    }

    $scope.AddFelonyWithArg = function(felony)
    {
        var felonyAdded = {
            Ammount: felony.Sentence + felony.ArgSentence,
            Name: felony.Name
        }
        felony.QtyAmmount += 1;
        $scope.FelonyAdded.push(felonyAdded);
    }

    $scope.AddAttemptedFelony = function(felony) {
        var felonyAdded = {
            Ammount: (felony.Sentence * 0.5),
            Name: felony.Name
        }
        felony.QtyAmmount += 1;
        $scope.FelonyAdded.push(felonyAdded);
    }

    $scope.removeItem = function (index, name) {
        var selectedFelony = $filter('filter')($scope.FelonyLaws, { Name: name })[0];
        selectedFelony.QtyAmmount -= 1;
        $scope.FelonyAdded.splice(index, 1);
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //////////////////////////////////////////////////// MISDEMEANORS //////////////////////////////////////////////////////
    $scope.AddMisdemeanorAtFull = function (misdemeanor) {
        var MisdemeanorAdded = {
            Ammount: misdemeanor.Sentence,
            Name: misdemeanor.Name
        }
        misdemeanor.QtyAmmount += 1;
        $scope.MisdemeanorsAdded.push(MisdemeanorAdded);
    }

    $scope.AddMisdemeanorWithArg = function (misdemeanor) {
        var MisdemeanorAdded = {
            Ammount: misdemeanor.Sentence + misdemeanor.ArgSentence,
            Name: misdemeanor.Name
        }
        misdemeanor.QtyAmmount += 1;
        $scope.MisdemeanorsAdded.push(MisdemeanorAdded);
    }

    $scope.AddAttemptedMisdemeanor = function (misdemeanor) {
        var MisdemeanorAdded = {
            Ammount: (misdemeanor.Sentence * 0.5),
            Name: misdemeanor.Name
        }
        misdemeanor.QtyAmmount += 1;
        $scope.MisdemeanorsAdded.push(MisdemeanorAdded);
    }

    $scope.removeMisdemeanorItem = function (index,name) {
        var selectedMis = $filter('filter')($scope.MisdemeanorLaws, { Name: name })[0];
        selectedMis.QtyAmmount -= 1;
        $scope.MisdemeanorsAdded.splice(index, 1);
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //////////////////////////////////////////////////// MINORS //////////////////////////////////////////////////////////////
    $scope.AddMinorAtFull = function (minor) {
        var MinorAdded = {
            Ammount: minor.Sentence,
            Name: minor.Name
        }
        minor.QtyAmmount += 1;
        $scope.MinorsAdded.push(MinorAdded);
    }

    $scope.AddAttemptedMinor = function (minor) {
        var MinorAdded = {
            Ammount: (minor.Sentence * 0.5),
            Name: minor.Name
        }
        minor.QtyAmmount += 1;
        $scope.MinorsAdded.push(MinorAdded);
    }

    $scope.removeMinorItem = function (index,name) {
        var selectedMinor = $filter('filter')($scope.MinorLaws, { Name: name })[0];
        selectedMinor.QtyAmmount -= 1;
        $scope.MinorsAdded.splice(index, 1);
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    $scope.ResetLists = function() {
        $scope.FelonyAdded = [];
        $scope.MisdemeanorsAdded = [];
        $scope.MinorsAdded = [];
    }
})