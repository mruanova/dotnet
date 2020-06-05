using System.Collections.Generic;

namespace hungry_ninja
{
    class Buffet
    {
        public List<Food> Menu;

        // constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Example", 1000, false, false)
            };
        }

        public Food Serve()
        {
            return Menu[0];
        }
    }
}
