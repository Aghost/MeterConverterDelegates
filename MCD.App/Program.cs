using System;
using System.Collections.Generic;
using static System.Console;
using MCD.Domain;
using static MCD.Domain.ExpressionLib;
using static MCD.Domain.DictionaryLib;

Unit lengthUnit = new (LengthUnits, ConvertUnit);
string input;

while ((input = ReadLine()) != "exit") {
    Write(lengthUnit.DoOneThingWithTwoDoubles(input));
}
