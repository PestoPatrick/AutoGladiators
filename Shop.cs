using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators.Interfaces
{
    class Shop : IRoom
    {
        public string Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        List<object> Inventory { get; set; }
        
        public void DisplayItems()
        {

        }
        public void SellItem()
        {

        }
    
    
    }
}
