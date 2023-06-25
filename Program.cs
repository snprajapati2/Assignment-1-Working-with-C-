using Assignment1;
using System;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter patient's age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter patient's first name:");
            string firstName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter patient's last name:");
            string lastName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter patient's weight in kg:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter patient's height in centimeters:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("========== Patient Information ==========");
            Patient patient = new Patient(firstName, lastName, weight, height);
            patient.InformationPrint ();
            Console.WriteLine("=========================================");
            Console.WriteLine();

            Console.WriteLine("Enter patient's SYSTOLIC (upper number) blood pressure:");
            int systolic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter patient's DIASTOLIC (lower number) blood pressure:");
            int diastolic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            string bloodPressureMessage = patient.BloodPressureCalculator(systolic, diastolic);
            Console.WriteLine("Blood Pressure: " + bloodPressureMessage);
            Console.WriteLine();

            double bmi = patient.BMICalculator ();
            string bmiCategory = patient.GetBMICategory(bmi);

            Console.WriteLine("BMI: " + Math.Round(bmi, 2));
            Console.WriteLine("BMI Category: " + bmiCategory);

            Console.ReadLine();
        }
    }
}
