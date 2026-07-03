Algoritmo Lecc17_Act3_Inc2
	
    Definir fila, columna, x, y, mayor Como Entero
    Definir tabla Como Entero
    Dimension tabla[4,4]
	
    Para fila <- 1 Hasta 4 Hacer
        Para columna <- 1 Hasta 4 Hacer
            Escribir "Ingrese un número:"
            Leer tabla[fila,columna]
        FinPara
    FinPara
	
    mayor <- tabla[1,1]
    x <- 1
    y <- 1
	
    Para fila <- 1 Hasta 4 Hacer
        Para columna <- 1 Hasta 4 Hacer
            Si tabla[fila,columna] > mayor Entonces
                mayor <- tabla[fila,columna]
                x <- fila
                y <- columna
            FinSi
        FinPara
    FinPara
	
    Escribir "El número mayor es: ", mayor
    Escribir "Está en la fila ", x
    Escribir "Y en la columna ", y
	
FinAlgoritmo