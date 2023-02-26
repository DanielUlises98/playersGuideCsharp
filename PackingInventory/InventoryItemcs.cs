using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    public class InventoryItem
    {
        public float Weight { get; set; }
        public float Volume { get; set; }
        public InventoryItem(float weight, float volume)
        {
            Weight = weight;
            Volume = volume;
        }
        public override string ToString()
        {
            return "InventoryItem";
        }
    }
    public class Arrow : InventoryItem
    {
        public Arrow() : base(0.1f, 0.05f)
        {

        }
        public override string ToString()
        {
            return "Arrow";
        }
    }
    public class Bow : InventoryItem
    {
        public Bow() : base(1f, 4f)
        {

        }

        public override string ToString()
        {
            return "Bow";
        }
    }
    public class Rope : InventoryItem
    {
        public Rope() : base(1f, 1.5f)
        {

        }
        public override string ToString()
        {
            return "Rope";
        }
    }
    public class Water : InventoryItem
    {
        public Water() : base(2f, 3f)
        {

        }
        public override string ToString()
        {
            return "Water";
        }
    }
    public class FoodRation : InventoryItem
    {
        public FoodRation() : base(1f, 0.5f)
        {

        }

        public override string ToString()
        {
            return "Food Ration";
        }
    }
    public class Sword : InventoryItem
    {
        public Sword() : base(5f, 3f)
        {

        }

        public override string ToString()
        {
            return "Sword";
        }
    }

}
