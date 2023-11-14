using System;

namespace ExerciseEmployees.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; protected set; }

        //Construtores
        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valueperhour, double additional) : base (name, hours, valueperhour)
        {
            AdditionalCharge = additional;
        }

        //Sobreposição pagamento
        public sealed override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }
    }
}
