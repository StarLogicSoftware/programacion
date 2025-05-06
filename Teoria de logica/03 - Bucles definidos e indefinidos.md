## Tipos de Bucles: Definiendo o Esperando una Condición

En programación, los bucles se pueden clasificar principalmente en dos categorías, dependiendo de cómo se controla el número de repeticiones:

### 1. Bucles Definidos (o Bucle "Para" / "For")

Los **bucles definidos** son aquellos en los que **sabemos de antemano cuántas veces queremos que se repita el bloque de código**. Es como decir: "Quiero hacer esto exactamente 5 veces" o "Quiero hacer esto para cada elemento de esta lista".

**Analogía Cotidiana:**

Imagina que tienes una caja con 7 galletas y quieres comerte cada una de ellas. Sabes que vas a repetir la acción de "tomar una galleta y comerla" exactamente 7 veces, una por cada galleta en la caja.

**Estructura Conceptual:**

Aunque la forma exacta puede variar en diferentes lenguajes de programación, la idea general de un bucle definido implica:

1.  **Un punto de inicio:** Desde dónde vamos a empezar a contar o a iterar (recorrer los elementos).
2.  **Un punto final:** Hasta dónde vamos a contar o hasta que hayamos recorrido todos los elementos.
3.  **Un contador (implícito o explícito):** Una forma de llevar la cuenta de cuántas veces hemos repetido el bucle o qué elemento estamos procesando actualmente.

**Ejemplos de Uso:**

* Imprimir los números del 1 al 10. Sabemos que queremos realizar la acción de "imprimir un número" 10 veces.
* Procesar cada correo electrónico en una lista de direcciones. Sabemos exactamente cuántos correos hay en la lista y queremos realizar alguna acción con cada uno.
* Dibujar un cuadrado dibujando una línea, girando, y repitiendo esto 4 veces. Sabemos que un cuadrado tiene 4 lados.

La clave del bucle definido es que el número de repeticiones está determinado antes de que el bucle comience a ejecutarse.

### 2. Bucles Indefinidos (o Bucle "Mientras" / "While" y "Hacer Mientras" / "Do While")

Los **bucles indefinidos** son aquellos en los que **no sabemos de antemano cuántas veces se repetirá el bloque de código**. La repetición continúa **mientras se cumpla una determinada condición**. El bucle se detendrá cuando esa condición deje de ser verdadera.

**Analogía Cotidiana:**

Imagina que estás buscando las llaves de tu casa. Vas a seguir buscando (revisando bolsillos, mesas, etc.) **mientras no encuentres las llaves**. No sabes exactamente cuántos lugares tendrás que revisar antes de encontrarlas. La condición para detener la búsqueda es "encontrar las llaves".

**Estructura Conceptual del Bucle "Mientras" (While):**

1.  **Una condición:** Una pregunta que se evalúa al **principio** de cada posible repetición.
2.  **Un bloque de código:** Las instrucciones que se ejecutarán **si la condición es verdadera**.
3.  **Es crucial que algo dentro del bucle eventualmente haga que la condición se vuelva falsa**, de lo contrario, el bucle se ejecutará infinitamente (lo cual generalmente no es lo que queremos).

**Estructura Conceptual del Bucle "Hacer Mientras" (Do While):**

1.  **Un bloque de código:** Las instrucciones que se ejecutarán **al menos una vez**.
2.  **Una condición:** Una pregunta que se evalúa **al final** de cada repetición. El bucle continúa si la condición es verdadera.

La principal diferencia entre "mientras" y "hacer mientras" es que el bloque de código dentro de "hacer mientras" se ejecuta **siempre al menos una vez**, incluso si la condición es falsa desde el principio. En cambio, si la condición de un bucle "mientras" es falsa desde el inicio, el bloque de código nunca se ejecuta.

**Ejemplos de Uso de "Mientras":**

* Pedirle al usuario que ingrese una contraseña hasta que ingrese la correcta. No sabemos cuántos intentos necesitará. La condición para seguir pidiendo la contraseña es que la contraseña ingresada sea incorrecta.
* Leer datos de un archivo hasta que se llegue al final del archivo. No sabemos cuántas líneas tiene el archivo. La condición para seguir leyendo es que no hayamos llegado al final del archivo.
* Un juego que continúa hasta que el jugador pierde o alcanza un cierto puntaje. No sabemos cuánto tiempo jugará el usuario. La condición para que el juego continúe es que el jugador no haya perdido y no haya alcanzado el puntaje objetivo.

**Ejemplos de Uso de "Hacer Mientras":**

* Mostrar un menú al usuario y pedirle que elija una opción. El menú se mostrará al menos una vez, y luego se seguirá mostrando mientras el usuario no elija la opción de "salir".
* Pedirle al usuario un número entre 1 y 10. Se le pedirá el número al menos una vez, y se seguirá pidiendo hasta que ingrese un número válido.