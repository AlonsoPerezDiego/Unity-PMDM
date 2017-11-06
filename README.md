﻿# Unity-PMDM
 
Este repositorio contiene todo el contrenido de la carpeta Assets del proyecto de Unity.


# Concepto del juego:

Se trata de un juego en realidad virtual en el que el reto es terminar un oscuro y claustrofóbico laberinto.
El personaje avanza constantemente en la dirección a la que mire y será el jugador quien, girando sobre sí 
mismo, decidirá hacia donde mira el prersonaje.


# Puntos destacables del desarrollo:

La disposición de las cámaras para el uso de Cardboard:
Para que se vean una cámara a cada lado hay que empezar creandolas dentro de un objeto que las contenga para 
posteriormente poder introducir en el el script del giroscopio y se muevan juntas. Una vez creadas la dos 
camaras, en el apartado de Viewport Rect hay que cambiar el valor de X en una de las cámaras y el Y en la 
otra siendo 0.5 el nuevo valor en vez de 1 como era antes. Así las cámaras ya estarán dispuestas para el 
Cardboard.

El uso del giroscopio del móvil:
Recibe un GameObject que será el que se vea afectado por el giro del giroscopio. En el método  Update se empieza
cogiendo la posición en la que se encuentra el dispositivo, luego se rota en función de la posicion recogida 
y la posición del GameObject. Despues rota el personaje respecto a las coordenadas del entorno y recoge la 
posición del giroscopio de Y por medio de eulerAngles en una variable. Finalmente, con esa posición se realiza 
un calibrado. En el caso de ser la primera vez que recorre el método entraría a un if en el que se realizaría 
una calibración inicial de 3 segundos.
El tutorial que seguí es este: https://www.youtube.com/watch?v=1xCeEsS6oMc

Zonas en las que se reproduce un sonido:
Hace falta crear un objeto vacío del tamaño de la zona en la que se quiere disponar el sonido. Este deben tener
activado el Is Trigger y añadido un Audio Source. Se dispone en el lugar en el que sea y se crea un script que
se añadirá al jugador. En el script se recibe el volumen como float, el sonido (AudioClip) y un AudioSource que 
será el objeto vacío. El método OnTriggerEnter se activa si se entra en contacto con el objeto, este añade el 
sonido al AudioSource con clip, le da volumen con volume y lo reproduce con Play(). En mi caso, en el AudioSource
del objeto vacio no le activé el Loop porque solo quiero que se reproduzca una vez cada vez que se pasa por ahí.
Este código es de cosecha propia.
