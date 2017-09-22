<?php 

	include("compartidas/cabeceras.php");
 ?>

 	<div class="container">
 	<div class="row">
 		<form action="" method="">
 		<!-- cuando se utiliza una funcion de ajax action y method no son necesarios -->
 		<br>
		<label for="nombre">Nombre</label>
		<br>
		<!-- required sirve para exigir datos en este campo -->
		<input class="form-control" type="text" name="nombre" id="nombre">
		<br>

		<br>
		<label for="apellido">Apellido</label>
		<br>
		<input class="form-control" type="text" id="apellido">
		<br>

		<br>
		<label for="edad">Edad</label>
		<br>
		<input class="form-control" type="number" id="edad">
		<br>

		<br>
		<button type="button" class="btn btn-primary" id="btnEnviar" >Enviar</button>
		<br>	
		
 		</form>
	</div>
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

			var nomb=$("#nombre").val();
			var apel=$("#apellido").val();
			var ed=$("#edad").val();

			if(nomb!='' && apel!='' && ed!=''){
			$.ajax({
				type:"POST",
				url:"../controladores/controladorUno.php",
				data:{nombre:nomb,apellido:apel,edad:ed},
				success:function(response){
					//$("#respuesta").append(response);
					alert(response);
				},
				error:function(){
					alert('llamado fallido');
				}
			});
		}
 		}

 	</script>

 <?php 

 	include("compartidas/pieDePagina.php");
  ?>