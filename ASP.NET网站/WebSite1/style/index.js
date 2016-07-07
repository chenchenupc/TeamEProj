/**
 * Created by Administrator on 2016/7/2.
 */
$(function () {
    var liLv1=$('.navLv1>li');
    var liLv2=$('.navLv2>li');
    var loadText=$('#load-text');
    var textImg=$('.right');
    var loadUI=$('.load');
    var closeBtn=$('#closeBtn');
    var loadBtn=$('#load-btn');

    liLv1.hover(function () {
        $(this).children('.navLv2').slideToggle();
    },function () {
        $(this).children('.navLv2').slideToggle();
    });
    liLv2.hover(function () {
        $(this).css('backgroundColor','#fff');
        $(this).children('a').css('color','#000');
    },function () {
        $(this).css('backgroundColor','#1b1b22');
        $(this).children('a').css('color','#fff');
    });
    loadText.click(function () {
        textImg.fadeOut('slow',function () {
            loadUI.fadeIn(2000);
        });
    });
    closeBtn.click(function () {
        loadUI.fadeOut('slow',function () {
            textImg.fadeIn(2000);
        });
        //使用queue方法实现连续动画
        /*loadUI.queue(function () {
            $(this).fadeOut('slow');
            textImg.fadeIn(2000);
            $(this).dequeue();//非常重要，必须退出队列
        });*/
    });
    /*loadBtn.click(function () {
        $(this).text('登录中，请耐心等待...').css('backgroundColor','#999999');
    });*/
})