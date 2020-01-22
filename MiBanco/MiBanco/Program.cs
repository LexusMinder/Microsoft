using System;

namespace MiBanco
{
    class Program
    {
        static void Main(string[] args)//Inicio del metodo main
        {
            var cuenta = new CuentaBancaria("Julio Mancha", 10500); // Se crea el objeto y se inicializan los valores
         
            //Se imprimen los valores de la cuenta anteriormente creada
            Console.WriteLine($"Hello World account {cuenta.Numero} for {cuenta.Titular} with {cuenta.Balance}");

            //Compra de unos headsets
            cuenta.hacerRetiro(120, DateTime.Now, "headsets");
            Console.WriteLine(cuenta.Balance);

            //Compra de un xbox
            cuenta.hacerRetiro(50, DateTime.Now, "Xbox Game");
            Console.WriteLine(cuenta.Balance);

            //Muestra el historial de transacciones
            Console.WriteLine(cuenta.obtenerHistorialCuenta());



            //cuenta.hacerDeposito(-300, DateTime.Now, "stealing");
    
            /*//test para el balance negativo
            try
            {
                cuenta.hacerRetiro(75000, DateTime.Now, "Attempt to overdraw");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception caught trying to overdraw");
                Console.WriteLine(e.ToString());
            }

            //Test que verifica que el balance inicial sea positivo
            try
            {
                var invalidAccount = new CuentaBancaria("invalid", -55555);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }*/
        }//Fin del metodo main
    }//Fin de la clase
}
