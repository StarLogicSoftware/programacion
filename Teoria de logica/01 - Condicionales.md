# Los Condicionales en Programación: Tomando Decisiones Inteligentes

Imagina que estás jugando un videojuego. A veces, lo que sucede en el juego depende de tus acciones o de ciertas situaciones. Por ejemplo, si encuentras una llave, se abre una puerta. Si tu personaje tiene poca salud, debe buscar un botiquín. Estas "decisiones" dentro del juego son similares a lo que llamamos **condicionales** en programación.

## ¿Qué son los Condicionales?

En programación, un **condicional** es una herramienta que le permite a tu programa tomar decisiones. Es como hacer una pregunta y, dependiendo de la respuesta (verdadero o falso), el programa hará una cosa u otra.

Piensa en una receta de cocina. A veces dice: "Si la mezcla está demasiado seca, añade un poco de leche". Aquí, la condición es "¿la mezcla está demasiado seca?" Si la respuesta es sí (verdadero), entonces sigues la instrucción de añadir leche. Si la respuesta es no (falso), simplemente continúas con el siguiente paso.

## ¿Para qué se Utilizan los Condicionales?

Los condicionales son fundamentales para crear programas que no siempre hagan lo mismo, sino que se adapten a diferentes situaciones o a la información que reciben. Se utilizan para:

* **Filtrar información:** Decidir si ciertos datos cumplen con un criterio específico. Por ejemplo, verificar si la edad de un usuario es suficiente para acceder a cierto contenido.
* **Controlar el flujo del programa:** Determinar qué partes del código se ejecutarán y cuáles no. Como en el ejemplo del videojuego, abrir la puerta solo si se tiene la llave.
* **Responder a las acciones del usuario:** Cambiar el comportamiento del programa según lo que el usuario haga. Por ejemplo, mostrar un mensaje diferente si el usuario presiona un botón en lugar de otro.
* **Manejar errores:** Detectar situaciones inesperadas y tomar medidas para evitar que el programa falle. Por ejemplo, si un archivo no se encuentra, mostrar un mensaje de error en lugar de detenerse bruscamente.

## Ejemplos Cotidianos de Decisiones Condicionales

Las decisiones condicionales están a nuestro alrededor:

* **El semáforo:** Si la luz está en verde, puedes cruzar. Si está en rojo, debes detenerte.
* **El ascensor:** Si presionas el botón de un piso, el ascensor se moverá hacia ese piso.
* **Una alarma:** Si la hora actual coincide con la hora configurada, la alarma sonará.
* **Una puerta automática:** Si alguien se acerca, la puerta se abre.

En todos estos ejemplos, hay una condición (la luz, el botón, la hora, la presencia de alguien) que determina qué acción se lleva a cabo.

## La Estructura de la Pregunta del Condicional

La base de un condicional es una **pregunta** o **condición** que se evalúa para determinar si es **verdadera** o **falsa**. Esta pregunta generalmente implica una comparación.

Piensa en estas preguntas:

* ¿Está lloviendo? (Verdadero o Falso)
* ¿La temperatura es mayor de 25 grados? (Verdadero o Falso)
* ¿Tienes permiso para entrar? (Verdadero o Falso)

La respuesta a estas preguntas (verdadero o falso) es lo que decide qué camino seguirá el programa.

## Símbolos y su Significado en las Comparaciones

Aunque todavía no veamos código, es bueno saber que para hacer estas preguntas en programación, a menudo se utilizan símbolos especiales para realizar comparaciones:

* **Mayor que:** Se utiliza para verificar si un valor es más grande que otro. (Ejemplo: ¿La edad es > 18?)
* **Menor que:** Se utiliza para verificar si un valor es más pequeño que otro. (Ejemplo: ¿La cantidad es < 10?)
* **Igual a:** Se utiliza para verificar si dos valores son iguales. (Ejemplo: ¿La contraseña ingresada es = a la contraseña guardada?)
* **Mayor o igual que:** Se utiliza para verificar si un valor es más grande o igual a otro. (Ejemplo: ¿La calificación es >= 6?)
* **Menor o igual que:** Se utiliza para verificar si un valor es más pequeño o igual a otro. (Ejemplo: ¿El día del mes es <= 31?)
* **Diferente de:** Se utiliza para verificar si dos valores no son iguales. (Ejemplo: ¿El nombre de usuario es != a "admin"?)

Estos símbolos nos ayudan a formular las preguntas que nuestros condicionales evaluarán.

## Usos del Solo Verdadero (Si)

La forma más básica de un condicional es la que se ejecuta solo si la condición es **verdadera**. Es como decir: "Si pasa esto (verdadero), entonces haz esto otro".

Ejemplos:

* **Si** está lloviendo (verdadero), **entonces** lleva un paraguas.
* **Si** tienes hambre (verdadero), **entonces** come algo.
* **Si** la puerta está cerrada con llave (verdadero), **entonces** busca la llave.

En programación, usaríamos algo similar para que el programa realice una acción específica solo cuando se cumple una condición.

## Usos del Verdadero y Falso (Si - Sino)

A menudo, queremos que el programa haga una cosa si la condición es verdadera y otra cosa diferente si la condición es **falsa**. Esto se conoce como una estructura "si - sino" o "if - else".

Ejemplos:

* **Si** está soleado (verdadero), **entonces** ve al parque. **Sino** (falso), quédate en casa.
* **Si** adivinaste el número correcto (verdadero), **entonces** ganaste. **Sino** (falso), inténtalo de nuevo.
* **Si** eres mayor de edad (verdadero), **entonces** puedes votar. **Sino** (falso), aún no puedes votar.

Esta estructura nos da dos caminos posibles para que el programa siga, dependiendo del resultado de la pregunta.