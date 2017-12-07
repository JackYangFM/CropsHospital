// JavaScript Document
    <!--answer-tiwen-width-->
    $(function(){
	         abc = $(".add-crop .crop-select").text().substr(0,12);
			 str = $(".add-crop .crop-select").text().substr(0,12) + " ...";
		 
	     if($(".add-crop .crop-select").text().length>12){
			  return $(".add-crop .crop-select").text(str);
			 }else{
			  return $(".add-crop .crop-select").text(abc);
			 }
	
	});
	<!--列表显隐切换-->
    $(".answer-tiwen-width .add-crop .crop-select").click(function(){
		$(".answer-tiwen-width .area-city .area-select-box").hide("fast");
		$(".answer-tiwen-width .add-crop .crop-select-box").slideToggle("slow");
	  });
	
	$(".answer-tiwen-width .area-city .area-select").click(function(){
		$(".answer-tiwen-width .add-crop .crop-select-box").hide("fast");
		$(".answer-tiwen-width .area-city .area-select-box").slideToggle("slow");
	  });
	<!--列表显隐切换-->
	<!--选项样式切换-->
    $(".answer-tiwen-width .crop-select-box .item,.answer-tiwen-width .area-select-box .item").click(function(){$(this).css({"background-color":"#42a437","color":"#ffffff"}).siblings(".item").css({"background-color":"#ffffff","color":"#333333"});
	});
	<!--选项样式切换-->
	<!--赋值-->
    $(".answer-tiwen-width .crop-select-box .item").click(function(){
		crop = $(this).text();
		$(".answer-tiwen-width .add-crop .crop-select").text(crop);
		$(".answer-tiwen-width .add-crop .crop-select-box").slideUp();
	});
       
	$(".answer-tiwen-width .area-select-box .item").click(function(){
		crop = $(this).text();
		cropparent = $(this).parents(".city-box").children("h3").text();
		cropall = crop + '-' + cropparent;
		$(".answer-tiwen-width .area-city .area-select").text(cropall);
		$(".answer-tiwen-width .area-city .area-select-box").slideUp();
	});
    <!--赋值-->
	$(".answer-tiwen-width .area-city .area-select-box h3").click(function(){
		$(this).parent().children(".answer-tiwen-width .area-select-box .city-second-list").slideToggle()
		});
    <!--answer-tiwen-width-->
	
	<!--answer-list-width-->
	   $(function(){
	         abc = $(".answer-list-width .basis-crop .basis-crop-c").text().substr(0,8);
			 str = $(".answer-list-width .basis-crop .basis-crop-c").text().substr(0,8) + " ...";
		 
	     if($(".answer-list-width .basis-crop .basis-crop-c").text().length>8){
			  return $(".answer-list-width .basis-crop .basis-crop-c").text(str);
			 }else{
			  return $(".answer-list-width .basis-crop .basis-crop-c").text(abc);
			 }
	
	});

    <!--列表显隐切换-->
    $(".answer-list-width .answer-condition .basis-crop").click(function(){$(".answer-list-width .answer-condition .crop-select-box").slideToggle();
	$(".answer-list-width .answer-condition .area-select-box").slideUp();
    });
	
	$(".answer-list-width .answer-condition .basis-area").click(function(){$(".answer-list-width .answer-condition .area-select-box").slideToggle();
	$(".answer-list-width .answer-condition .crop-select-box").slideUp();
    });
    
	$(".answer-list-width .area-select-box h3").click(function(){$(this).parent().children(".answer-list-width .area-select-box .city-second-list").slideToggle()
    });
	<!--列表显隐切换-->
	<!--选项样式切换-->
    $(".answer-list-width .crop-select-box .item,.answer-list-width .answer-condition .area-select-box .item").click(function(){$(this).css({"background-color":"#42a437","color":"#ffffff"}).siblings(".item").css({"background-color":"#ffffff","color":"#333333"});
	});
	<!--选项样式切换-->  
    <!--赋值-->
    $(".answer-list-width .crop-select-box .item").click(function(){
		crop = $(this).text();
		$(".answer-list-width .answer-condition .basis-crop-c").text(crop);
		$(".answer-list-width .answer-condition .crop-select-box").slideUp();
	});
   
    $(".answer-list-width .area-select-box .item").click(function(){
		crop = $(this).text();
		$(".answer-list-width .answer-condition .basis-area-c").text(crop);
		$(".answer-list-width .answer-condition .area-select-box").slideUp();
	});
    <!--赋值-->