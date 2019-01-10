var MY_SITE = {
    // you have one namespace-object where you hold all your stuff
    courses_page: {
        _init: function () {
            $().ready(function () {
                console.log('tets');

            });
        }
    },



    main_page: {
        // inside you have smaller chunks, for specific pages or widgets
        // this one is for main page
        _init: function () {

        },

        showSplashScreen: function () {

        }
    },

    _start: function () {
        // here we simply call one _init of the page module that was specified 
        this[PAGE_TYPE]._init();



        // and more tricky stuff - we can search the page for elements

        // that contain special data-attribute, collect them
        //var widgets = $('[data-our-widget]').each().getAttributeValue('data-or-widget');

        // and then _init each of those widgets just like we did with main page 
        //widgets.forEach(function (v) {
        //    this[v]._init();
    }
};


MY_SITE._start();