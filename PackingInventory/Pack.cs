using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory
{
    internal class Pack
    {

        private InventoryItem[] Items { get; set; }
        private int MaxItems { get; set; }
        private float MaxWeight { get; set; }
        private float MaxVolume { get; set; }


        private int _itemCount;
        private float _volumeCount;
        private float _weightCount;

        public Pack(int maxItems, float maxWeight, float maxVolume)
        {
            MaxItems = maxItems;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
            Items = new InventoryItem[MaxItems];
        }

        public bool Add(InventoryItem item)
        {
            if(_itemCount> MaxItems || _volumeCount > MaxVolume || _weightCount > MaxWeight)
                return false;

            Items[ItemCount] = item;
            _volumeCount += Items[_itemCount].Volume;
            _weightCount += Items[_itemCount].Weight;
            _itemCount++;
            return true;
        }
        public float GetMaxWeight() { return MaxWeight; }
        public float GetMaxVolume() { return MaxVolume;}
        public int GetMaxItems() { return MaxItems;}
        public int ItemCount { get => _itemCount;}
        public float VolumeCount { get => _volumeCount;}
        public float WeightCount { get => _weightCount;}
    }
}
