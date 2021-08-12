using System;
using System.Collections.Generic;

namespace MCD.Domain
{
    public static class DictionaryLib {
        public static Dictionary<string, double> LengthUnits = new() {
            {"nm", 0.000000001 },
            {"um", 0.000001 },
            {"mm", 0.001 },
            {"cm", 0.01 },
            {"in", 0.0254 },
            {"dm", 0.1 },
            {"m", 1 },
            {"Dm", 10 },
            {"hm", 100 },
            {"km", 1000 },
            {"Mm", 1000000 },
            {"gm", 1000000000 },
            {"tm", 1000000000000 },
            {"pm", 1000000000000000 },
            {"em", 1000000000000000000 }
        };
    }
}
