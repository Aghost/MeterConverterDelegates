using System;
using System.Linq.Expressions;

namespace MCD.Domain
{
    public static class ExpressionLib {
        public static Func<double, double, double, double> ConvertUnit = (x, y, val) => x * (val / y);
    }
}
