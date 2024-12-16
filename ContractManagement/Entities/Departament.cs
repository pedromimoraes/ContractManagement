namespace ContractManagement.Entities
{
    class Departament
    {
        public string Name { get; private set; }

        // Class primary constructor
        public Departament(string name)
        {
            Name = name;
        }
    }
}