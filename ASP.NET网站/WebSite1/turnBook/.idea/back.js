/**
 * Created by Administrator on 2016/7/4.
 */
$(function () {
    var nav=$('.nav h3');
    nav.click(function () {
        var state=$(this).next('ul').css('display');
        $(this).next('ul').toggle();
        var icon=$(this).find('i');
        if(state=='none'){
            icon.css('backgroundImage','url(\'../img/down_arrow.jpg\')');
        }
        else{
            icon.css('backgroundImage','url(\'../img/right_arrow.jpg\')');
        }
    });
    var outBtn=$('#out-text');
    outBtn.click(function () {
        window.location.href='index.html';
    });
})