using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BmiApp
{
    public class Person
    {
        private int _personId;
        private string _personName;
        private int _personAge;
        private double _personHeight;
        private double _personWeight;
        public const double DEFAULT_WEIGHT = 50;
        public const double DEFUALT_HEIGHT = 5;
        public const double TO_METER = 0.3048;


        public Person(int personId, string personName, int personAge) 
            : this(personId, personName, personAge , DEFUALT_HEIGHT, DEFAULT_WEIGHT)
        { 
        }
        public Person(int personId, string personName, int personAge, double personHeight, double personWeight) 
        {
            _personId = personId;
            _personName = personName;
            _personAge = personAge;
            _personHeight = TO_METER * personHeight;
            _personWeight = personWeight;
        }

        public String CalculateBmiCriteria()
        {
            double bmi = CalculateBmi();
            string bmiCriteria = "";
            if (bmi <= 18.5) { bmiCriteria = "Under Weight"; }
            if (bmi > 18.5 && bmi <= 24.9) { bmiCriteria = "Normal Weight"; }
            if (bmi >= 25 && bmi <= 29.9) { bmiCriteria = "Over Weight"; }
            if (bmi >= 30) { bmiCriteria = "Obese "; }
            return $"The Bmi of {_personName} is {bmi} and the person is {bmiCriteria}";
        }
        public double CalculateBmi()
        {
            double bmi = _personWeight / (_personHeight * _personHeight);
            return bmi;
        }

        public string PrintDetails()
        {
            return $"The id of person is {_personId}" +
                $"\nThe Name of person is {_personName}" +
                $"\nThe Age of person is {_personAge}" +
                $"\nThe Height of Person is {_personHeight}" +
                $"\nThe Weight of Person is {_personWeight}";
        }
    }
}
