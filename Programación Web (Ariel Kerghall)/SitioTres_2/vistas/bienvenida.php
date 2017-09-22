<?php 

	include("compartidas/cabeceras.php");
 ?>

 	<div>
 		<form action="" method="">
 		<!-- cuando se utiliza una funcion de ajax action y method no son necesarios -->
 		<br>
		<label for="nombre">Nombre</label>
		<br>
		<!-- required sirve para exigir datos en este campo -->
		<input required="required" type="text" name="nombre" id="nombre">
		<br>

		<br>
		<label for="apellido">Apellido</label>
		<br>
		<input required="required" type="text" name="apellido">
		<br>

		<br>
		<!-- se cambia type por defecto que es submit por el type button-->
		<!-- esto provoca que no se realice un post -->
		<button type="button" id="btnEnviar">Enviar</button>
		<br>	
		<div id="respuesta"></div>
 		</form>

 	</div>

<?php 
	include("compartidas/scripts.php");
 ?>
 	<script>
 		$(function(){
 			$("#btnEnviar").click(function(){
 				EnviarFormulario(); 				
 			});
 		});

 		function EnviarFormulario(){
 			// trae el valor de la etiqueta con id nombre
			var nomb=$("#nombre").val();
			// trae el valor de la etiqueta con el name apellido
			var apel=$("input[name='apellido']").val();

			// cuando se utiliza ajax el action y el method de la etiqueta form ya no es válida
			// ajax sirve para manipular datos de manera asincrona
			// es decir, permite hilos de proceso simultaneo
			$.ajax({
				type:"POST",
				url:"../controladores/controladorUno.php",
				data:{nombre:nomb,apellido:apel},
				success:function(response){
					$("#respuesta").append(response);
				},
				error:function(){
					alert('llamado fallido');
				}
			});
 		}

 	</script>

 <?php 

 	include("compartidas/pieDePagina.php");
  ?>