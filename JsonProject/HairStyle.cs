using System;
using System.Collections.Generic;
using System.Text;

namespace JsonProject
{
    class HairStyle
    {
        public HairColour Colour { get; set; }
        public float Length { get; set; }
        public override string ToString() => $"{Length:0.0} inch {Colour} hair";

    }
}
