<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="slider.ascx.cs" Inherits="imob_app.client.controls.slider" %>
<link rel="stylesheet" href="../controls/css/slider/flexslider.css" media="screen" />
<script src="../controls/js/slider/jquery.flexslider-min.js"></script>
<script type="text/javascript">		
    $(function(){			
        $('.flexslider').flexslider({ animation: "fade", slideshow: true, slideshowSpeed: 7000, animationDuration: 600, prevText: "Previous", nextText: "Next", controlNav: true, }) })	
</script>
<div class="flexslider">
    <ul class="slides">
        <li>
            <img src="../images/slide1.jpg" alt="">
            <!--<div class="flex-caption">
                <div class="flex-text-1">
                    Lorem Ipsum Dolor3</div>
                <br />
                <div class="flex-text-2">
                    Lorem3 ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. </div>
           </div>-->
        </li>
        <li>
            <img src="../images/slide2.jpg" alt="">
            <!--<div class="flex-caption">
                <div class="flex-text-1">
                    Lorem Ipsum Dolor3</div>
                <br />
                <div class="flex-text-2">
                    Lorem3 ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. </div>
           </div>-->
        </li>
        <li>
            <img src="../images/slide3.jpg" alt="">
            <!--<div class="flex-caption">
                <div class="flex-text-1">
                    Lorem Ipsum Dolor3</div>
                <br />
                <div class="flex-text-2">
                    Lorem3 ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. </div>
           </div>-->
        </li> 
        <li>
            <img src="../images/slide2.jpg" alt="">
            <!--
            <div class="flex-caption">
                <div class="flex-text-1">
                    Lorem Ipsum Dolor3</div>
                <br />
                <div class="flex-text-2">
                    Lorem3 ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. </div>
           </div>-->
        </li>       
    </ul>
</div>
