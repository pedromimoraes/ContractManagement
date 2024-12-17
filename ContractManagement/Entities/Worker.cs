using ContractManagement.Entities.Enums;

namespace ContractManagement.Entities
{
    class Worker
    {
        public string Name { get; private set; }
        public WorkerLevel Level { get; private set; }
        public double BaseSalary { get; private set; }
        public Departament Departament { get; private set; }
        public List<HourContract> HourContracts { get; private set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            HourContracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            HourContracts.Remove(contract);
        }

        public Double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in HourContracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    return sum += contract.TotalValue();
                }
            }
            return sum;
        }

    }
}