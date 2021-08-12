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
            {"pi", 3.14159265358 },
            {"Dm", 10 },
            {"football-field", 91 },
            {"hm", 100 },
            {"km", 1000 },
            {"Mm", 1000000 },
            {"earth-radius", 6371000 },
            {"earth-equator", 40075016686 },
            {"gm", 1000000000 },
            {"tm", 1000000000000 },
            {"pm", 1000000000000000 },
            {"lightyear", 9460730472580044 },
            {"em", 1000000000000000000 }
        };
    }
}
