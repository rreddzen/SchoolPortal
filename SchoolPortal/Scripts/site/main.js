var PAGE_TYPE;

var MY_SITE = {
    // you have one namespace-object where you hold all your stuff
    courses_page: {
        _init: function () {

            $().ready(function () {
                console.log('Course Page');

                //var url = $('#myModal').data('url');

                //$('#modalBtn').click(function () {
                //    console.log(url);
                //    $.get(url, function (data) {
                //        $('#myModal').html(data);
                //        $('#myModal').modal('show');
                //    });
                //});


                $.ajax({
                    url: "api/courses/all-courses",
                    method: "GET",
                    contentType: "application/json",
                    success: function (courses) {
                        console.log(courses);

                        var table_courses = $('#table-courses');
                        table_courses.append("<tbody>");
                        for (var course of courses) {

                            table_courses.append(`<tr>
                                <td> ${course["Id"]} </td>
                                <td> ${course["CourseName"]} </td>
                                <td> ${course["Description"]} </td> </tr>`);

                            //for (var key in course) {
                            //    table_courses.append(`<td> ${course[key]} </td>`);
                            //}
                            //table_courses.append('</tr>');
                        }
                        table_courses.append("</tbody>");
                    }

                });


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



if(PAGE_TYPE !== undefined)
    MY_SITE._start();

//$('#nav-pages a')[0].click();