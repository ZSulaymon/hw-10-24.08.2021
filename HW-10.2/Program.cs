using System;

namespace HW_10._2
{

    class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }
        public double Tax { get; set; }
        public double PensionFund { get; set; }
        public int St { get; set; }

        public void CalculateSalary()
        {
            var tax = Salary * Tax;
            var pensF = (Salary - tax) * PensionFund;
            var clearSal = Salary - (tax + pensF);
            Console.WriteLine($"Имя:{Name}, Фамилия:{Surname},Должность:{Position},Стаж:{St},Оклад:{Salary},Налог(13+1):{tax + pensF},Чистая Зар-плата:{clearSal}");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            //var Emp = new Employee("firuz", "firuzof");
            //
            Employee Emp = new Employee();

            Emp.Name = "Sharif";
            Emp.Surname = "Sharifov";
            Emp.Surname = "Sharifov";
            Emp.Position = "Мастер";
            Emp.Salary = 2000;
            Emp.Tax = 0.13;
            Emp.PensionFund = 0.01;

            Console.WriteLine("Введите Имя");
            Emp.Name = Console.ReadLine();
            Console.WriteLine("Введите Фамилия");
            Emp.Surname = Console.ReadLine();
            Console.WriteLine("Введите Должность");
            Console.WriteLine("1: Специалист");
            Console.WriteLine("2: Менеджер");
            Console.WriteLine("3: Руководитель");
            var pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Стаж");
            Emp.St = Convert.ToInt32(Console.ReadLine());
            if (Emp.St >= 5)
            {
                Emp.Salary += Emp.Salary * 0.10;
            }
            if (Emp.St >= 10)
            {
                Emp.Salary += Emp.Salary * 0.15;
            }
            if (Emp.St >= 20)
            {
                Emp.Salary += Emp.Salary * 0.20;
            }
            if (Emp.St >= 30)
            {
                Emp.Salary += Emp.Salary * 0.30;
            }
            if (Emp.St >= 40)
            {
                Emp.Salary += Emp.Salary * 0.40;
            }
            if (Emp.St >= 50)
            {
                Emp.Salary += Emp.Salary * 0.50;
            }
            if (Emp.St >= 60)
            {
                Emp.Salary += Emp.Salary * 0.70;
            }
            if (pos == 1)
            {
                Emp.Position = "Специалист";
                Emp.Salary += Emp.Salary * 0.50;
            }
            else if (pos == 2)
            {
                Emp.Position = "Менеджер";
                Emp.Salary += Emp.Salary * 0.70;
            }
            else if (pos == 3)
            {
                Emp.Position = "Руководитель";
                Emp.Salary += Emp.Salary * 0.90;
            }
            else
            {
                Console.WriteLine("Вы не выбрали не одного варианта и вам будет показан стандартный вариант");
            }
            Emp.CalculateSalary();


        }
    }
}
