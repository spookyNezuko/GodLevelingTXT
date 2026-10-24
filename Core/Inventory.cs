using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Inventory
    {
        int _slotsFilled = 0;
        private ItemsEnum[] _itemsList = new ItemsEnum[10];
        
        public void AddItem(ItemsEnum item)
        {
            if (_slotsFilled - 1 < _itemsList.Length)
            {
                _itemsList[_slotsFilled] = item;
            }
        }

        public void RemoveItem(int index)
        {
            if (_itemsList[index] != ItemsEnum.None)
            {
                for (int i = index + 1; i < _itemsList.Length; i++)
                {
                    _itemsList[i - 1] = _itemsList[i];
                }

                _slotsFilled--;
            }
        }

        public ItemsEnum ReadItem(int index) => _itemsList[index];

    }
}
