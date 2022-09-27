namespace App_de_consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese un numero del 1 al 10: ");
            Console.WriteLine("");

            string ingresado = Console.ReadLine();

            int numero = Convert.ToInt32(ingresado);


            //int numero = parseInt(ingresado);
            //var mensaje = "Ingresaste un " + numero;

            Console.WriteLine(numero * 2);
        }
    }
}