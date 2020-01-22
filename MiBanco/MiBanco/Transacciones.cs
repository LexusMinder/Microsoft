using System;
using System.Collections.Generic;
using System.Text;

namespace MiBanco
{
    public class Transacciones
    {
        public decimal cantidad { get; }
        public DateTime fecha { get; }
        public string notas { get; }

        public Transacciones(decimal cantidad, DateTime fecha, string nota)
        {
            this.cantidad = cantidad;
            this.fecha = fecha;
            this.notas = nota;
        }
    }
}
