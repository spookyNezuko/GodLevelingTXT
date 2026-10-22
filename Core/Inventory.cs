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
            _itemsList[index] = ItemsEnum.None;

            for(int i = 0; i < _itemsList.Length; i++)
            {
                _itemsList[index + i] = _itemsList[index + i + 1];
            }
        }

    }
}
