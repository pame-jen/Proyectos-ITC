<?php 
	# Para poder enviar datos hacia o desde un controlador 
	# se utilizan dos metodos, llamados POST y GET
	# usamos post cuando queremos mandar datos hacia el servidor
	# usamos get cuando vamos a buscar datos al servidor
	$nombre = $_POST["nomInput"];
	$apellido = $_POST["apeInput"];

	echo "Nombre: ".$nombre. " Apellido: ".$apellido;
 ?>