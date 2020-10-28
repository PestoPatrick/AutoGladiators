using System;
using System.Collections.Generic;
using System.Text;

namespace AutoGladiators.Interfaces
{
    interface IRoom
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
