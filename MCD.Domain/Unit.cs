using System;
using System.Text;
using System.Collections.Generic;

namespace MCD.Domain
{
    public class Unit {
        private Dictionary<string, double> Dict;
        private Func<double, double, double, double> f;
        public double Value;

        public Unit(Dictionary<string, double> Dict, Func<double, double, double, double> f, double Value = 0) {
            this.Dict = Dict;
            this.f = f;
            this.Value = Value;
        }

        public string DoOneThingWithTwoDoubles(string input) {
            if (input == String.Empty) {
                return $"Dictionary keys: {String.Join(' ', Dict.Keys)}\n";
            }

            int status = 0;
            double[] dubs = new Double[2];
            StringBuilder sb = new ();

            foreach (string str in input.Split(' ')) {
                if (Dict.ContainsKey(str)) {
                    status += 1;
                    dubs[status - 1] = Dict[str];
                } else if (Double.TryParse(str, out Value)) { }

                if ((status == 2) && (Value != 0)) {
                    sb.Append($"{f(dubs[0], dubs[1], Value)}\n");
                    status = 0;
                }
            }

            return sb.ToString();
        }
    }
}
