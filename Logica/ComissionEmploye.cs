using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ComissionEmploye : Employes
    {  
        private float _comissionPercentaje;
        private decimal _sales;

        public decimal Sales
        {
            get => _sales;
            set => _sales = ValidateSales(value);
        }    

        public float ComissionPercentaje
        {
            get => _comissionPercentaje;
            set => _comissionPercentaje = ValidateComissionPercentaje(value);
        }

        public override decimal GetValueToPay()
        {
            return Sales * (decimal)ComissionPercentaje; //Empleados

        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"Sales....................:{Sales,20:C2}\n\t" +
                $"ComissionPorcentaje......:{ComissionPercentaje,20:P0}\n\t" +
                $"Rol......................:{GetValueToPay(),20:C2}";
        }

        private float ValidateComissionPercentaje(float value)
        {
            if (value > 0 && value <= 1) 
            {
                return value;              
            }
            throw new ArgumentException("Porcentaje no valido");

        }

        private decimal ValidateSales(decimal value)
        {
            if (value >= 0) 
            {
                return value;
            }
            throw new ArgumentException("Porcentaje no valido");
        }
    }
}
