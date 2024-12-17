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

        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
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
            foreach(HourContract contract in HourContracts)
            {
                if(contract.Year == year && contract.Month == month)
                {

                }
            }
        }

    }
}