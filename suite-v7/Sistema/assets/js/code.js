function focusInput(num){
    var line= "#lineColor"+num; 
    var title= "#title"+num; 

    $(line).animate({'width':'90%', 'left':'0px','opacity':'1'},250);
    $(title).animate({'bottom':'29px'},200);
    $(title).css({'color':'#7bc2ba', 'font-size':'12px'});
}

function blurInput(num){
    var line= "#lineColor"+num; 
    var title= "#title"+num; 
    var inputText= document.getElementById('inputText'+num);

    if (inputText.value=="")
        {
            $(line).animate({'width':'0', 'left':'40%','opacity':'0'},250);
            $(title).animate({'bottom':'9px'},200);
            $(title).css({'color':'#bcbcbc', 'font-size':'14px'});
        } else {
            $(line).animate({'width':'0', 'left':'40%','opacity':'0'},250);
            $(title).css({'color':'#bcbcbc'});
        }

}

function verMeses(num) {
  var mesTabla = "#tabla-" + num;
  var mes = "#mes-" + num;

  $('.meses').removeClass('active');
  $(mes).addClass('active');
  $('.tablas').fadeOut("fast");
  $(mesTabla).fadeIn("fast");

}

$(document).ready(function(){


	  $('.subir-documento').click(function () {

       $('#overlay').fadeIn("fast");
       setTimeout("$('#popup-documento').toggle('puff', { times: 1 }, 'fast')", 100);
    
    });
    $('#close-documento').click(function () {

       $('#popup-documento').toggle('puff', { times: 1 }, 'fast');
       setTimeout("$('#overlay').fadeOut('fast')", 150);
    
    });

    $('.subir-archivo').click(function () {

       $('#overlay').fadeIn("fast");
       setTimeout("$('#popup-archivo').toggle('puff', { times: 1 }, 'fast')", 100);
    
    });
    $('#close-archivo').click(function () {

       $('#popup-archivo').toggle('puff', { times: 1 }, 'fast');
       setTimeout("$('#overlay').fadeOut('fast')", 150);
    
    });

    $('.open-progressbar').click(function () {

        var elem = document.getElementById("myBar");   
        var width = 10;
        var id = setInterval(frame, 10);
        function frame() {
          if (width >= 100) {
            clearInterval(id);
            //$('.myProgress').fadeOut('fast');
            //$('.carga-terminada').fadeIn('fast');
           // document.getElementById("title-progress").innerHTML = "Cargado";
            //$("#title-progress").css({'background-color':'#84C35C'}); 


              $('#popup-progreso').toggle('puff', { times: 1 }, 'fast');
             $('#popup-confirmacion').toggle('puff', { times: 1 }, 'fast'); 
             document.getElementById('ok-text1').innerHTML = "Archivo cargado exitosamente"; 
             setTimeout("$('#overlay').fadeOut('fast')", 2000); 
             setTimeout("$('#popup-confirmacion').toggle('puff', { times: 1 }, 'fast')", 1500); 

          } else {
            width++; 
            elem.style.width = width + '%'; 
            document.getElementById("porcent").innerHTML = width * 1  + '%';
          }
        }

       $('.popup').fadeOut('slow');
       $('.popup-inf').fadeOut('slow');
       $('.popup-inf2').fadeOut('slow');

       $('#overlay').fadeIn("fast");
       setTimeout("$('#popup-progreso').toggle('puff', { times: 1 }, 'fast')", 100);
       //setTimeout("$('#popup-progreso').toggle('puff', { times: 1 }, 'fast')", 2000);
       //setTimeout("$('#overlay').fadeOut('fast')", 2050);
    
    });

    $('.open-alerta').click(function () {

       $('#overlay').fadeIn("fast");
       $('.popup').fadeOut('slow');
       $('.popup-inf').fadeOut('slow');
       $('.popup-inf2').fadeOut('slow');

       document.getElementById('alert-aviso1').innerHTML = "RFC Invalido - No se encontró el archivo 501.";
       document.getElementById('alert-aviso2').innerHTML = "Favor de cargar un archivo valido.";
       setTimeout("$('#popup-alerta').toggle('puff', { times: 1 }, 'fast')", 100);
    
    });
    $('.close-alerta').click(function () {

       $('.popup-alerta').toggle('puff', { times: 1 }, 'fast');
       setTimeout("$('#overlay').fadeOut('fast')", 150);
    
    });

    $('.open-alerta-pendiente').click(function () {

       $('#overlay').fadeIn("fast");
       $('.popup').fadeOut('slow');
       $('.popup-inf').fadeOut('slow');
       $('.popup-inf2').fadeOut('slow');

       document.getElementById('alert-aviso1').innerHTML = "";
       document.getElementById('alert-aviso2').innerHTML = "No hay archivos.";
       setTimeout("$('#popup-alerta').toggle('puff', { times: 1 }, 'fast')", 100);
    
    });

    $('.open-eliminar').click(function () {

       $('#overlay').fadeIn("fast");
       $('.popup').fadeOut('slow');
       $('.popup-inf').fadeOut('slow');
       $('.popup-inf2').fadeOut('slow');

       setTimeout("$('#popup-eliminar').toggle('puff', { times: 1 }, 'fast')", 100);
    
    });
    $('.close-eliminar').click(function () {

       $('.popup-eliminar').toggle('puff', { times: 1 }, 'fast');
       setTimeout("$('#overlay').fadeOut('fast')", 150);
    
    });

    $('.archivo-eliminado').click(function () {

       $('.popup-eliminar').fadeOut('slow');
       $('#overlay').fadeIn("fast");
       $('.popup-inf').fadeOut('slow');
       $('.popup-inf2').fadeOut('slow');  

       $('#popup-confirmacion').toggle('puff', { times: 1 }, 'fast'); 
       document.getElementById('ok-text1').innerHTML = "Archivo eliminado exitosamente"; 
       setTimeout("$('#overlay').fadeOut('fast')", 2000); 
       setTimeout("$('#popup-confirmacion').toggle('puff', { times: 1 }, 'fast')", 1500); 
    
    });



    $('#liberar-expediente').click(function () {

       $('#overlay').fadeIn("fast");

          document.getElementById('alert-aviso1').innerHTML = "";
          document.getElementById('alert-aviso2').innerHTML = "Debes subir todos los documentos antes de liberar el expediente.";
          setTimeout("$('#popup-alerta').toggle('puff', { times: 1 }, 'fast')", 100);
    
    });


    $('#enviar-email').click(function () {

       if (screen.width > 768) {
        if( $('.cajas').prop('checked') ) {
          $('#overlay').fadeIn("fast");
          setTimeout("$('#popup-email').toggle('puff', { times: 1 }, 'fast')", 100);
       
        } else {
          $('#overlay').fadeIn("fast");

          document.getElementById('alert-aviso1').innerHTML = "";
          document.getElementById('alert-aviso2').innerHTML = "Debes seleccionar documentos para enviar.";
          setTimeout("$('#popup-alerta').toggle('puff', { times: 1 }, 'fast')", 100);
        }
      } else if (screen.width < 767) {
        if( $('.cajas').prop('checked') ) {
          $('#overlay').fadeIn("fast");
          setTimeout("$('#popup-email').fadeIn('slow')", 100);
       
        } else {
          $('#overlay').fadeIn("fast");

          document.getElementById('alert-aviso1').innerHTML = "";
          document.getElementById('alert-aviso2').innerHTML = "Debes seleccionar documentos para enviar.";
          setTimeout("$('#popup-alerta').toggle('puff', { times: 1 }, 'fast')", 100);
        }
      }
    
    });
    $('#close-email').click(function () {

    
       if (screen.width > 768) {
       $('#popup-email').toggle('puff', { times: 1 }, 'fast');
       setTimeout("$('#overlay').fadeOut('fast')", 150);
      } else if (screen.width < 767) {
        $('#overlay').fadeOut('fast'); 
        $('#popup-email').fadeOut('slow');
      }
    });

    $('.ver-documento').click(function () {

      if (screen.width > 768) {
       $('#overlay').fadeIn("fast");
       setTimeout("$('#popup-ver-documento').toggle('puff', { times: 1 }, 'fast')", 100);
        } else if (screen.width < 767) {
          $('#overlay-trans').fadeIn('fast'); 
          $('#popup-ver-documento').fadeIn('slow');
        }
    });
    $('#close-ver-documento').click(function () {

      if (screen.width > 768) {
       $('#popup-ver-documento').toggle('puff', { times: 1 }, 'fast');
       setTimeout("$('#overlay').fadeOut('fast')", 200);
          } else if (screen.width < 767) {
            $('#overlay-trans').fadeOut('fast'); 
            $('#popup-ver-documento').fadeOut('slow');
          }
    });

    $('#ver-log').click(function () {

       /*if (screen.width > 768) {
       $('#overlay').fadeIn("fast");
       setTimeout("$('#popup-log').toggle('puff', { times: 1 }, 'fast')", 100);
      } else if (screen.width < 767) {
        $('#overlay').fadeIn('fast'); 
        $('#popup-log').fadeIn('slow');
      }*/
      $('#popup-log').slideDown('slow');
    
    });
    $('#close-log').click(function () {

      /*if (screen.width > 768) {
       $('#popup-log').toggle('puff', { times: 1 }, 'fast');
       setTimeout("$('#overlay').fadeOut('fast')", 200);
        } else if (screen.width < 767) {
          $('#overlay').fadeOut('fast'); 
          $('#popup-log').fadeOut('slow');
        }*/
      $('#popup-log').slideUp('slow');
    });


    $('#ver-notas').click(function () {
      $('#popup-notas').slideDown('slow');
    
    });
    $('#close-notas').click(function () {
      $('#popup-notas').slideUp('slow');
    });


    $('.open-lateral').click(function () {

      if (screen.width > 768) {
       $('#overlay-trans').fadeIn('fast'); 
       $('#popup-referencia').animate({'right':'0', 'opacity':'1'},250);
      } else if (screen.width < 767) {
        $('#overlay-trans').fadeIn('fast'); 
        $('#popup-referencia').fadeIn('slow');
      }
    });
    $('#close-lateral').click(function () {

      if (screen.width > 768) {
         $('#overlay-trans').fadeOut('fast'); 
       $('.popup-lateral').animate({'right':'-800px', 'opacity':'0'},250);
        } else if (screen.width < 767) {
          $('#overlay-trans').fadeOut('fast'); 
          $('.popup-lateral').fadeOut('slow');
        }
    });


    $('.open-nuevorol').click(function () {

      if (screen.width > 768) {
       $('#overlay-trans').fadeIn('fast'); 
       $('#popup-nuevorol').animate({'right':'0', 'opacity':'1'},250);
      } else if (screen.width < 767) {
        $('#overlay-trans').fadeIn('fast'); 
        $('#popup-nuevorol').fadeIn('slow');
      }
    });

    $('#guardar-rol').click(function () {

       $('#popup-confirmacion').toggle('puff', { times: 1 }, 'fast'); 
       document.getElementById('ok-text1').innerHTML = "Rol guardado exitosamente"; 
       setTimeout("$('#popup-confirmacion').toggle('puff', { times: 1 }, 'fast')", 1500); 
    
    });
    $('.cancelar-rol').click(function () {

       if (screen.width > 768) {
         $('#overlay-trans').fadeOut('fast'); 
       $('.popup-lateral').animate({'right':'-800px', 'opacity':'0'},250);
        } else if (screen.width < 767) {
          $('#overlay-trans').fadeOut('fast'); 
          $('.popup-lateral').fadeOut('slow');
        }
    
    });

    $('.open-editarrol').click(function () {

      if (screen.width > 768) {
       $('#overlay-trans').fadeIn('fast'); 
       $('#popup-editarrol').animate({'right':'0', 'opacity':'1'},250);
      } else if (screen.width < 767) {
        $('#overlay-trans').fadeIn('fast'); 
        $('#popup-editarrol').fadeIn('slow');
      }
    });

    $('#grupo-op1').click(function () {
        $('#agente-opcion').fadeOut('fast');  
        $('#transportista-opcion').fadeOut('fast');      
    });
    $('#grupo-op2').click(function () {
        $('#agente-opcion').fadeIn('fast');  
        $('#transportista-opcion').fadeOut('fast');      
    });
    $('#grupo-op3').click(function () {
        $('#agente-opcion').fadeOut('fast');  
        $('#transportista-opcion').fadeIn('fast');      
    });

    $('#select-agente').click(function () {
        $('#agente').slideDown('fast');  
        $('#transportista').slideUp('fast'); 
        $('#cliente').slideUp('fast'); 
    });
    $('#select-transportista').click(function () {
        $('#transportista').slideDown('fast');  
        $('#agente').slideUp('fast'); 
        $('#cliente').slideUp('fast'); 
    });
    $('#select-cliente').click(function () {
        $('#cliente').slideDown('fast');  
        $('#agente').slideUp('fast'); 
        $('#transportista').slideUp('fast'); 
    });
    $('#select-perfilcliente').click(function () {
        $('#cliente').slideDown('fast');  
        $('#agente').slideUp('fast'); 
        $('#transportista').slideUp('fast'); 
    });
    $('#select-perfilagente').click(function () {
        $('#cliente').slideDown('fast');  
        $('#agente').slideUp('fast'); 
        $('#transportista').slideUp('fast'); 
    });



    $('.open-nuevousuario').click(function () {

      if (screen.width > 768) {
       $('#overlay-trans').fadeIn('fast'); 
       $('#popup-nuevousuario').animate({'right':'0', 'opacity':'1'},250);
      } else if (screen.width < 767) {
        $('#overlay-trans').fadeIn('fast'); 
        $('#popup-nuevousuario').fadeIn('slow');
      }
    });

    $('#guardar-usuario').click(function () {

       $('#popup-confirmacion').toggle('puff', { times: 1 }, 'fast'); 
       document.getElementById('ok-text1').innerHTML = "usuario guardado exitosamente"; 
       setTimeout("$('#popup-confirmacion').toggle('puff', { times: 1 }, 'fast')", 1500); 
    
    });
    $('.cancelar-usuario').click(function () {

       if (screen.width > 768) {
         $('#overlay-trans').fadeOut('fast'); 
       $('.popup-lateral').animate({'right':'-800px', 'opacity':'0'},250);
        } else if (screen.width < 767) {
          $('#overlay-trans').fadeOut('fast'); 
          $('.popup-lateral').fadeOut('slow');
        }
    
    });
    $('.open-editarusuario').click(function () {

      if (screen.width > 768) {
       $('#overlay-trans').fadeIn('fast'); 
       $('#popup-editarusuario').animate({'right':'0', 'opacity':'1'},250);
      } else if (screen.width < 767) {
        $('#overlay-trans').fadeIn('fast'); 
        $('#popup-editarusuario').fadeIn('slow');
      }
    });


    $('#open-patenteaduana').click(function () {

      if( $('#switch2').prop('checked') ) {
        $('#patente-aduana').slideUp('fast'); 
      } else {
       $('#patente-aduana').slideDown('fast'); 
      }
    });

    $('.overlay').click(function () {

       $('#popup-documento').fadeOut('slow');
       $('#popup-archivo').fadeOut('slow');
       $('.popup-alerta').fadeOut('slow');
       $('.popup').fadeOut('slow');
       $('.popup-inf').fadeOut('slow');
       $('.popup-inf2').fadeOut('slow');
       $('#overlay').fadeOut('fast');
    
    });

    var indicador = 1;

    $('#ocultahead').click(function () {

        if (indicador == 1) {
            $('.wrapper-head').animate({'height':'0px','padding':'0'},250);
            //$('#ocultahead').css({'transform':'rotate(180deg)'},250);
            document.getElementById('ocultahead').innerHTML = "<i class='fa fa-chevron-down'></i><div class='tooltip-down'>Mostrar header</div>";
            indicador = 2;
        } else if (indicador == 2) {
            if (screen.width > 768) {
            $('.wrapper-head').animate({'height':'110px','padding':'10px 5px 0px'},250);
            } else if (screen.width < 767) {
              $('.wrapper-head').animate({'height':'185px','padding':'10px 5px 0px'},250);
            }
            document.getElementById('ocultahead').innerHTML = "<i class='fa fa-chevron-up'></i><div class='tooltip'>Ocultar header</div>";
            indicador = 1;          
        }
    
    });

    $('#buscar').click(function () {
       $('#overlay-trans').fadeIn('fast'); 
       $('#buscar-box').toggle('puff', { times: 1 }, 'fast')   
    });
    $('#overlay-trans').click(function () {
       $('#overlay-trans').fadeOut('fast');  
       $('#buscar-box').fadeOut('fast');    
       $('.popup-lateral').animate({'right':'-800px', 'opacity':'0'},250);  
    });

    $('.btn-menu, .btn-menu-cerrar').click(function () {
       $('.navbar-menu').slideToggle('slow');    
    });

    $('#oculta-menu').click(function () {

       $('.wrapper').animate({'left':'54px'},250);
       $('.navbar').animate({'left':'54px'},250);
       $('.navbar-menu').animate({'left':'-200px'},250);
       $('.navbar-menu-replegado').fadeIn(250);
    
    });
    $('#muestra-menu').click(function () {

       $('.wrapper').animate({'left':'200px'},250);
       $('.navbar').animate({'left':'200px'},250);
       $('.navbar-menu').animate({'left':'0px'},250);
       $('.navbar-menu-replegado').fadeOut(250);
    
    });
    /*$("#safe, #sub-safe").hover(function(){
    $("#sub-safe").show();
    }, function(){
        $("#sub-safe").hide();
    });
    $("#files, #sub-files").hover(function(){
    $("#sub-files").show();
    }, function(){
        $("#sub-files").hide();
    });
    $("#vista, #sub-vista").hover(function(){
    $("#sub-vista").show();
    }, function(){
        $("#sub-vista").hide();
    });
    $("#anexo, #sub-anexo").hover(function(){
    $("#sub-anexo").show();
    }, function(){
        $("#sub-anexo").hide();
    });
    $("#seguridad, #sub-seguridad").hover(function(){
    $("#sub-seguridad").show();
    }, function(){
        $("#sub-seguridad").hide();
    });*/

    $("#checkTodos").change(function () {
      $(".cajas").prop('checked', $(this).prop("checked"));
    });

    $('#btn-newmail').click(function () {

       /*var midiv = document.createElement("input");
        midiv.setAttribute("type","email");
        midiv.setAttribute("class","form-control");
        document.getElementById("lista-correos").appendChild(midiv);*/

        if (document.getElementById('emails').value=="") {
          
        } else {
          var midiv = document.createElement("div");
          midiv.setAttribute("class","correos");
          midiv.innerHTML = document.getElementById('emails').value
          document.getElementById("lista-correos").appendChild(midiv);

          document.getElementById('emails').value = "";
        }
    
    });

    $('.quitar-doc').click(function () {

      $(this).parent().fadeOut('fast');
    
    });


    $(document).ready(function(){
    $('.menujq > ul > li:has(ul)').addClass('desplegable');
    $('.menujq > ul > li > a').click(function() {
    var comprobar = $(this).next();
    $('.menujq li').removeClass('activa');
    $(this).closest('li').addClass('activa');
    if((comprobar.is('ul')) && (comprobar.is(':visible'))) {
    $(this).closest('li').removeClass('activa');
    comprobar.slideUp('normal');
    }
    if((comprobar.is('ul')) && (!comprobar.is(':visible'))) {
    $('.menujq ul ul:visible').slideUp('normal');
    comprobar.slideDown('normal');
    }
    });
    });

    $(document).ready(function(){
    $('.menujq2 > ul > li:has(ul)').addClass('desplegable');
    $('.menujq2 > ul > li > a').click(function() {
    var comprobar = $(this).next();
    //$('.menujq2 li').removeClass('activa');
    $(this).closest('li').addClass('activa');
    if((comprobar.is('ul')) && (comprobar.is(':visible'))) {
    $(this).closest('li').removeClass('activa');
    comprobar.slideUp('normal');
    }
    if((comprobar.is('ul')) && (!comprobar.is(':visible'))) {
    //$('.menujq2 ul ul:visible').slideUp('normal');
    comprobar.slideDown('normal');
    }
    });
    });

});


