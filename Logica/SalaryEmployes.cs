using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class SalaryEmployes : Employes
    {
        private decimal _salary;

        public decimal Salary { 
            get => _salary; 
            set => _salary = ValidateSalary(value);
        }

        

        public override decimal GetValueToPay()
        {
            return Salary * 0.9955m;
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t" +
                   $"Salary...................:{Salary, 20:C2}\n\t" +
                   $"Rol......................:{GetValueToPay(), 20:C2}";
        }

        private decimal ValidateSalary(decimal value)
        {
            if (value < 450)
            {
                throw new ArgumentException("Salario no valido");
            }
            return value;
        }
    }
}
