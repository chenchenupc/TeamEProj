/**
 * Created by Administrator on 2016/6/29.
 */
$(function () {
    function loadApp() {//主函数程序
        var flipbook = $('.flipbook');
        // Check if the CSS was already loaded
        if (flipbook.width()==0 || flipbook.height()==0) {
            setTimeout(loadApp, 10);
            return;
        }
        $('.flipbook .double').scissor();
        // Create the flipbook
        flipbook.turn({
            // Elevation
            elevation: 50,
            // Enable gradients
            gradients: true,
            // Auto center this flipbook
            autoCenter: true
        });
        //增加页面
        flipbook.bind('turning',function () {
            var pages=flipbook.turn('pages');
            var page=flipbook.turn('page');
            if(page<10&&pages<10){
                if(page>=pages-3){
                    addPage();
                    addPage();
                }
            }
        });
    }
    //主函数之外的函数
    //增加页面的方法
    var x=1;
    var totalPages=2;
    function addPage() {
        var newPage=$('<div />');
        newPage.addClass('single');
        var URL='url(../img/'+x+'.jpg)';
        x++;
        if (x >= totalPages)
        {
            x=1;
        }
        newPage.css('background-image',URL);
        $('.flipbook').turn('addPage',newPage);
    }
    
//ajax请求
/*    $("button").click(function(){
        $.get("",//请求数据的网址
            function(data){
                //处理数据
            });
    });
    */
// Load the HTML4 version if there's not CSS transform
    yepnope({
        test : Modernizr.csstransforms,
        yep: ['../lib/turn.min.js'],
        nope: ['../lib/turn.html4.min.js'],
        both: ['../lib/scissor.min.js', '../css/basic.css'],
        complete: loadApp
    });
});


