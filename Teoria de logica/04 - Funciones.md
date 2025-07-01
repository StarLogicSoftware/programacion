# Funciones (o métodos)
-----

## ¿Qué son las Funciones en C\#?

En programación, una **función** (también conocida como método en C\# cuando está dentro de una clase) es un bloque de código reutilizable que realiza una tarea específica. Imagina que es como una pequeña máquina o una receta: le das unos **ingredientes** (parámetros), la máquina hace su **trabajo** (el cuerpo de la función) y te entrega un **resultado** (valor de retorno).

### Analogía con las Funciones Matemáticas

Tienen mucho en común con las funciones matemáticas. Pensemos en la función matemática $f(x) = 2x + 3$:

  * **$f(x)$ (la función en sí):** Representa el concepto de la función en C\#. Es el nombre que le das a tu bloque de código, como `CalcularDobleMasTres`.
  * **$x$ (los parámetros):** Son las **entradas** que le das a tu función. En C\#, serían las variables que defines entre paréntesis al declarar la función. Por ejemplo, si tu función es `int Sumar(int numero1, int numero2)`, `numero1` y `numero2` serían tus parámetros.
  * **$2x + 3$ (el cálculo/proceso):** Es el **cuerpo de la función**, es decir, las instrucciones o el código que se ejecuta dentro de ella. Aquí es donde se realizan las operaciones para llegar al resultado deseado.
  * **El valor que obtienes al evaluar $f(x)$ (la salida):** Es el **valor de retorno** de la función. Es el resultado que la función "devuelve" después de haber procesado sus entradas.

-----

## Componentes Clave de una Función en C\#

Una función en C\# tiene varias partes importantes que la definen:

### 1\. Firma de la Función

La **firma de la función** es como su tarjeta de presentación. Le dice al compilador y a otros programadores todo lo que necesitan saber sobre cómo usar esa función. Incluye el tipo de retorno, el nombre de la función y sus parámetros.

Considera la siguiente firma:

```csharp
int SumarNumeros(int num1, int num2)
```
  * **`int` (Tipo de Retorno):** Indica el **tipo de dato** que la función devolverá al finalizar su ejecución. En este caso, devolverá un número entero. Si una función no devuelve ningún valor, se utiliza la palabra clave `void` (similar a cuando una máquina hace algo pero no te entrega un producto, solo realiza una acción, como encender una luz).
  * **`SumarNumeros` (Nombre de la Función):** Es un identificador único que le das a tu función. Debe ser descriptivo para entender qué hace la función.
  * **`(int num1, int num2)` (Lista de Parámetros):** Son las **entradas** que la función espera recibir. Cada parámetro tiene un tipo de dato y un nombre. Puedes tener cero o más parámetros, separados por comas.

### 2\. Cuerpo de la Función

El **cuerpo de la función** es el bloque de código encerrado entre llaves `{}`. Aquí es donde se escribe la lógica que la función ejecutará cuando sea llamada.

```csharp
int SumarNumeros(int num1, int 2)
{
    int resultado = num1 + num2; // Aquí está el proceso o cálculo
    return resultado;            // Aquí se devuelve el resultado
}
```

Dentro del cuerpo, puedes declarar variables locales, realizar operaciones, llamar a otras funciones, etc.

### 3\. Valor de Retorno

Como mencionamos, el **valor de retorno** es el resultado que la función produce y "entrega" de vuelta a la parte del código que la llamó. La palabra clave **`return`** se utiliza para especificar el valor que será devuelto. El tipo de este valor debe coincidir con el **tipo de retorno** especificado en la firma de la función.

Si una función tiene un tipo de retorno `void`, no utiliza la palabra clave `return` para devolver un valor. Sin embargo, `return;` por sí solo puede usarse para salir de la función en un punto específico.

### 4\. Parámetros

Los **parámetros** son variables que actúan como "marcadores de posición" para los valores que le pasarás a la función cuando la llames. Piensa en ellos como los huecos en una receta donde especificas la cantidad de azúcar o harina.

Cuando llamas a la función, le proporcionas **argumentos**, que son los valores reales que se utilizan en lugar de los parámetros.

```csharp
// Llamando a la función SumarNumeros y pasando 5 y 10 como argumentos
int sumaTotal = SumarNumeros(5, 10);
// Aquí, num1 toma el valor de 5, y num2 toma el valor de 10
```

-----

## Nomenclatura y Buenas Prácticas

En C\#, es común seguir ciertas convenciones de nomenclatura para hacer el código más legible:

  * **Nombres de Funciones (Métodos):** Utiliza **PascalCase** (la primera letra de cada palabra en mayúscula, sin espacios). Deben ser verbos o frases verbales que describan la acción que realiza la función.
      * Ejemplos: `CalcularPromedio`, `GuardarUsuario`, `ObtenerDatos`.
  * **Nombres de Parámetros:** Utiliza **camelCase** (la primera letra de la primera palabra en minúscula, y la primera letra de las palabras siguientes en mayúscula).
      * Ejemplos: `nombreUsuario`, `cantidadProductos`, `fechaInicio`.

### Por qué son Importantes las Funciones

  * **Reutilización de Código:** Evita escribir el mismo código varias veces. Defines una función una vez y la puedes llamar cuantas veces necesites.
  * **Organización:** Divide programas grandes en partes más pequeñas y manejables, haciendo el código más fácil de entender y mantener.
  * **Modularidad:** Permite que diferentes partes de un equipo trabajen en distintas funciones de forma independiente.
  * **Depuración (Debugging):** Si hay un error, es más fácil aislarlo y corregirlo en una función específica que en un bloque de código masivo.

-----

Espero que esta explicación detallada te sea de gran ayuda para comprender a fondo las funciones en C\#\! ¿Hay alguna parte en la que te gustaría profundizar más o algún otro concepto que quisieras explorar?