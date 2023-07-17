using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class HourEmployes : Employes
    {
        private decimal _hourValue;
        private float _workingHours;

        public decimal HourValue 
        { 
            get => _hourValue;
            set => _hourValue = ValidateHour(value);
        }

        public float WorkingValue
        {
            get => _workingHours;
            set => _workingHours = ValidateWorkingHourValue(value);
        }

        

        public override decimal GetValueToPay()
        {
            float iva = 0.88f;

            return (decimal)WorkingValue * HourValue * (decimal)iva;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                $"HourValue................:{HourValue, 20:C2}\n\t" +
                $"WorkingHours.............:{WorkingValue, 20:C2}\n\t" +
                $"Rol......................:{GetValueToPay(), 20:C2}";
        }

        private decimal ValidateHour(decimal value)
        {
            if (value < 7 || value > 15 ) 
            {
                throw new ArgumentOutOfRangeException("Valor no valido");
            }
            return value;
        }
        private float ValidateWorkingHourValue(float value)
        {
            if (value < 0 || value > 40) 
            {
                throw new ArgumentException("Las horas trabajadas no son validas");
            }
            return value;
        }
    }
}
