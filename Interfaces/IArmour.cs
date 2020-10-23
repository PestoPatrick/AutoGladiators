using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators
{
    interface IArmour : IItem
    {
             
        int Defence { get; set; }
        float Weight { get; set; }
    }
}
