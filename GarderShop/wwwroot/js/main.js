$('#main-category-head').click(function () {
    $('#LeftBar').toggle();
});
$('.modal-btn').click(function () {
    $('#modalWindow').toggle();

    ///Scroll block
    var modalWindow = document.getElementById('modalWindow');
    if (getComputedStyle(modalWindow).display == 'none')
    {
        const body = document.body;
        body.style.position = '';
        body.style.top = ``;
    }
    else
    {
        const body = document.body;
        body.style.position = 'fixed';
        body.style.top = `-${scrollY}`;
    }
});


/*
// Когда модальное окно скрыто...
const scrollY = document.body.style.top;
document.body.style.position = '';
document.body.style.top = '';
window.scrollTo(0, parseInt(scrollY || '0') * -1);*/

$(window).load(function () {
    // The slider being synced must be initialized first
    $('#carousel').flexslider({
        animation: "slide",
        controlNav: false,
        animationLoop: false,
        slideshow: false,
        itemWidth: 210,
        itemMargin: 5,
        asNavFor: '#slider'
    });

    $('#slider').flexslider({
        maxItems: 1,
        itemWidth: 350,
        animation: "slide",
        controlNav: false,
        animationLoop: false,
        slideshow: true,
        slideshowSpeed: 7000,
        sync: "#carousel"
    });
});
