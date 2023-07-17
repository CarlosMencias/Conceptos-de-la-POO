using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public
        class Date
    {
            
        public int _year;
        public int _month;
        public int _day;


        public Date()
        {
            _year = 1990;
            _month = 1;
            _day = 1;
        }
        public Date(int year, int month, int day)
        {
            _year = ValidateYear(year);
            _month = Validatemonth(month);
            _day = ValidateDay(day);

        }



        public int Yaer
        {
            get => _year;
            set => _year = ValidateYear(value);
        }
        public int Month
        {
            get => _month;
            set => _month = Validatemonth(value);
        }
        public int Day
        {
            get => _day;
            set => _day = ValidateDay(value);
        }


        public override string ToString()
        {
            return $"{Yaer,4:000}/{Month,2:00}/{Day,2:00}";
        }

        private int ValidateYear(int year)
        {
            if (year < 0)
            {
                throw new ArgumentException("Año no valido");
            }
            return year;
        }

        private int Validatemonth(int month)
        {
            if (month < 1 || month > 12)
            {
                throw new ArgumentException("Mes no valido");
            }
            return month;
        }

        private int ValidateDay(int day)
        {
            if (day == 29 && _month == 2 && IsLeapYear(_year))
            {
                return day;
            }
            if ((day >= 1 && day <= 28 && Month == 2) ||
                (day >= 1 && day <= 30 && Month == 4) || (day >= 1 && day <= 30 && Month == 6) ||
                (day >= 1 && day <= 30 && Month == 9) || (day >= 1 && day <= 30 && Month == 11) ||
                (day >= 1 && day <= 31 && Month == 1) || (day >= 1 && day <= 31 && Month == 3) ||
                (day >= 1 && day <= 31 && Month == 5) || (day >= 1 && day <= 31 && Month == 7) ||
                (day >= 1 && day <= 31 && Month == 8) || (day >= 1 && day <= 31 && Month == 10) ||
                (day >= 1 && day <= 31 && Month == 12))
            {
                return day;
            }

            throw new ArgumentException("Dia no valido");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
        }
    }
}

