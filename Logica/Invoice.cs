using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Invoice : IPay
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public decimal Precie { get; set; }
        public float Quantity { get; set; }
        public decimal GetValueToPay()
        {
            return (decimal)Quantity * Precie;
        }

        public override string ToString()
        {
            return $"{Id}\n{Description}\n\t" +
                $"Quantity.................:{Quantity,20:N2}\n\t" +
                $"Precio...................:{Precie,20:N2}\n\t" +
                $"Valor pagar..............:{GetValueToPay(),20:C2}\n\t";               
        }
    }
}
