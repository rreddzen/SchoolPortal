var MY_SITE = {
    // you have one namespace-object where you hold all your stuff
    main_page: {
        // inside you have smaller chunks, for specific pages or widgets
        // this one is for main page
        _init: function () {

        },

        showSplashScreen: function () {

        }
    },


    // but there are other pages
    contacts: {},
    // or widgets
    cool_menu: {},
    // and maybe you want to put common functions into dedicated block
    global_utilities: {},
    // and of course -  loader

    _start: function () {
        // here we simply call one _init of the page module that was specified 
        this[PAGE_TYPE]._init();
        // and more tricky stuff - we can search the page for elements
        // that contain special data-attribute, collect them
        var widgets = $('[data-our-widget]').each().getAttributeValue('data-or-widget');
        // and then _init each of those widgets just like we did with main page 
        widgets.forEach(function (v) {
            this[v]._init();
        }
    }
};

document.on('ready', MY_SITE.start); // here we assume some random js framework