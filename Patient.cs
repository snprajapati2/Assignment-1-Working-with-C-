using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;
        }

        public string BloodPressureCalculator(int systolic, int diastolic)
        {
            if (systolic < 120 && diastolic < 80)
            {
                return "Normal blood pressure";
            }
            else if (systolic >= 120 && systolic <= 129 && diastolic < 80)
            {
                return "Elevated blood pressure";
            }
            else if (systolic >= 130 && systolic <= 139 && diastolic >= 80 && diastolic <= 89)
            {
                return "High blood pressure stage 1";
            }
            else if (systolic >= 140 && diastolic >= 90)
            {
                return "High blood pressure stage 2";
            }
            else if (systolic > 180 && diastolic > 120)
            {
                return "Hypertensive crisis";
            }
            else
            {
                return "Invalid blood pressure values";
            }
        }

        public double BMICalculator()
        {
            double heightInMeter = Height / 100; // Convert height from centimeters to meters
            return Weight / (heightInMeter * heightInMeter);
        }

        public string GetBMICategory(double bmi)
        {
            if (bmi >= 25)
            {
                return "Overweight";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                return "Normal";
            }
            else
            {
                return "Underweight";
            }
        }

        public void InformationPrint()
        {
            Console.WriteLine("Full Name: " + FirstName + " " + LastName);
            Console.WriteLine("Weight: " + Weight + " kg");
            Console.WriteLine("Height: " + Height + " cm");
        }
    }

}
