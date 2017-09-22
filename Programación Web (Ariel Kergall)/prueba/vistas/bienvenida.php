<?php 

	include("compartidas/cabeceras.php");
 ?>

 	<div class="container">
 	<div class="row">
 		<form action="" method="">
 		<br>
 		<br>
 		<div class="form-group">
			<label for="nombre">Nombre</label>
			<input class="form-control" type="text" name="nombre" id="nombre">
		</div>

		<div class="form-group">
			<label for="apellido">Apellido</label>
			<input class="form-control" type="text" id="apellido">
		</div>
		

		<div class="form-group">
			<label for="edad">Edad</label>
			<input class="form-control" type="number" id="edad">
		</div>

		<br>
		<button type="submit" class="btn btn-primary" id="btnEnviar" >Enviar</button>
		<br>	
		
 		</form>
 		
	</div>
	<div class="row">
 			<button type="button" class="btn btn-secondary" data-toggle="tooltip" data-placement="top" title="prueba tooltip">
  				Tooltip on top
			</button>

			<button type="button" class="btn btn-lg btn-danger" data-toggle="popover" title="Popover title" data-content="And here's some amazing content. It's very engaging. Right?">Click to toggle popover</button>
		</div>
<br>
<br>
		<div class="btn-group" role="group" aria-label="Button group with nested dropdown">
		  <button type="button" class="btn btn-secondary">1</button>
		  <button type="button" class="btn btn-secondary">2</button>
		  <div class="btn-group" role="group">
		    <button id="btnGroupDrop1" type="button" class="btn btn-secondary dropdown-toggle" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
		      Dropdown
		    </button>
		    <div class="dropdown-menu" aria-labelledby="btnGroupDrop1">
		      <a class="dropdown-item" href="#">Dropdown link</a>
		      <a class="dropdown-item" href="#">Dropdown link</a>
		    </div>
		  </div>
		</div>
 	</div>
<br>
<br>
 	<div class="alert alert-primary" role="alert">
  		This is a primary alert—check it out!
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