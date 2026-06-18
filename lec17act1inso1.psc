Algoritmo lec17act1inso1
	Escribir " Javier IGnacio Vásquez García"
	Escribir "clave: 31 seccion: D IV"
	
	Definir donas como caracter
	definir filas,columnas Como Entero
	Dimension  donas[2,4]
	//filas
	donas[1,1]="fresa"
	donas[1,2]="chocolate"
	donas[1,3]="mocca"
	donas[1,4]="chicle"
	//columnas
	donas[2,1]="vainilla"
	donas[2,2]="cafe"
	donas[2,3]="coco"
	donas[2,4]="mora"
	Para filas=1 Hasta 2 Con Paso 1 Hacer
		Para columnas=1 Hasta 4 Con Paso 1 Hacer
			Escribir Sin Saltar donas[filas,columnas] "|"
		Fin Para
		escribir ()
	Fin Para
FinAlgoritmo
