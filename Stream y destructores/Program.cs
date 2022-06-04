using System;
using System.IO; //contiene tipos qie permiten leer y escribir archivos y flujo de datos, y que proportcionan compatibilidad basica con archivos y directorios
// using llama a los recurso no administrados de una interfaz llamada IDisposable que hace lo de atras
// tambien llama a otra llamada IAsyncDisposable que hace lo mismo de forma asincrona
namespace Stream_y_destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos miArchivo = new ManejoArchivos();

            miArchivo.mesaje();
            
        }
    }
    class ManejoArchivos
    {
        StreamReader archivo = null; //Lee un flujo secuencial de datos

        int contador = 0;

        string linea;

        public ManejoArchivos()
        {
            archivo = new StreamReader(@"C:\texto.txt"); //se le dice al streamReader que leer

            while ((linea = archivo.ReadLine()) != null) //Lee cada parte mientras haya linea
            {
                Console.WriteLine(linea);

                contador++;
            }

        }
        //Este metodo solo dice las lineas
        public void mesaje()
        {
            Console.WriteLine("hay {0} lineas", contador);
        }
        //El destructor se pone el  alt+126 que es ~ en el nombre del constructor, cierra el flujo
        ~ManejoArchivos()
        {
            archivo.Close();
        }
    }
}
