namespace human
{
    class Human
    {
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
        public Human(string name, int strength, int intelligence, int dexterity, int _health)
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            health = _health;
        }
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        // property
        public int Health
        {
            get { return health; }
        }
        // method
        public int Attack(Human target)
        {
            int damage = 5 * Strength;
            target.health = target.health - damage;
            return target.health;
        }
    }
}
