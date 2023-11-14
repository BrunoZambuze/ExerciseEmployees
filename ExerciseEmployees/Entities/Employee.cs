using System;

namespace ExerciseEmployees.Entities
{
    internal class Employee
    {
        public string Name { get; protected set; }
        public int Hours { get; protected set; }
        public double ValuePerHour { get; protected set; }

        //Construtores
        public Employee()
        {
        }

        public Employee(string name, int hours, double valueperhour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valueperhour;
        }

        //Função para pagemento
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
