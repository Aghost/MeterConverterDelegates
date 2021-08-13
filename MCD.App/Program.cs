using static System.Console;
using static MCD.Domain.ExpressionLib;
using static MCD.Domain.DictionaryLib;
using MCD.Domain;

Unit converter = new (LengthUnits, ConvertUnit);
string input;

while ((input = ReadLine()) != "exit") {
    Write(converter.ConvertValues(input));
}
