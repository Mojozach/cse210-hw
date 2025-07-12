public abstract class Character
    {
        public abstract string Name { get; }
        public abstract string Description { get; }

        public int HP { get; protected set; }
        public int Attack { get; protected set; }
        public int Defense { get; protected set; }
        public int Magic { get; protected set; }

        public abstract List<string> Abilities { get; }

        public void ShowStats()
        {
            Console.WriteLine("=== Stats ===");
            Console.WriteLine($"HP:      {HP}");
            Console.WriteLine($"Attack:  {Attack}");
            Console.WriteLine($"Defense: {Defense}");
            Console.WriteLine($"Magic:   {Magic}");
            Console.WriteLine("Abilities: " + string.Join(", ", Abilities));
        }
    }