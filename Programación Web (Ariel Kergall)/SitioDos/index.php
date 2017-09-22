<!DOCTYPE html>
<html lang="en">
<head>
	<meta charset="UTF-8">
	<title>Sitio 2</title>
</head>
<body>
	<?php 
	#php es un lenguaje que soporta html en su código

		# VARIABLES 
	# las variables se crean en manera de:
	# identificativo + el valor
	# el identificativo debe ir con la anteposicion del simbolo $ (peso)
	# ejemplo:
		$variableUno = 0;		# tipo int
		$variableDos = "";		# tipo string
		$variableTres = '2'; 	# tipo char
		$variableCuatro = 2.3; 	# tipo float

		echo "Hola Mundo";

		#OPERADORES DE COMPARACIÓN
	# la definición es 
	# ( == ) "igual que"
	# ( >= ) "mayor que"
	# ( <= ) "menor que"
	# ( != ) "distinto que"
	# ( === ) "exactamente igual que" (compara valor y tipo de varialbe)
	# ( !== ) "exactamente distinto que" (idem anterior)

	# Operadores Lógicos:
	# ( || ) "or"
	# ( && ) "and"

	# Operador de Concatenación:
	# ( . ) "concatena dos string"

		#ESTRUCTURAS DE PROGRAMACIÓN
	# como en otros lenguajes las estructuras
	# de programación soportadas por php son:
	# if, while, for,foeach, switch, do while 
	# ejemplo:
		$varUno=5;
		$varDos=6;
		if($varUno>$varDos){
			echo "La variable UNO es mayor";
		}else{
			echo "<br/>La variable DOS es mayor";
		}

		# OPERADORES TERNARIOS
	# es una condición if abreviada en una sola linea
	#ejemplo:
		$background=$varUno==4?"blue":"red";
		echo "<br/>El color es " . $background;

		echo "<div style=background-color:".$background.">soy un div con color de fondo</div>";

	 ?>


	 <br>
	 <br>
	 <br>
	 <br>
	 <br>

		<!-- ACTION es el nombre del controlador donde se enviaran los datos -->
		<!-- METHOD es el metodo que se ocupará, ya sea POST o GET -->

	 <form action="controlador.php" method="POST">
	 		<label>Nombre:</label>
	 		<br>
	 		<input name="nomInput" type="text">
	 		<br>
	 		<label>Apellido:</label>
	 		<br>
	 		<input name="apeInput" type="text">
	 		<br>
	 		<!-- los botones por defecto son submit -->
	 		<button>Enviar</button>
			
	 		<!-- <input type="button" value="Enviar"> -->
	 </form>
</body>
</html>