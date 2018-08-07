/* Nombre del Autor: Mauricio Mejia
 Fecha: 13 de Diciembre de 2016
 Doy fe que este ejercicio es de mi autoría, en caso de encontrar plagio la nota de todo mi 
trabajo debe ser de CERO además de las respectivas sanciones a que haya lugar*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_final_algoritmos
{
    class Program
    {
        static void Main(string[] args)
        {

            string usuario;
            string contraseña;
            int intentos = 1;

            do
            {
                Console.Clear();
                Console.WriteLine("*******************************************************");
                Console.WriteLine("Nombre de la Empresa: LogoTI Latam ");
                Console.WriteLine();
                Console.WriteLine("Télefono: 317 8956150");
                Console.WriteLine();
                Console.WriteLine("Correo electrónico: Mauricio.Mejia@logoti-latam.com.co");
                Console.WriteLine();
                Console.WriteLine("*******************************************************");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("***************INICIO DE SESIÓN ***********************");
                Console.WriteLine();
                Console.WriteLine("Usuario");
                usuario = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Contraseña");
                contraseña = Convert.ToString(Console.ReadLine());
                if (usuario == "algoritmos" && contraseña == "301303")
                {
                    //Menu

                    int op;

                    do
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen; /*Color de fondo*/
                        Console.ForegroundColor = ConsoleColor.White; /*Color de letra */

                        Console.Clear();
                        //Menu principal
                        Console.WriteLine("*********************************** Trabajo final - Laboratorio de Algoritmos ****************************");
                        Console.WriteLine();
                        Console.WriteLine("1. Define Programa de Flujo de datos.");
                        Console.WriteLine("2. Define Programa.");
                        Console.WriteLine("3. Define Condicional.");
                        Console.WriteLine("4. Ejemplo con condicional.");
                        Console.WriteLine("5. Define que es un Ciclo.");
                        Console.WriteLine("6. Define Tipos de Ciclos.");
                        Console.WriteLine("7. Ejemplo Ciclos.");
                        Console.WriteLine("8. Define Contador.");
                        Console.WriteLine("9. Ejemplo contador.");
                        Console.WriteLine("10. Define Acumulador.");
                        Console.WriteLine("11. Ejemplo Acumulador.");
                        Console.WriteLine("12. Información estudiante.");
                        Console.WriteLine("13. Salir.");
                        Console.WriteLine();
                        Console.WriteLine("**********************************************************************************************************");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Seleccione una opción:");
                        do
                        {
                            op = int.Parse(Console.ReadLine());
                            Console.Clear();
                        } while (op < 1 || op > 13);
                        switch (op)
                        {
                            case 1:
                                menu1();
                                break;
                            case 2:
                                menu2();
                                break;
                            case 3:
                                menu3();
                                break;
                            case 4:
                                menu4();
                                break;
                            case 5:
                                menu5();
                                break;
                            case 6:
                                menu6();
                                break;
                            case 7:
                                menu7();
                                break;
                            case 8:
                                menu8();
                                break;
                            case 9:
                                menu9();
                                break;
                            case 10:
                                menu10();
                                break;
                            case 11:
                                menu11();
                                break;
                            case 12:
                                menu12();
                                break;

                        }

                    } while (op != 13);
                    Console.WriteLine();
                    Console.WriteLine("Gracias por utilizar el programa. Vuelve pronto.");
                    Console.WriteLine();
                    Console.Write("\nPresione en la X para salir . . . ");
                    Console.ReadKey();

                }//cierre if 
                else
                {
                    if (intentos <= 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Acceso denegado...");
                        Console.WriteLine();
                        Console.WriteLine("Credenciales de acceso inválidos. Intente nuevamente...");
                        Console.WriteLine();
                        Console.Write("Intento 2 de 2...");
                        Console.WriteLine();
                        Console.Write("\nPresione una tecla para realizar el intento . . . ");
                        Console.ReadKey();
                        intentos++;
                    }
                    else
                    {
                        if (intentos == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Acceso denegado...");
                            Console.WriteLine();
                            Console.WriteLine("Crenciales de acceso inválidos. Intente nuevamente...");
                            Console.WriteLine();
                            Console.WriteLine("Sesion bloqueada por intentos permitidos fallidos. Gracias por usar el sistema ...");
                            Console.WriteLine();
                            Console.WriteLine("\nPresione una tecla para continuar. . . ");
                            Console.ReadKey();
                            intentos++;
                        }
                    }
                }
            } while (intentos != 3); // cierre do  portada
        }





        public static void menu1()
        {
            Console.WriteLine("¿Que es un programa?");
            Console.WriteLine();
            Console.WriteLine("Un programa informático o programa de computadora es una secuencia de instrucciones, escritas para realizar una tarea específica en una computadora.Este dispositivo requiere programas para funcionar, por lo general, ejecutando las instrucciones del programa en un procesador central.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("La consulta se ha realizado exitosamente! ");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para volver al menú . . . ");
            Console.WriteLine();
            Console.ReadKey();
        }


        public static void menu2()
        {
            Console.WriteLine("¿Que es flujo de datos?");
            Console.WriteLine();
            Console.WriteLine("Es una descripción grafica de un procedimiento para la resolución de un problema.Son frecuentemente usados para descubrir algoritmos y programas de computador.Los diagramas de flujos están compuestos por figuras conectadas con flechas. Para ejecutar un proceso comienza por el Inicio y se siguen las acciones indicadas por cada figura: El tipo de figura indica el tipo de paso que representa.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("La consulta se ha realizado exitosamente! ");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para volver al menú . . . ");
            Console.WriteLine();
            Console.ReadKey();
        }


        public static void menu3()
        {
            Console.WriteLine("¿Que es un condicional?");
            Console.WriteLine();
            Console.WriteLine("Un condicional en la programación es una sentencia o grupo de sentencias que puede ejecutarse o no en función del valor de una condición.");
            Console.WriteLine();
            Console.WriteLine("Los condicionales constituyen junto con los bucles los pilares de la programación estructurada, y su uso es una evolución de una sentencia de lenguaje ensamblador que ejecutaba la siguiente línea o no en función del valor de una condición.");
            Console.WriteLine();
            Console.WriteLine("Tipos de condicionales:");
            Console.WriteLine();
            Console.WriteLine("Los tipos más conocidos de condicionales son el SI ENTONCES (if then), el SI - SI NO (if then- else) y el SEGÚN (case o switch), aunque también podríamos mencionar al lanzamiento de errores como una alternativa más moderna para evitar el anidamiento de condicionales. ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("La consulta se ha realizado exitosamente! ");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para volver al menú . . . ");
            Console.WriteLine();
            Console.ReadKey();
        }


        public static void menu4()
        {
            Console.WriteLine("Ejemplo con condicional:(Ejercicio 1). Leer 4 número por teclado e indicar si la suma de los 3 primeros es igual al 4 numero.");
            Console.WriteLine();
            Console.WriteLine();

            int n1, n2, n3, n4;
            Console.WriteLine("Digite 4 numeros:");
            Console.WriteLine("No.1:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("No.2:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("No.3:");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("No.4 -->:");
            n4 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Comienzo del condicional
            if (n1 + n2 + n3 == n4)
            {
                Console.WriteLine("La suma de los primeros 3 numeros es igual al 4");
            }
            else
                //Fin condicional
                Console.WriteLine("La suma de los primeros 3 numeros no es igual al 4");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("La consulta se ha realizado exitosamente! ");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para volver al menú . . . ");
            Console.WriteLine();
            Console.ReadKey();
        }


        public static void menu5()
        {
            Console.WriteLine("¿Que es un ciclo?");
            Console.WriteLine();
            Console.WriteLine("Un bucle o ciclo, en programación, es una sentencia que se realiza repetidas veces a un trozo aislado de código, hasta que la condición asignada a dicho bucle deje de cumplirse.");
            Console.WriteLine("Generalmente, un bucle es utilizado para hacer una acción repetida sin tener que escribir varias veces el mismo código, lo que ahorra tiempo, procesos y deja el código más claro y facilita su modificación en el futuro.");
            Console.WriteLine("Los tres bucles más utilizados en programación son el bucle while, el bucle for y el bucle repetir.");
            Console.WriteLine();
            Console.Write("La consulta se ha realizado exitosamente! ");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para volver al menú . . . ");
            Console.WriteLine();
            Console.ReadKey();
        }


        public static void menu6()
        {
            Console.WriteLine("Definición de tipos de ciclos:");
            Console.WriteLine();
            Console.WriteLine("CICLO WHILE: La instrucción while (que en castellano se traduciría como “mientras…”) ejecuta una porción de programa mientras se cumpla una cierta condición. Mientras la condición sea verdadera, se ejecutan las instrucciones contenidas en el while.Cuando deja de cumplirse la condición, se sale del ciclo y se continúa ejecutando el resto del programa. Si la condición no se cumple ni la primera vez que se comprueba, las líneas en el interior del while no se ejecutarán ni una vez.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("CICLO DO - WHILE: La estructura repetitiva do-while (en castellano equivaldría a hacer… mientras) es muy similar a la estructura while, excepto que la expresión verdadera es verificada al final de cada iteración en lugar de al principio. La diferencia principal con los bucles while es que está garantizado que se ejecuten las instrucciones que contienen, al menos una vez(la verificación de si se tiene que repetir el proceso se realiza al final de la repetición de la estructura.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("CICLO FOR: La estructura repetitiva for (en castellano se traduciría como “desde…”) se utiliza generalmente cuando tenemos bien determinada la cantidad de repeticiones a realizar. Se diferencia de las anteriores en que se debe incluir en la propia instrucción una variable de control, la cual se incrementa o decremento de forma automática. La estructura de estas instrucciones viene a ser muy similar a la anterior.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("La consulta se ha realizado exitosamente! ");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para volver al menú . . . ");
            Console.WriteLine();
            Console.ReadKey();
        }


        public static void menu7()
        {
            int op;
            do
            {   //Submenu de ejemplos de ciclos
                Console.Clear();
                Console.WriteLine("****************************************** Ejemplos de Ciclos *******************************************");
                Console.WriteLine();
                Console.WriteLine("1. Ciclo While (Mientras).");
                Console.WriteLine("2. Ciclo Do-While (Hacer..Mientras).");
                Console.WriteLine("3. Ciclo For (Desde).");
                Console.WriteLine("4. Salir.");
                Console.WriteLine();
                Console.WriteLine("**********************************************************************************************************");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Seleccione una opción:");
                do
                {
                    op = int.Parse(Console.ReadLine());
                    Console.Clear();
                } while (op < 1 || op > 4);
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ejemplo de Ciclo While (Mientras).");
                        Console.WriteLine();
                        Console.WriteLine();
                        int num;
                        int divisor = 2;
                        Console.WriteLine("(Ejercicio 12.d). Programa para calcular si un número es primo o no");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Ingresa un número: ");
                        num = int.Parse(Console.ReadLine());
                        Console.WriteLine(" ");
                        //Comienzo ciclo while
                        while (divisor < num)
                        {
                            while (num % divisor != 0)
                                divisor = divisor + 1;
                            if (num == divisor)
                            {
                                Console.WriteLine("El número " + num + " es un número primo");
                            }
                            else
                            {
                                Console.WriteLine("El número " + num + " no es número primo ");
                                break;
                            }
                        }
                        //Fin del ciclo while
                        Console.WriteLine();
                        Console.Write("\nPresione una tecla para volver al submenú . . . ");
                        Console.ReadKey();
                        break;


                    case 2:
                        Console.WriteLine("2. Ciclo Do-While (Hacer..Mientras).");
                        Console.WriteLine();
                        Console.WriteLine();

                        double ladoa;
                        double ladob;
                        double bas;
                        double area_circulo;
                        double area_cuadrado;
                        double area_paralelogramo;
                        double area_rectangulo;
                        double area_triangulo;
                        double h;
                        double radio;
                        int opc;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Programa que permite leer de un menú operaciones  y realizar respectivos cálculos");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("1.- área de un triangulo");
                            Console.WriteLine("2.- área de un cuadrado");
                            Console.WriteLine("3.- área de un círculo");
                            Console.WriteLine("4.- área de un rectángulo");
                            Console.WriteLine("5.- área de un paralelogramo");
                            Console.WriteLine("0.- Salir");
                            Console.WriteLine(" ");
                            Console.WriteLine("Elija una opción [1-5]: ");
                            opc = int.Parse(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    Console.WriteLine("El área de un triángulo es igual a base por altura dividido entre 2.");
                                    Console.WriteLine("Ingrese la base:");
                                    bas = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la altura:");
                                    h = Double.Parse(Console.ReadLine());
                                    area_triangulo = (bas * h) / 2;
                                    Console.WriteLine("El area es: " + area_triangulo);
                                    break;
                                case 2:
                                    Console.WriteLine("El área del cuadrado es igual a lado por lado.");
                                    Console.WriteLine("Ingrese lado a:");
                                    ladoa = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Lado b:");
                                    ladob = Double.Parse(Console.ReadLine());
                                    area_cuadrado = ladoa * ladob;
                                    Console.WriteLine("El area es: " + area_cuadrado);
                                    break;
                                case 3:
                                    Console.WriteLine("El área del círculo es igual a PI por el radio al cuadrado..");
                                    Console.WriteLine("Ingrese el radio:");
                                    radio = Double.Parse(Console.ReadLine());
                                    area_circulo = Math.PI * Math.Pow(radio, 2);
                                    Console.WriteLine("El area es: " + area_circulo);
                                    break;
                                case 4:
                                    Console.WriteLine("El área del rectángulo es igual a base por altura.");
                                    Console.WriteLine("Ingrese la base:");
                                    bas = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la altura:");
                                    h = Double.Parse(Console.ReadLine());
                                    area_rectangulo = bas * h;
                                    Console.WriteLine(" El area es: " + area_rectangulo);
                                    break;
                                case 5:
                                    Console.WriteLine("El área de un paralelogramo es igual al producto de la base por la altura relativa.");
                                    Console.WriteLine("Ingrese la altura relativa:");
                                    h = Double.Parse(Console.ReadLine());
                                    Console.WriteLine("Ingrese la base:");
                                    bas = Double.Parse(Console.ReadLine());
                                    area_paralelogramo = bas * h;
                                    Console.WriteLine("El area es: " + area_paralelogramo);
                                    break;
                                case 0:
                                    Console.WriteLine("Salida exitosa.");
                                    break;
                                default:
                                    Console.WriteLine("Opción no válida, intente nuevamente.");
                                    break;
                            }
                            Console.WriteLine();
                            Console.WriteLine("Presione una tecla para continuar... ");
                            Console.ReadKey();
                        } while (opc != 0);

                        Console.WriteLine();
                        Console.Write("\nPresione una tecla para volver al submenú . . . ");
                        Console.ReadKey();
                        break;


                    case 3:
                        Console.WriteLine("Ejemplo de Ciclo For (Desde).");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("[1]. Ejercicio 1: Programa que permite encriptar la contraseña de un banco");
                        Console.WriteLine();
                        Console.WriteLine();
                        String a = "";
                        Console.WriteLine("Por favor, ingrese un número de 4 digitos:");
                        String pal = Console.ReadLine();
                        int numero = pal.Length;

                        if (numero == 4)
                        {   //Ciclo for
                            for (int i = numero - 1; i >= 0; i--)
                            {
                                a = a + pal.Substring(i, 1);
                            }
                            Console.WriteLine(" La contraseña encriptada es : {0} ", a);
                            Console.WriteLine();
                            Console.Write("La consulta se ha realizado exitosamente.! ");
                            Console.WriteLine();
                            Console.Write("\nPresione una tecla para volver al menú . . . ");
                        }
                        else
                        {
                            Console.WriteLine("Error!.El número ingresado no es de 4 digitos");

                        }
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.Write("\nPresione una tecla para volver al submenú . . . ");
                        Console.ReadKey();
                        break;
                }
            } while (op != 4);
            Console.WriteLine();
            Console.Write("Salida exitosa del submenú");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para volver al menú principal . . . ");
            Console.ReadKey();
        }


        public static void menu8()
        {
            Console.WriteLine("¿Que es un contador?");
            Console.WriteLine();
            Console.WriteLine("El contador es un registro del procesador de un computador que indica la posición donde está el procesador en su secuencia de instrucciones. Dependiendo de los detalles de la máquina particular, contiene o la dirección de la instrucción que es ejecutada, o la dirección de la próxima instrucción a ser ejecutada. El contador de programa es incrementado automáticamente en cada ciclo de instrucción de tal manera que las instrucciones son leídas en secuencia desde la memoria. Ciertas instrucciones, tales como las bifurcaciones y las llamadas y retornos de subrutinas, interrumpen la secuencia al colocar un nuevo valor en el contador de programa.");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("La consulta se ha realizado exitosamente! ");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para volver al menú . . . ");
            Console.WriteLine();
            Console.ReadKey();
        }


        public static void menu9()
        {
            double ast;
            double vacio;
            double lado_fig;

            Console.WriteLine("Ejemplo con contador:(Ejercicio 10). Diseñar un Programa que lea un número entero (lado) y a partir de él cree un cuadrado de asteriscos con ese tamaño.");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Ingrese la cantidad de lados:");
            lado_fig = Double.Parse(Console.ReadLine());
            //Contadores para asteriscos y espacios vacios
            for (ast = 1; ast <= lado_fig; ast++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
            for (ast = 1; ast <= lado_fig - 2; ast++)
            {
                Console.Write("*");
                for (vacio = 1; vacio <= lado_fig - 2; vacio++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine(" ");
            }
            for (ast = 1; ast <= lado_fig; ast++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("La consulta se ha realizado exitosamente! ");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para volver al menú . . . ");
            Console.WriteLine();
            Console.ReadKey();
        }


        public static void menu10()
        {
            Console.WriteLine("¿Que es un acumulador?");
            Console.WriteLine();
            Console.WriteLine("El concepto de acumulador guarda relación estrecha con el de contador. Podríamos decir que el contador es un tipo específico de acumulador. Definiremos acumulador como un elemento cuyo contenido actual se genera a partir de su contenido precedente.");
            Console.WriteLine();
            Console.WriteLine("En general, los valores del acumulador se van generando a través de sumas(o restas) sucesivas.Casos particulares serían los de generación de valores a partir de multiplicaciones(o divisiones) u otras operaciones matemáticas.");
            Console.WriteLine();
            Console.Write("La consulta se ha realizado exitosamente! ");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para volver al menú . . . ");
            Console.WriteLine();
            Console.ReadKey();
        }


        public static void menu11()
        {
            Console.WriteLine("Ejemplo con acumulador: (Ejercicio 3). Calcular con cantidad validad de billetes de un cajero automático.");
            Console.WriteLine();
            Console.WriteLine();
            //Definición de variables
            double cincuentamil = 0;
            double diezmil = 0;
            double monto = 0;
            double veintemil = 0;

            Console.WriteLine("Ingresar el monto: ");
            monto = Double.Parse(Console.ReadLine());

            if (monto % 10000 == 0)
            {
                while (monto > 0)
                {
                    if (monto >= 50000)
                    {
                        monto = monto - 50000;
                        // Acumulador de billetes de cincuentamil
                        cincuentamil = cincuentamil + 1;
                    }
                    else
                    {
                        if (monto >= 20000)
                        {
                            monto = monto - 20000;
                            //Acumulador de billetes de veintemil
                            veintemil = veintemil + 1;
                        }
                        else
                        {
                            monto = monto - 10000;
                            //Acumulador de billetes de diezmil
                            diezmil = diezmil + 1;
                        }
                    }
                }
                Console.WriteLine("Te entregamos:");
                Console.WriteLine("");
                Console.WriteLine("*" + cincuentamil + " billetes de 50000.");
                Console.WriteLine("*" + veintemil + " billetes de 20000.");
                Console.WriteLine("*" + diezmil + " billetes de 10000.");
            }
            else
            {
                Console.WriteLine("Error!. su número no es multiplo de 10000.");
            }
            Console.WriteLine();
            Console.Write("La consulta se ha realizado exitosamente! ");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para volver al menú . . . ");
            Console.WriteLine();
            Console.ReadKey();
        }


        public static void menu12()
        {
            //Salida de texto por teclado, información del estudiante
            Console.WriteLine("Información del estudiante:");
            Console.WriteLine();
            Console.WriteLine("Nombre del autor: Mauricio Mejia Estevez");
            Console.WriteLine("CEAD: Barrancabermeja");
            Console.WriteLine("Codigo: 1005272338 ");
            Console.WriteLine("Presentado a: Ing.Freddy Alexander Castellanos");
            Console.WriteLine();
            Console.Write("La consulta se ha realizado exitosamente! ");
            Console.WriteLine();
            Console.Write("\nPresione una tecla para volver al menú . . . ");
            Console.WriteLine();
            Console.ReadKey();
        }


    }//Cierre class
} //Cierre static void

