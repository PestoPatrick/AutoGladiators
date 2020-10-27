using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AutoGladiators
{
    interface IItem
    {
        string Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        bool IsEquipped { get; set; }
        string Type { get; set; }
        int Value { get; set; }

        

    }
}
