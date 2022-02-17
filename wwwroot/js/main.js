
  $(document).ready(function(){



  $('#contact_form2 .form-button').click(function (event) { 
    event.preventDefault();
    $.ajax({
       
        type: 'post',
        url: 'mail.php',
        data: $('#contact_form2').serialize(),
        success: function () {
          $('#contact_form2')[0].reset() ;
          $('#contact_form2 .form-button').attr('style', "background-color:#16C39A");
          $('#contact_form2 .form-button').siblings().html("<i style='color:#16C39A'>*</i> Email has been sent successfully");
        }
    });
    return false;
  });

  // preloader - start

  $(window).on('load', function () {
    $('#preloader').fadeOut('slow', function () { $(this).remove(); });
  });
  setTimeout(function()
  { $('#preloader').addClass('d-none'); }, 3000);
  
  // preloader - end

  $(document).on("scroll", function(){
    if
      ($(document).scrollTop() > 86){
      $("#banner").addClass("shrink");
    }
    else
    {
      $("#banner").removeClass("shrink");
    }
  });  


  $(function() {
        $(document).scroll(function() {
            var $nav = $("#mainNavbar");
            $nav.toggleClass("scrolled", $(this).scrollTop() > $nav.height());
        });
    });



  //smooth scroll
    $('.nav-link').on('click', function (e) {
        var anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: $(anchor.attr('href')).offset().top
        }, 1000);
        e.preventDefault();
    });

  //top header


//scroll buttton


if ($(window).scrollTop() < 100) {
    $('.scrollToTop').hide();
  }
  
  $(window).scroll(function() {
    if ($(this).scrollTop() > 100) {
      $('.scrollToTop').fadeIn('slow');
    } else {
      $('.scrollToTop').fadeOut('slow');
    }
  });
  $('.scrollToTop').click(function(){
    $('html, body').stop().animate({scrollTop:0}, 500, 'swing');
    return false;
  });
  
//header


  var headerId = $(".sticky-header");
  var headerTop = $(".sticky-header .header-top");

  $(window).on('scroll', function () {
    var amountScrolled = $(window).scrollTop();
    if ($(this).scrollTop() > 50) {
      headerId.removeClass("not-stuck");
      headerId.addClass("stuck");
      headerTop.addClass("display-none");
    } else {
      headerId.removeClass("stuck");
      headerId.addClass("not-stuck");
      headerTop.removeClass("display-none");
    }
  });



  $(".player").mb_YTPlayer();


  // youtube video js start here
  jQuery("a.bla-1").YouTubePopUp({
      autoplay: 0
  });

  //destination

  $('.offer-crousel').owlCarousel({
    loop:true,
    speed:30,
    margin:10,
    nav:true,
    autoplay:true,
    responsive:{
        0:{
            items:1
        },
        600:{
            items:1
        },
        1000:{
            items:3
        }
    }
  })

  //testimonials 


   $('.slick-center').not('.slick-initialized').slick({
    infinite: true, 
    autoplay: false,
    centerMode: true,
    centerPadding: '40%',
    responsive: [
      {
        breakpoint: 992,
        settings: {
          centerPadding: '30%',
        }
      },
      {
        breakpoint: 500,
        settings: {
          slidesToShow: 1,
          centerMode: false
        }
      },
    ]
  });


 $('.team-slider').not('.slick-initialized').slick({
    infinite: true, 
    autoplay: true,
    centerMode: true,
    slidesToShow: 3,
    centerPadding: '40%',
    responsive: [
      {
        breakpoint: 992,
        settings: {
          centerPadding: '30%',
          slidesToShow: 2,
          centerMode: false
        }
      },
      {
        breakpoint: 500,
        settings: {
          slidesToShow: 1,
          centerMode: false
        }
      },
    ]
  });



  /*Clients Review*/
    $("#client-slider").owlCarousel({
        items:1,
        itemsDesktop:[1000,2],
        itemsDesktopSmall:[990,1],
        itemsTablet:[768,1],
        pagination:false,
        navigation:true,
        navigationText:["",""],
        slideSpeed:1000,
        autoPlay:false
    });


    
});



