
// Programa de altura del globo

float tiempo;
float altura;

Console.WriteLine("Ingrese el tiempo dedsde que solto el globo");
tiempo = float.Parse(Console.ReadLine());

//altura = tiempo * 0.5f + 1;
altura = CalcularAlturaGlobo(tiempo);

Console.WriteLine($"La altura del globo es: {altura}");

// ejemplo de llamar varias veces a una misma función
Saludar();
Saludar();
Saludar();
Saludar();
Saludar();

// Practica de declarar una función
// Se llama Calcularalturaglobo, se le debe pasar el tiempo del globo y luego
// de hacer el calculo, devuelve un valor de tipo flotante
float CalcularAlturaGlobo(float tiempoGlobo)
{
    float alturaCalculada;
    alturaCalculada = (tiempoGlobo * (1/2) + 1);

    return alturaCalculada;
}

void Saludar()
{
    Console.WriteLine("Hola");
}

// Declaracion y uso de funciones

// firma - bloque de codigo
// llamar a la funcion

/*
 firma tiene que tener:
    1_ valor de retorno (tipo de dato que devuelve la funcion)
    2_ nombre de la funcion
    3_ parametros de entrada

caracteristicas de las funciones
1_ aislado del resto del codigo
2_ las funciones peuden NO tener valor de retorno (void -> vacio)
3_ funciones sin parametros - los parentesis se escriben igual
4_ sin retorno y sin parametros
5_ Solo se ejecuta si la llamamos
6_ Puede ejecutarla mas de una vez
7_ Si hay un dato que cambia entre ejecuciones de la funcion, es un parametro
8_ si hay mas de un parametro, se separan con coma
9_ los datos de los parametros se colocan en orden a como estan en la firma
10_ el nombre de la funcion respeta las reglas de las variables
11_ cada funcion se deberia dedicar a UNA SOLA COSA
*/