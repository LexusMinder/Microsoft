using System;
using System.Collections.Generic;
using System.Text;

namespace MiBanco
{
    public class CuentaBancaria // Inicio de clase CuentaBancaria
    {
        public string Numero { get; } // atributo que almacena el numero de cuenta
        public string Titular { get; } // atributo que almacena el nombre del titular 
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in todasTransacciones)
                {
                    balance += item.cantidad;
                }
                return balance;
            }
        } // atributo que almacena el balance

        private static int accountNumberSeed = 1234567890;

        private List<Transacciones> todasTransacciones = new List<Transacciones>();


        public CuentaBancaria(string nombre, decimal balanceInicial) {//Constructor para la clase
            this.Titular = nombre;
            hacerDeposito(balanceInicial, DateTime.Now, "Balance Inicial");
            this.Numero = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void hacerDeposito(decimal cantidad, DateTime fecha, string nota)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(cantidad), "La cantidad del deposito debe ser positiva");
            }
            var deposito = new Transacciones(cantidad, fecha, nota);
            todasTransacciones.Add(deposito);
        }

        public void hacerRetiro(decimal cantidad, DateTime fecha, string nota)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(cantidad), "La cantidad del retiro debe ser positiva");
            }
            if (Balance - cantidad < 0)
            {
                throw new InvalidOperationException("Fondos insuficientes para retirar");

            }
            var retiro = new Transacciones(-cantidad, fecha, nota);
            todasTransacciones.Add(retiro);
        }

        public string obtenerHistorialCuenta()
        {
            var report = new StringBuilder();

            report.AppendLine("Fecha\t\tCantidad\tNota");
            
            //Headers
            foreach (var item in todasTransacciones)
            {
                //RAWS
                report.AppendLine($"{item.fecha.ToShortDateString()}\t{item.cantidad}\t\t{item.notas}");
            }
            return report.ToString();
        }
    }// Fin de la clase
}
