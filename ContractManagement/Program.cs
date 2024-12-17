using ContractManagement.Entities;
using ContractManagement.Entities.Enums;
using System.Globalization;

namespace ContractManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter departament's name: ");
            string departamentName = Console.ReadLine();

            System.Console.WriteLine("Enter worker data: ");

            System.Console.Write("Name: ");
            string name = Console.ReadLine();

            System.Console.Write("Level (Junior | MidLevel | Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            System.Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.Write("How many contracts to this worker? ");
            int contractsNumber = int.Parse(Console.ReadLine());

            Departament departament = new Departament(departamentName);

            Worker worker = new Worker(name, level, baseSalary, departament);

            for (int i = 1; i <= contractsNumber; i++)
            {
                System.Console.WriteLine($"Enter #{i} contract data: ");

                System.Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",CultureInfo.InvariantCulture);

                System.Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                System.Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            System.Console.Write("Enter month and year to calculate income (MM/YYYY):");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));


            System.Console.WriteLine($"Name: {worker.Name}");
            System.Console.WriteLine($"Departament: {worker.Departament.Name}");
            System.Console.WriteLine($"Income for {monthAndYear}: {worker.Income(year, month)}");

        }
    }
}