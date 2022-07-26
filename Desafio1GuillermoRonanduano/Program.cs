// See https://aka.ms/new-console-template for more information

/*
 *****************************************************************************************************
 *                             CLASE 1: C# Y SUS HERRAMIENTAS - LUNES 27/06
 *****************************************************************************************************
*/

/*
int radioCirculo = 3;
const double pi = 3.14159;
double areacirculo;
areacirculo = pi * (radioCirculo * radioCirculo);
string mensajeresultado = "El área del círculo con radio: '";
Console.WriteLine(mensajeresultado + radioCirculo + "' es: " + areacirculo);
*/
/*
//Primer Desafío
string nombre = "Guillermo";
string apellido = "Ronanduano";
string dni = "30.830.906";
int edad = 38;
float altura = 1.75f;
double altura_double = 1.75;

Console.WriteLine("<<< Primer Desafío >>>");
Console.WriteLine("Nombre: " + nombre);
Console.WriteLine("Apellido: " + apellido);
Console.WriteLine("DNI: " + dni);
Console.WriteLine("Edad: " + edad);
Console.WriteLine("Altura Float: " + altura);
Console.WriteLine("Altura Double: " + altura_double);

//Segundo Desafío
int num1;
int num2;
Console.WriteLine("");
Console.WriteLine("<<< Segundo Desafío >>>");
Console.WriteLine("Ingrese el Primer número: "); num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el Segundo número: "); num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("El resultado de la suma es: " + (num1 + num2));

//Tercer Desafío
string apodo;
Console.WriteLine("");
Console.WriteLine("<<< Tercer Desafío >>>");
Console.WriteLine("Ingrese su apodo: "); apodo = Convert.ToString(Console.ReadLine());
Console.WriteLine("Mi nombre es: " + nombre + " " + apodo + " " + apellido);

Console.ReadLine();
*/

/*
 *****************************************************************************************************
 *                            CLASE 2: SINTAXIS Y SENTENCIAS BÁSICAS - MIÉRCOLES 29/06
 *****************************************************************************************************
*/

/*
// Tipos de datos
short vrb_short; //-32768 a 32768 
int vrb_int; //-2147483648 a 2147483648
long vrb_long; //-9223372036854775808 a 9223372036854775808
float precio_float = 1.5f; //6 a 9 posiciones decimales
double precio_double = 22.8; //15 a 17 posiciones decimales
char una_letra = 'A';
char un_simbolo = '$';
bool flag = false;

/*
 * Ejemplo (1) - Uso de IF, ELSE, ELSEIF
int CantProdVendidos = 3;
int CantProdDeposito = 6;
int Stock = CantProdDeposito - CantProdVendidos;

if (Stock == 0)
{
    Console.WriteLine("Reponer stock de producto");
    CantProdDeposito = CantProdVendidos + 10;
    Console.WriteLine("Productos agregados al depósito");
    if (CantProdDeposito > 99)
    {
        Console.WriteLine("Depósito lleno!!!");
    }
}
else if (CantProdVendidos < 5)
{
    Console.WriteLine("Informar a ventas: {0} productos sin vender", Stock);
}
else
{
    Console.WriteLine("Informar a ventas: {0} productos sin vender" + " - Mi Prueba: {1}" + " - Otra: {2}", Stock, CantProdDeposito, 5);
}
Console.ReadLine();
*/

/*
// Ejemplo (2) - Uso de IF + Convert vs Parse
short edad;
float gradoalcohol;
Console.WriteLine("******* BIENVENIDOS A LA LICORERÍA *******");
Console.WriteLine("Ingrese su edad: ");
edad = short.Parse(Console.ReadLine());

if (edad < 18)
{
    Console.WriteLine("Prohibida la venta de bebida a menores...");
}
else
{
    Console.WriteLine("Ingrese el grado de alcohol de la bebida que desea:");
    gradoalcohol = float.Parse(Console.ReadLine());

    if (gradoalcohol > 21.5)
    {
        Console.WriteLine("Le recomendamos las bebidas blancas...");
    }
    else if (gradoalcohol > 14 && gradoalcohol <= 21.5)
    {
        Console.WriteLine("Le recomendamos los licores...");
    }
    else
    {
        Console.WriteLine("Le recomendamos nuestros vinos...");
    }
}

//Importante: La diferencia entre Convert y Parse es que Convert puede aceptar nulls y lo convierte a 0, Parse va a dar error
*/

// Ejemplo (3) - Último ejemplo de IF anidado para validar password
/*const int StoredPass = 12345;

Console.WriteLine("Validando accesso...");
Console.WriteLine("Por favor ingrese su contraseña: ");
int password = Convert.ToInt32(Console.ReadLine());

if (StoredPass == password)
{
    Console.WriteLine("Bienvenido a la matrix...");
}
else
{
    Console.WriteLine("Password incorrecto, reingrese password:");
    password = Convert.ToInt32(Console.ReadLine());
    if (StoredPass == password)
    {
        Console.WriteLine("Bienvenido a la matrix...");
    }
    else
    {
        Console.WriteLine("De vuelta la escribiste mal? Chau");
    }
}
*/
/*
 *****************************************************************************************************
 *                                CLASE 3: BUCLES E ITERACIONES - LUNES 04/07
 *****************************************************************************************************
*/
//Concatenar dos strings
/*
string cadena1 = "Hola, cómo andas? ";
string cadena2 = "Espero que esté todo bien";
string cadena_nula = null;
string cadena_vacia = string.Empty;
Console.WriteLine(cadena1.ToUpper() + cadena2.ToLower());

if (cadena_vacia == cadena_nula)
{
    Console.WriteLine("Cadena vacía = a nula");
}
else
{
    Console.WriteLine("Cadena vacía != a nula");
}

if (String.IsNullOrEmpty(cadena_nula) && String.IsNullOrEmpty(cadena_vacia))
{
    Console.WriteLine("Cadena vacía o nula");
}

Console.WriteLine(cadena_vacia.Length); //Se puede obtener el Lenght de una cadena VACÍA
Console.WriteLine(cadena_nula.Length); //NO se puede obtener el Lenght de una cadena NULA

//Manejo de cadena con ToString. Convierte cualquier cosa a un String
int num1 = 123;
double num_dec = 1.234;
Console.WriteLine(num1.ToString() + " + " + num_dec.ToString());
*/

//String.Contains() y String.Equals() son opciones a utilizar para el manejo de Strings

//Manejo de Bucle WHILE
/*
Console.WriteLine("Ingrese la contraseña:");
string pass = Console.ReadLine();

while (!pass.Equals("hola"))
{
    Console.WriteLine("La contraseña es incorrecta, ingrese nuevamente:");
    pass = Console.ReadLine();
}
Console.WriteLine("Ahora sí ingresaste...");
*/

//Manejo de Bucle DO WHILE
/*
string pass = string.Empty;
do
{
    Console.WriteLine("Ingrese la contraseña:");
    pass = Console.ReadLine();
} 
while (!pass.Equals("hola"));
Console.WriteLine("Ahora sí ingresaste...");
*/

// Ejercicio Resumen
/*
int numero;
Console.WriteLine("Clasificador de números enteros\n\n");
Console.WriteLine("Ingrese un número (0 para salir)");

numero = int.Parse(Console.ReadLine());

while (numero != 0)
{
    if (numero > 0)
    {
        Console.WriteLine("Es un número positivo");
    }
    else
    {
        Console.WriteLine("Es un número negativo");
    }
    Console.WriteLine("Ingrese un número (0 para salir)");
    numero = int.Parse(Console.ReadLine());
}
*/
// Otro ejercicio Resumen
/*
int numerotopemultiplos;
Console.WriteLine("Ingrese un numero tope para calcular los múltiplos de 5:");
numerotopemultiplos = int.Parse(Console.ReadLine());
Console.WriteLine("Los múltiplos de 5 son: ");

if (numerotopemultiplos >= 5)
{
    for (int i = 0; i < numerotopemultiplos; i++)
    {
        if (i % 5 == 0)
        {
            Console.WriteLine(i + ", ");
        }
    }
}
else
{
    Console.WriteLine("No puede ser menor a 5");
}
*/
// Ejercicio para pedir contraseña máximo 5 veces
/*
string sys_pass = "pepepe";

Console.WriteLine("Ingrese su contraseña:");
string user_input = Console.ReadLine();

bool login_succesfull = false;
int Contador = 1;

while (login_succesfull is false)
{
    if (Contador == 5)
    {
        Console.WriteLine("Su contraseña ha sido bloqueada, contacte al Admin.");
        break;
    }
    if (user_input.Equals(sys_pass))
    {
        Console.WriteLine("Ha ingresado correctamente, bienvenido a la app...");
        login_succesfull = true;
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta. Por favor reintente. Le quedan {0} intento(s).",5 - Contador);
        user_input = Console.ReadLine();
    }
    Contador++;
}
*/

/* Validar si el dato ingresado por pantalla es numérico
    string strNum = "ABC";
    //Le enviamos strNum que es la variable donde tenemos nuestro número como string
    if (int.TryParse(strNum, out int num))
    {
        Console.WriteLine($"{num} Es un número entero valido");
    }
    else
    {
        Console.WriteLine($"{strNum} no es un entero valido");
    }

/*
 *****************************************************************************************************
 *                                     CLASE 4: FUNCIONES - MIÉRCOLES 06/07
 *****************************************************************************************************
*/

/*
//Ejemplo de Función void (no retorna nada)

Saludar();
void Saludar()
{
    Console.WriteLine("Hola, cómo estás?");
}
*/

/*
//Ejemplo de Función con return (devuelve valor y lo asigna a la vble que llama a la fcion)

Console.WriteLine("Ingrese el primer número:");
int sumando1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el primer número:");
int sumando2 = int.Parse(Console.ReadLine());

int suma = hacer_suma(sumando1, sumando2);
Console.WriteLine("La suma de los dos es: " + suma);

int hacer_suma(int A, int B)
{
    return A + B;
}
*/

//Ejemplo para Validar contraseña con funciones - Agregar tantos * como letras tenga la contraseña
/*
bool login_exitoso = false;
string stored_pass = "pepepe";
Console.WriteLine("Validando datos...");
login();

void login()
{
    do
    {
        Console.Write("Ingrese su contraseña:");
        string user_input = Console.ReadLine();

        if (user_input.Equals(stored_pass))
        {
            login_exitoso = true;
            Console.WriteLine(cuenta_letras(user_input));
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta. Por favor reintente.");
        }
    }
    while (!login_exitoso);
}

string cuenta_letras(string A)
{
    string cadena = String.Empty;

    for (int i = 0; i < A.Length; i++)
    {
        cadena = cadena + "*";
    }
    cadena = cadena + " es correcta.";
    return cadena;
}
*/


//Ejemplo aplicación para realizar una venta con funciones
/*
Console.WriteLine("<<< Bienvenidos a la mejor tienda de todas >>>");
Console.WriteLine("");
Console.WriteLine("----------------------------------");
Console.WriteLine("Código      Descripción     Precio");
Console.WriteLine("----------------------------------");
Console.WriteLine("DES         Desodorante       200");
Console.WriteLine("JP          Jabón en Polvo    300");
Console.WriteLine("DET         Detergente        250");
Console.WriteLine("");

Console.Write("Ingrese el código de producto (FIN para terminar): ");

bool check = false;

int total_abonar = 0;

string cod_producto = Console.ReadLine().ToUpper();

do
{
    if (cod_producto.Equals("FIN"))
    {
       Console.WriteLine("Gracias por usar la aplicación, esperamos verlo de nuevo!"); break;
    }

    check = validar_producto(cod_producto);
    if (check)
    {
        Console.Write("Ingrese la cantidad del producto: ");
        int cant_producto = int.Parse(Console.ReadLine());
        total_abonar = calculo_precio(cod_producto, cant_producto);
        Console.WriteLine("");
        Console.WriteLine("Cantidad a abonar: $" + total_abonar);
        Console.WriteLine("");
        Console.WriteLine("Muchas gracias por su compra!!!");
    }
    else
    {
        Console.WriteLine("Producto inexistente. Ingrese el código de producto (FIN para terminar): ");
        cod_producto = Console.ReadLine().ToUpper();
    }

} while (!check);

//Función para validar si el producto es válido
bool validar_producto(string A)
{
    if (A.Equals("DES"))
    {
        return true;
    }
    else if (A.Equals("JP"))
    {
        return true;
    }
    else if (A.Equals("DET"))
    {
        return true;
    }
    else
    {
        return false;
    }
}
//Función para calcular el precio del producto * cantidad
int calculo_precio(string producto, int cant)
{
    int precio_total = 0;

    if (producto.Equals("DES"))
    {
        return precio_total = cant * 200;
    }
    else if (producto.Equals("JP"))
    {
        return precio_total = cant * 300;
    }
    else if (producto.Equals("DET"))
    {
        return precio_total = cant * 250;
    }
    else
    {
        return 0;
    }
}
*/

/*
 *****************************************************************************************************
 *                                     CLASE 5: POO - LUNES 11/07
 *****************************************************************************************************
*/
//Ejemplo de clases - namespace agrupador de clases
/*
namespace MiclasedeEjemplo
{
    public class producto
    {
        //Atributos de la clase
        public int _codigo;
        private string _descripcion;
        private double _precio_compra;
        private double _precio_venta;
        private string _categoria;
        
        //Constructor
        public producto()
        {
            _codigo = 0;
            _descripcion = String.Empty;
            _precio_compra = 0;
            _precio_venta = 0;
            _categoria = String.Empty;
        }
        
        //Lo mismo que el anterior sólo que en vez de inicializar con valores va a ser con parámetros
        public producto(int codigo, string descripcion, double precio_compra, double precio_venta, string categoria)
        {
            this._codigo = codigo;
            this._descripcion = descripcion;
            this._precio_compra = precio_compra;
            this._precio_venta = precio_venta;
            this._categoria = categoria;
        }

        //Método publico descripción
        public string Obtener_Descripcion()
        {
            return _descripcion;
        }
        //Método publico para revisar un valor
        public bool hayprecioventa()
        {
            return _precio_venta > 0;
        }

    }
    
    //Instancia de la clase producto
    class ProbarObjeto
    {
        static void Main(string[] args)
        {
            producto prod_por_defecto = new producto();
            producto prod_con_construct_parametrizado = new producto(45,"Hola soy un producto",300,400,"Categoría del producto");
            
            Console.WriteLine(prod_por_defecto._codigo);
            Console.WriteLine(prod_con_construct_parametrizado._codigo);
            Console.WriteLine(prod_por_defecto.Obtener_Descripcion());
            if (prod_por_defecto.hayprecioventa())
            {
                Console.WriteLine("El producto está a la venta");
            }
            else
            {
                Console.WriteLine("El producto NO está a la venta");
            }
        }
    }
}
*/

/* Ejemplo clase - Facundo
namespace EjemploDeClase
{
    class ProbarObjetos
    {
        static void Main(string[] args)
        {
            Producto productoPorDefecto = new Producto();
            Console.WriteLine(productoPorDefecto.Categoria);

            productoPorDefecto.Categoria = "Categoria de producto";

            Console.WriteLine(productoPorDefecto.Categoria);

        }
    }

    public class Producto
    {
        private int _codigo;
        public int Codigo
        {
            get
            {
                return this._codigo;
            }
            set
            {
                this._codigo = value;
            }
        }

        private string _descripcion;
        private string Descripcion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                this._descripcion = value;
            }
        }
        private string _categoria;
        public string Categoria
        {
            get
            {
                if(!String.IsNullOrEmpty(this._categoria))
                {
                    return this._categoria;
                }
                else
                {
                    return "SIN CATEGORIA";
                }
            }
            set
            {
                this._categoria = value;
            }
        }

        private double _precioDeCompra;
        private double _precioDeVenta;
    }
}
*/

/* Ejemplo clase - Facundo 2
namespace EjemploDeClase
{
    public class Usuario
    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _email;
        private int _edad;
        private string _domicilio;

        public Usuario()
        {
            _nombre = "Luis";
            _apellido = "Perez";
            _dni = 4567432;
            _email = "LuisP@gmail.com";
            _edad = 30;
            _domicilio = "Calle falsa 123";
        }

        public string DondeVive()
        {
            return _domicilio;
        }

        public int GetDni()
        {
            return _dni;
        }

        public void SetNewDomicilio(string nuevoDomicilio)
        {
            if(nuevoDomicilio.Contains("Una muy mala palabra") is false)
            {
                _domicilio = nuevoDomicilio;
            }
        }
    }

    class ProbarObjetos
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();

            Console.WriteLine(user.DondeVive());
            Console.WriteLine(user.GetDni());

            user.SetNewDomicilio("Otro nuevo domicilio 123");

            Console.WriteLine(user.DondeVive());
        }
    }
}
*/

//Mi Ejemplo crear usuarios
/*
namespace MiclasedeEjemplo
{
    //Acá hacemos la ejecución
    class ProbarObjeto
    {
        static void Main(string[] args)
        {
            Usuario usr = new Usuario();
            Console.WriteLine("El DNI es: " + usr.GetDNI());
            Console.WriteLine("Get del domicilio: " + usr.GetDomicilio());
            usr.SetNewDomicilio("Set del domicilio: " + "No es la Falsa 321");
            Console.WriteLine(usr.GetDomicilio());
        }
    }

    public class Usuario
    {
        private string _nombre;
        private string _apellido;
        private int _dni;
        private string _email;
        private int _edad;
        private string _domicilio;

        /*
        //Ctrl + "." y aparece el martillo, elegir los atributos y crea el constructor solo
        public Usuario(string nombre, string apellido, int dni, string email, int edad, string domicilio)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;
            this._email = email;
            this._edad = edad;
            this._domicilio = domicilio;
        }

        public Usuario()
        {
            _nombre = "Luis";
            _apellido = "Perez";
            _dni = 30830906;
            _email = "luis.perez@gmail.com";
            _edad = 30;
            _domicilio = "Calle Falsa 123";
        }

        //Definimos algunos métodos como ejemplo (2 Get y 1 Set)
        public string GetDomicilio()
        {
            return _domicilio;
        }
        public int GetDNI()
        {
            return _dni;
        }
        public void SetNewDomicilio(string nuevo_domicilio)
        {
            _domicilio = nuevo_domicilio;
        }



    }
}
*/

/* Ejercicio Mica - Crear dos clases:
Clase Auto con propiedades: CantidadRuedas, Modelo, Marca, Año
Clase Moto con propiedades: CantidadRuedas, Modelo, Marca, Año, Cilindrada
Requisitos extras:
    Ambas clases deben tener una función para ObtenerDescripcion, donde se devuelva un string contando estas propiedades que contienen
    Por cuestiones organizativas, modelo y marca siempre deben estar formateadas en mayúscula (a ver como resuelven este!! recuerden lo que vimos de getters y setters :P)
Crear 2 o 3 instancias de cada clase creada, mostrar la descripción por consola.


namespace EjercicioMica
{
    //Main
    class InstanciadorClase
    {
        static void Main(string[] args)
        {
            //Objetos de la clase Auto
            Auto Auto1 = new Auto(4,"focus","ford",2010);
            Auto Auto2 = new Auto(3, "PeuGeot", "208", 2021);
            Auto Auto3 = new Auto(5, "Toyota", "eTios", 2005);
            
            //Imprime por pantalla usando el método GetDescripcion
            Console.WriteLine("< Objeto: Auto >\n");
            Console.WriteLine(Auto1.GetDescripcionAuto());
            Console.WriteLine(Auto2.GetDescripcionAuto());
            Console.WriteLine(Auto3.GetDescripcionAuto());

            //Objetos de la clase Moto
            Moto Moto1 = new Moto(30, "Honda", "TorNado", 2022, "250cc");
            Moto Moto2 = new Moto(30, "Zanella", "comun", 1995, "50cc");
            Moto Moto3 = new Moto(30, "BMW", "Z1200", 2020, "1200cc");

            //Imprime por pantalla usando el método GetDescripcion
            Console.WriteLine("\n< Objeto: Motos >\n");
            Console.WriteLine(Moto1.GetDescripcionMoto());
            Console.WriteLine(Moto2.GetDescripcionMoto());
            Console.WriteLine(Moto3.GetDescripcionMoto());
        }
    }
    //Clase Auto
    public class Auto
    {
        //Definición Atributos de la clase Auto
        private int _Cant_Ruedas;
        private string _Modelo;
        private string _Marca;
        private int _Anio;

        //Seteo de los atributos de la clase
        public Auto(int cant_Ruedas, string modelo, string marca, int anio)
        {
            _Cant_Ruedas = cant_Ruedas;
            _Modelo = modelo.ToUpper();
            _Marca = marca.ToUpper();
            _Anio = anio;
        }
        
        //Método para retornar descripción
        public string GetDescripcionAuto()
        {
            return ("Marca: " + _Marca + " - " + "Modelo: " + _Modelo + " - " + "Cant.Ruedas: " + _Cant_Ruedas + " - " + "Año: " + _Anio);
        }
    }

    //Clase Moto
    public class Moto
    {
        //Definición Atributos de la clase Auto
        private int _Cant_Ruedas;
        private string _Modelo;
        private string _Marca;
        private int _Anio;
        private string _Cilindrada;

        //Seteo de los atributos de la clase
        public Moto(int cant_Ruedas, string modelo, string marca, int anio, string cilindrada)
        {
            _Cant_Ruedas = cant_Ruedas;
            _Modelo = modelo.ToUpper();
            _Marca = marca.ToUpper();
            _Anio = anio;
            _Cilindrada = cilindrada;
        }

        //Método para retornar descripción
        public string GetDescripcionMoto()
        {
            return ("Marca: " + _Marca + " - " + "Modelo: " + _Modelo + " - " + "Cant.Ruedas: " + _Cant_Ruedas + " - " + "Año: " + _Anio + " - " + "Cilindrada: " + _Cilindrada);
        }
    }

}
*/


// Mismo ejemplo que el anterior sólo que uso una única clase vehículo para los 2 y con un atributo adicional las diferencio
/*
namespace EjercicioMica
{
    //Main
    class InstanciadorClase
    {
        static void Main(string[] args)
        {
            //Objetos de la Clase Vehículo (Autos)
            Vehiculo Auto1 = new Vehiculo(4, "focus", "ford", 2010, "N/A", 'A');
            Vehiculo Auto2 = new Vehiculo(3, "PeuGeot", "208", 2021, "N/A", 'A');
            Vehiculo Auto3 = new Vehiculo(5, "Toyota", "eTios", 2005, "N/A", 'A');

            //Imprime por pantalla usando el método GetDescripcion
            Console.WriteLine("< Objeto: Auto >\n");
            Console.WriteLine(Auto1.GetDescripcionVehiculo());
            Console.WriteLine(Auto2.GetDescripcionVehiculo());
            Console.WriteLine(Auto3.GetDescripcionVehiculo());

            //Objetos de la Clase Vehículo (Motos)
            Vehiculo Moto1 = new Vehiculo(30, "Honda", "TorNado", 2022, "250cc", 'M');
            Vehiculo Moto2 = new Vehiculo(30, "Zanella", "comun", 1995, "50cc", 'M');
            Vehiculo Moto3 = new Vehiculo(30, "BMW", "Z1200", 2020, "1200cc", 'M');

            //Imprime por pantalla usando el método GetDescripcion
            Console.WriteLine("\n< Objeto: Motos >\n");
            Console.WriteLine(Moto1.GetDescripcionVehiculo());
            Console.WriteLine(Moto2.GetDescripcionVehiculo());
            Console.WriteLine(Moto3.GetDescripcionVehiculo());

        }
    }

    //Clase Vehículo
    public class Vehiculo
    {
        //Definición Atributos de la clase Auto
        private int _Cant_Ruedas;
        private string _Modelo;
        private string _Marca;
        private int _Anio;
        private string _Cilindrada;
        private char _TipoVeh;

        //Seteo de los atributos de la clase
        public Vehiculo(int cant_Ruedas, string modelo, string marca, int anio, string cilindrada, char tipo)
        {
            _Cant_Ruedas = cant_Ruedas;
            _Modelo = modelo.ToUpper();
            _Marca = marca.ToUpper();
            _Anio = anio;
            _Cilindrada = cilindrada;
            _TipoVeh = tipo;
        }

        //Método para retornar descripción
        public string GetDescripcionVehiculo()
        {
            if (_TipoVeh == 'A')
            {
                return ("Marca: " + _Marca + " - " + "Modelo: " + _Modelo + " - " + "Cant.Ruedas: " + _Cant_Ruedas + " - " + "Año: " + _Anio);
            }
            else
            {
                return ("Marca: " + _Marca + " - " + "Modelo: " + _Modelo + " - " + "Cant.Ruedas: " + _Cant_Ruedas + " - " + "Año: " + _Anio + " - " + "Cilindrada: " + _Cilindrada);
            }

        }
    }
}
*/

/*
 *****************************************************************************************************
 *                                     CLASE 6: CLASES Y HERENCIA - MIÉRCOLES 13/07
 *****************************************************************************************************
*/

/*
namespace Clase6
{
    class Principal
    { 
    static void Main(string[] args)
        {
            Empleado ob_empleado = new Empleado("Pepe", 12345, "Juan Coder", "Re Lejos 123");
            Estudiante ob_estudiante = new Estudiante("Backend", 12345, "Juan", "Cualquiera");
            Persona persona = new Persona(54321, "Angel", "MiDire");

            //Opción 1:
            //persona.MostrarDatos();
            
            //Opción 2:
            //ob_estudiante.MostrarDatos();
            
            //Opción 3:
            ob_empleado.MostrarDatos();
        }
    }
    public class Persona
    {
        protected long dni;
        protected string nombre;
        protected string domicilioParticular;

        //Constructor vacío para inicializar
        public Persona()
        {
            this.dni = 0;
            this.nombre = String.Empty;
            this.domicilioParticular = String.Empty;
        }

        //Constructor con parámetros para setear valores
        public Persona(long dni, string nombre, string domicilioParticular)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.domicilioParticular = domicilioParticular;
        }

        //Metodo que se puede heredar y modificar más adelante (es clave que tenga el virtual)
        public virtual void MostrarDatos()
        {
            Console.WriteLine("DNI: " + dni + "Nombre: " + nombre + "Domicilio Particular: " + domicilioParticular);
        }
    }

    //Clase Empleado que hereda Persona
    class Empleado : Persona
    {
        protected string legajo;
    
        //Nuevo Constructor pero hay que referenciar al padre
        public Empleado(string legajo, long dni, string nombre, string domicilio) : base(dni, nombre, domicilio) //Ctr Shft Espacio
        {
            this.legajo = legajo;
        }

        //Vamos a usar el MostrarDatos de Persona pero lo vamos a alterar
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Legajo: " + legajo);
        }
    }

    class Estudiante : Persona
    {
        protected string carrera;

        public Estudiante(string carrera, long dni, string nombre, string domicilio) : base (dni, nombre, domicilio)
        {
            this.carrera = carrera;
        }
    }
}
*/

//System.Object es lo que heredan todos los tipos de datos en C#, son virtuales y se pueden sobreescribir
/*
namespace Clase6
{
    class Principal
    {
        static void Main(string[] args)
        {
            Empleado ob_empleado = new Empleado("Pepe", 12345, "Juan Coder", "Re Lejos 123");
            Estudiante ob_estudiante = new Estudiante("Backend", 12345, "Juan", "Cualquiera");
            Persona persona = new Persona(54321, "Angel", "MiDire");
            
            //Opción 1:
            //persona.MostrarDatos();

            //Opción 2:
            //ob_estudiante.MostrarDatos();

            //Opción 3:
            ob_empleado.MostrarDatos();

            //Console.WriteLine(persona.Telefono...); No funciona!!!

        }
    }
    
    //INTERFACE: SÓLO PUEDE TENER LA DEFINICIÓN DE UN MÉTODO
    public interface IEstudiante
    {
        long DevolverDNI();
    }

    public interface IID
    {
        int ID { get; set; }
    }

    public class Persona
    {
        protected long dni;
        protected string nombre;
        protected string domicilioParticular;

        //Constructor vacío para inicializar
        public Persona()
        {
            this.dni = 0;
            this.nombre = String.Empty;
            this.domicilioParticular = String.Empty;
        }

        //Constructor con parámetros para setear valores
        public Persona(long dni, string nombre, string domicilioParticular)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.domicilioParticular = domicilioParticular;
        }

        //Metodo que se puede heredar y modificar más adelante (es clave que tenga el virtual)
        public virtual void MostrarDatos()
        {
            Console.WriteLine("DNI: " + dni + "Nombre: " + nombre + "Domicilio Particular: " + domicilioParticular);
        }

        //Esta es la parte de sobreescribir el método estándar Equals
        public override bool Equals(object? obj)
        {
            if (obj == null)
            {
                return false;
            }
            
            Persona persona = (Persona)obj;
            return this.dni == persona.dni;
        }

        //Static quiere decir que es un método que no se va a poder modificar
        public static string TelefonosDeEmergencia()
        {
            return "911 - Emergencias";
        }
    }

    //Clase Empleado que hereda Persona
    class Empleado : Persona
    {
        protected string legajo;

        //Nuevo Constructor pero hay que referenciar al padre
        public Empleado(string legajo, long dni, string nombre, string domicilio) : base(dni, nombre, domicilio) //Ctr Shft Espacio
        {
            this.legajo = legajo;
        }

        //Vamos a usar el MostrarDatos de Persona pero lo vamos a alterar
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Legajo: " + legajo);
        }

    }

    class Estudiante : Persona, IEstudiante
    {
        protected string carrera;

        public Estudiante(string carrera, long dni, string nombre, string domicilio) : base(dni, nombre, domicilio)
        {
            this.carrera = carrera;
        }
        //Static quiere decir que es un método que no se va a poder modificar
        public static string TelefonosDeEmergencia()
        {
            return "911 - Emergencias";
        }

        public long DevolverDNI()
        {
            return dni;
        }
    }
}
*/

/*
namespace Clase6
{
    class Principal
    {
        static void Main(string[] args)
        {

        }
    }


    public interface I2DMedidasCalculable
    {
        double Area();
        double Perimetro();
    }

    public interface I3DMedidasCalculable
    {
        double Volumen();
    }

    public class Circulo : I2DMedidasCalculable
    {
        double radio;
    }
        
    public Circulo(double radio)
    {
        this.radio = radio;
    }

        public double Area()
        {
            return Math.PI * Math.Pow(this.radio, 2);
        }
    
        public double Perimetro()
        {
            return Math.PI * this.radio * 2;
        }


    public class Rectangulo : I2DMedidasCalculable
    {
        double base_r;
        double altura_r;

        public Rectangulo(double base_r, double altura_r)
        {
            this.base_r = base_r;
            this.altura_r = altura_r;
        }
    }
}

/*

/*
 *****************************************************************************************************
 *                                     CLASE 7: ARRAYS - LUNES 18/07
 *****************************************************************************************************
*/

/*
class ProbarObjeto
{
    static void Main(string[] args)
    {
        string[] razadeperros = new string[5];

        razadeperros[0] = "Bulldog";
        razadeperros[1] = "Pequines";
        razadeperros[2] = "Pastor";
        razadeperros[3] = "Salchicha";
        razadeperros[4] = "Caniche";

        for (int i = 0; i < razadeperros.Length; i++)
        {
            string mostrar_perro = razadeperros[i];
            Console.WriteLine(mostrar_perro);
        }
    }
}
*/
/*
class ProbarObjeto
{
    static void Main(string[] args)
    {
        string[] razadeperros = { "Bulldog", "Pequines", "Pastor", "Salchicha", "Caniche" };

        for (int i = 0; i < razadeperros.Length; i++)
        {
            string mostrar_perro = razadeperros[i];
            Console.WriteLine(mostrar_perro);
        }
    }
}
*/

/*
class ProbarObjeto
{
    static void Main(string[] args)
    {
        Producto[] bebidasGaseosas = {
                new Producto(1,"Coca-cola", 23, 32, "Gaseosa"),
                new Producto(2,"7UP", 26, 31, "Gaseosa"),
                new Producto(3,"Manaos-cola", 24, 17, "Gaseosa"),
                new Producto(4,"Paso de los toros", 25, 30, "Gaseosa"),
            };
        
        Producto bebidaMasCara = new Producto();

        foreach (Producto bebida in bebidasGaseosas)
        {
            if (bebida.PrecioDeCompra > bebidaMasCara.PrecioDeCompra)
            {
                bebidaMasCara = bebida;
            }
        }

        Console.WriteLine("La bebida comprada mas cara es:{0}", bebidaMasCara.Descripcion);
    }
    
    public class Producto
    {
        // sin getters o setters
        public int Codigo;
        public string Descripcion;
        public double PrecioDeCompra;
        public double PrecioDeVenta;
        public string Categoria;

        public Producto()
        {
            Codigo = 0;
            Descripcion = String.Empty;
            PrecioDeCompra = 0;
            PrecioDeVenta = 0;
            Categoria = String.Empty;
        }
        public Producto(int codigo, string descripcion, double precioDeCompra, double precioDeVenta, string categoria)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            PrecioDeCompra = precioDeCompra;
            PrecioDeVenta = precioDeVenta;
            Categoria = categoria;
        }
    }
}
*/
/*
namespace EjemploDiccionario
{
    class ProbarObjeto
    {
        static void Main(string[] args)
        {
        //Ejemplo de diccionario
        Dictionary<string, string> CiudadesXPaises = new Dictionary<string, string>();
        
            CiudadesXPaises.Add("Bogotá", "Colombia");
            CiudadesXPaises.Add("Buenos Aires", "Argentina");
            CiudadesXPaises.Add("Lima", "Bolivia");
            CiudadesXPaises.Add("Asunción", "Paraguay");

            Console.WriteLine("Las Ciudades por País son: ");

            foreach (KeyValuePair<string, string> ItemCiudad in CiudadesXPaises)
            {
                Console.WriteLine("{0} - {1}", ItemCiudad.Key, ItemCiudad.Value);
            }

            CiudadesXPaises.Remove("Buenos Aires");
            CiudadesXPaises["Lima"] = "Perú";

            Console.WriteLine("\nLas Ciudades por País después del cambio de propiedades: ");

            foreach (KeyValuePair<string, string> ItemCiudad in CiudadesXPaises)
            {
                Console.WriteLine("{0} - {1}", ItemCiudad.Key, ItemCiudad.Value);
            }

        }
    }
}
*/
/*
namespace EjemploDiccionario
{
    class ProbarObjeto
    {
        static void Main(string[] args)
        {
            //Ejemplo de diccionario
            Dictionary<string, string> CiudadesXPaises = new Dictionary<string, string>();

            CiudadesXPaises.Add("Bogotá", "Colombia");
            CiudadesXPaises.Add("Buenos Aires", "Argentina");
            CiudadesXPaises.Add("Lima", "Perú");
            CiudadesXPaises.Add("Asunción", "Paraguay");

            if (CiudadesXPaises.ContainsKey("Lima"))
            {
                //string pais = CiudadesXPaises["Lima"];
                CiudadesXPaises.TryGetValue("Lima", out string pais); //Para manejar la excepción si no encontrara la clave
                Console.WriteLine(pais);
            }
        }
    }
}
*/
/*
namespace EjemploDiccionario
{
    class ProbarObjeto
    {
        static void Main(string[] args)
        {
            //Ejemplo de diccionario
            Dictionary<string, string> CiudadesXPaises = new Dictionary<string, string>();

            CiudadesXPaises.Add("Bogotá", "Colombia");
            CiudadesXPaises.Add("Buenos Aires", "Argentina");
            CiudadesXPaises.Add("Lima", "Bolivia");
            CiudadesXPaises.Add("Asunción", "Paraguay");

            Console.WriteLine("Las Ciudades por País antes del cambio de propiedades: ");

            foreach (KeyValuePair<string, string> ItemCiudad in CiudadesXPaises)
            {
                Console.WriteLine("{0} - {1}", ItemCiudad.Key, ItemCiudad.Value);
            }

            CiudadesXPaises.Remove("Buenos Aires");
            CiudadesXPaises["Lima"] = "Perú";

            CiudadesXPaises.Clear(); //Borra todo el contenido

            Console.WriteLine("\nLas Ciudades por País después del cambio de propiedades: ");

            foreach (KeyValuePair<string, string> ItemCiudad in CiudadesXPaises)
            {
                Console.WriteLine("{0} - {1}", ItemCiudad.Key, ItemCiudad.Value);
            }

        }
    }
}
*/
/*
namespace EjercicioIntegrador
{
    class ProbarObjeto
    {
        static void Main(string[] args)
        {
            //Diccionario dentro de otro diccionario
            Dictionary<string, Dictionary<string, double>> CatalogoPetShop = new Dictionary<string, Dictionary<string, double>>();

            //Inicializamos el diccionario
            CatalogoPetShop.Add("Alimentos Gatos Adultos", new Dictionary<string, double>
            {
                {"Catchow  ", 90 },
                {"Whiskas  ", 85 },
                {"Pedigree ", 95 },
            });
            CatalogoPetShop.Add("Alimentos Gatos Cachorros", new Dictionary<string, double>
            {
                {"Catchow  ", 88 },
                {"Whiskas  ", 83 },
                {"Pedigree ", 93 },
            });
            CatalogoPetShop.Add("Alimentos Perros Adultos", new Dictionary<string, double>
            {
                {"Dodchow  ", 97 },
                {"ProPlan  ", 87 },
                {"Pedigree ", 84 },
            });
            CatalogoPetShop.Add("Alimentos Perros Cachorros", new Dictionary<string, double>
            {
                {"Dodchow  ", 70 },
                {"ProPlan  ", 71 },
                {"Pedigree ", 72 },
            });

            Console.WriteLine("Sección\t\t\t\t\tProducto\t\tPrecio");
            
            foreach (KeyValuePair<string, Dictionary<string, double>> seccion in CatalogoPetShop)
            {
                Console.WriteLine("{0}", seccion.Key);

                foreach (KeyValuePair<string, double> productoYprecio in seccion.Value)
                {
                    Console.WriteLine("\t\t\t\t\t{0}\t\t{1}", productoYprecio.Key, productoYprecio.Value);
                }
            }
        }
    }
}
*/

/*
namespace BloqueTryCatch
{
    class ProbarObjeto
    {
        static void Main(string[] args)
        {
            try
            {
                int numero = Convert.ToInt32(Console.ReadLine());
                decimal division = 25 / numero;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            //Si activa el primer Catch, sigue ejecutando desde aquí
            int fueraDelTry = Convert.ToInt32(Console.ReadLine());
            decimal divisionFueradelTry = 25 / fueraDelTry;
            Console.WriteLine(divisionFueradelTry);
        }
    }
}
*/

/*
namespace UltimoejercicioIntegrador
{
    class ProbarObjeto
    {
        static void Main(string[] args)
        {
            //Diccionario dentro de otro diccionario
            Dictionary<string, Dictionary<string, double>> MenuPorSecciones = new Dictionary<string, Dictionary<string, double>>();

            //Inicializamos el diccionario
            MenuPorSecciones.Add("Bebidas Sin Alcohol", new Dictionary<string, double>
            {
                {"Jugos    ", 10.45 },
                {"Gaseosas ", 10.55 },
                {"Agua     ", 95 },
            });
            MenuPorSecciones.Add("Bebidas Con Alcohol", new Dictionary<string, double>
            {
                {"Dahikiri ", 91 },
                {"Vino     ", 86 },
                {"Cerveza  ", 96 },
            });

            Console.WriteLine("Sección\t\t\t\t\tProducto\t\tPrecio");

            foreach (KeyValuePair<string, Dictionary<string, double>> seccion in MenuPorSecciones)
            {
                Console.WriteLine("{0}", seccion.Key);

                foreach (KeyValuePair<string, double> productoYprecio in seccion.Value)
                {
                    Console.WriteLine("\t\t\t\t\t{0}\t\t{1}", productoYprecio.Key.ToUpper(), productoYprecio.Value);
                }
            }   
        }       
    }
}
*/

/*
 *****************************************************************************************************
 *                                     CLASE 8: LISTA Y MATRICES AVANZADO - MIÉRCOLES 20/07
 *****************************************************************************************************
*/

/*
namespace EjemploListas
{
    class ProbarObjeto
    {
        static void Main(string[] args)
        {
            //Definición de Lista
            List<string> nombres = new List<string> { "Juan", "Pedro", "Luis", "Michael", "Jordan" };
            
            //Mismo concepto pero usando un Array
            string[] array_nombres = new string[] { "Juan", "Pedro", "Luis" };

            //Métodos para las Listas
            nombres.Add("Guillermo");
            nombres.Remove("Luis"); //Si no encuentra el valor no falla, no hace nada
            int indice = nombres.IndexOf("Guillermo");
            string[] myarray = nombres.ToArray();
            int cuenta = nombres.Count;

            foreach (var item in nombres)
            {
                Console.WriteLine(item.ToUpper());
            }
            Console.WriteLine("Guillermo está en la posición: {0}", indice);
            Console.WriteLine("La lista tiene tantas líneas: {0}", cuenta);
        }
    }
}
*/

/*
namespace EjemploListas
{
    class ProbarObjeto
    {
        static void Main(string[] args)
        {
            ListasMayores mayores = new ListasMayores();
            Cliente[] Array_Clientes =
            {
                new Cliente("Juan Perez", "Lavalleja 345", 0001, 34),
                new Cliente("Miguel Soto", "EEUU 900", 0002, 43),
                new Cliente("Pedro Picapiedra", "China 1200", 0003, 54),
                new Cliente("Michael Jordan", "Rusia 2500", 0004, 19),
                new Cliente("Camila Yane", "Ayacucho 120", 0005, 28)
            };

            //Mover el Array a la Lista
            mayores._ClientesMayores.AddRange(Array_Clientes);

            foreach (var cliente in mayores._ClientesMayores)
            {
                Console.WriteLine($"Nombre: {cliente.Nombre} - ID: {cliente.ID} - Dirección: {cliente.Direccion} - Edad: {cliente.Edad}");
            }

        }
    }
    public class Cliente
    {
        public string Nombre;
        public string Direccion;
        public long ID;
        public short Edad;

        public Cliente(string nombre, string direccion, long id, short edad)
        {
            Nombre = nombre;
            Direccion = direccion;
            ID = id;
            Edad = edad;
        }
    }
    public class ListasMayores
    {
        public List<Cliente> _ClientesMayores;

        public ListasMayores()
        {
            _ClientesMayores = new List<Cliente>();
        }
    }
} 
*/
/*
namespace EjemploListas
{
    class ProbarObjeto
    {
        static void Main(string[] args)
        {
            ListasMayores mayores = new ListasMayores();
            Cliente[] Array_Clientes =
            {
                new Cliente("Juan Perez", "Lavalleja 345", 0001, 34),
                new Cliente("Miguel Soto", "EEUU 900", 0002, 43),
                new Cliente("Pedro Picapiedra", "China 1200", 0003, 54),
                new Cliente("Michael Jordan", "Rusia 2500", 0004, 19),
                new Cliente("Camila Yane", "Ayacucho 120", 0005, 28)
            };

            mayores.InsertarEnLista(Array_Clientes);
            Console.WriteLine("\nPrimera versión Lista...");
            mayores.MostrarLista();

            Cliente ClienteABorrar = Array_Clientes.FirstOrDefault(f => f.Nombre == "Pedro Picapiedra");
            mayores.BorrarClientes(ClienteABorrar);
            Console.WriteLine("\nLista Actualizada...");
            mayores.MostrarLista();
        }
    }
    public class Cliente
    {
        public string Nombre;
        public string Direccion;
        public long ID;
        public short Edad;

        public Cliente(string nombre, string direccion, long id, short edad)
        {
            Nombre = nombre;
            Direccion = direccion;
            ID = id;
            Edad = edad;
        }
    }
    public class ListasMayores
    {
        public List<Cliente> _ClientesMayores;

        public ListasMayores()
        {
            _ClientesMayores = new List<Cliente>();
        }

        //Método para Insertar clientes en vez de usar el AddRange
        public void InsertarEnLista(Cliente[] Clients)
        {
            Console.WriteLine($"Insertando en Lista: {Clients.Length} clientes");

            foreach (var item in Clients)
            {
                _ClientesMayores.Add(item);
            }
        }

        //Método para Borrar Clientes
        public bool BorrarClientes(Cliente Client)
        {
            bool seBorroCliente = false;

            if (_ClientesMayores.Contains(Client))
            {
                seBorroCliente = _ClientesMayores.Remove(Client);
            }
            return seBorroCliente;
        }

        //Método para Mostrar Lista
        public void MostrarLista()
        {
            foreach (var cliente in _ClientesMayores)
            {
                Console.WriteLine($"Nombre: {cliente.Nombre} - ID: {cliente.ID} - Dirección: {cliente.Direccion} - Edad: {cliente.Edad}");
            }
        }
    }
}
*/
/*
namespace ProductosconE
{
    class ProbarObjeto
    {
        static void Main(string[] args)
        {
            ProductoconE misproductosconE = new ProductoconE();
            Producto[] misproductos =
            {
                new Producto(1, "Yogurt Descremado"),
                new Producto(3, "Leche"),
                new Producto(2, "Huevos"),
                new Producto(8, "Vino"),
                new Producto(5, "Sal"),
                new Producto(6, "Estufa"),
            };

            misproductosconE.InsertarProductosConE(misproductos);
            misproductosconE.MostrarLista();
            misproductosconE.LimpiarLista();
            misproductosconE.MostrarLista();
        }
    }

    public class Producto
    {
        public int Codigo { get; set; } 
        
        public string Descripcion { get; set; }
        
        public Producto(int codigo, string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }
    }

    public class ProductoconE
    {
        private List<Producto> _productosconE;
        
        public ProductoconE()
        {
            _productosconE = new List<Producto>();
        }
        
        public void InsertarProductosConE(Producto[] array_productos)
        {
            for (int i = 0; i < array_productos.Length; i++)
            {
                Producto producto = array_productos[i];
                
                if (producto.Descripcion.ToUpper().Contains("E"))
                {
                    _productosconE.Add(producto);
                }
            }
        }

        public void MostrarLista()
        {
            if (_productosconE.Count == 0)
            {
                Console.WriteLine("\nNo hay productos con E");
            }
            else
            {
                Console.WriteLine("\nProductos con E:");
                foreach (var item in _productosconE)
                {
                    Console.WriteLine($"Código: {item.Codigo} - Descripción: {item.Descripcion}");
                }
            }
        }

        public void LimpiarLista()
        {
            _productosconE.Clear();
            Console.WriteLine("\nLa lista se ha limpiado");
        }
    }
}
*/

/*
 *****************************************************************************************************
 *                                     CLASE 9: PROYECTOS GIT - LUNES 25/07
 *****************************************************************************************************
*/

