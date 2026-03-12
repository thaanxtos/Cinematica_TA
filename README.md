README Proyecto de Sistema de Partículas

En este proyecto el objetivo fue crear un sistema de partículas desde 0 en el cual hay una explosión de partículas al precionar la barra espaciadora del teclado

//Las clases utilizadas son:

Particle:
Script de definición de las partículas. Aquí se definen los valores usados para cada parámetro.

Particle Controller:
El controlador de las partículas. Dicta las acciones que se tomarán al presionar la tecla. Crea las partículas y actualiza sus posiciones dependiendo del tiempo.

//Parámetros usados

nP:
Número de partículas creadas una vez se active el botón

v0P:
La velocidad inicial de las partículas. Cambiará con el tiempo

angulo0P:
Ángulo inicial de las partículas. Como la velocidad inicial, cambiará con el tiempo

tLP0:
Tiempo de vida inicial de las partículas creadas. Siempre será 0

gP:
Gravedad aplicada a las partículas. Siempre será 9.8f

