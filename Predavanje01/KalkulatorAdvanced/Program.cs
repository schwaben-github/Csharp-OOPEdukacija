// See https://aka.ms/new-console-template for more information

// Deklaracija i inicijalizacija dva decimalna broja
float broj1_float = 5.0f;
float broj2_float = 3.0f;

double broj1_double = 5.0;
double broj2_double = 3.0;

decimal broj1_decimal = 5.0m;
decimal broj2_decimal = 3.0m;

// Matematičke operacije
float zbroj_float = broj1_float + broj2_float;
float razlika_float = broj1_float - broj2_float;
float umnozak_float = broj1_float * broj2_float;
float kolicnik_float = broj1_float / broj2_float;

double zbroj_double = broj1_double + broj2_double;
double razlika_double = broj1_double - broj2_double;
double umnozak_double = broj1_double * broj2_double;
double kolicnik_double = broj1_double / broj2_double;

decimal zbroj_decimal = broj1_decimal + broj2_decimal;
decimal razlika_decimal = broj1_decimal - broj2_decimal;
decimal umnozak_decimal = broj1_decimal * broj2_decimal;
decimal kolicnik_decimal = broj1_decimal / broj2_decimal;

// Ispis rezultata
Console.WriteLine($"float: {broj1_float} + {broj2_float} = {zbroj_float}");
Console.WriteLine($"float: {broj1_float} - {broj2_float} = {razlika_float}");
Console.WriteLine($"float: {broj1_float} * {broj2_float} = {umnozak_float}");
Console.WriteLine($"float: {broj1_float} / {broj2_float} = {kolicnik_float}");

Console.WriteLine($"double: {broj1_double} + {broj2_double} = {zbroj_double}");
Console.WriteLine($"double: {broj1_double} - {broj2_double} = {razlika_double}");
Console.WriteLine($"double: {broj1_double} * {broj2_double} = {umnozak_double}");
Console.WriteLine($"double: {broj1_double} / {broj2_double} = {kolicnik_double}");

Console.WriteLine($"decimal: {broj1_decimal} + {broj2_decimal} = {zbroj_decimal}");
Console.WriteLine($"decimal: {broj1_decimal} - {broj2_decimal} = {razlika_decimal}");
Console.WriteLine($"decimal: {broj1_decimal} * {broj2_decimal} = {umnozak_decimal}");
Console.WriteLine($"decimal: {broj1_decimal} / {broj2_decimal} = {kolicnik_decimal}");