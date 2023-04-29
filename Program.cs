Console.Clear();

const String AGUASM = "M";
const String AGUASC = "C";

const double LimiteAguaC = 10;
const double LimiteAguaM = 15;

const decimal MultaExessoPeso = 1000;
const decimal MultaPorkg = 20;
decimal Multa;

Double Pescado;
String Local;

Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write("Peso em KG.....................: ");
Pescado = Convert.ToDouble(Console.ReadLine());
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Águas Continentais ou Maritimas? ");
Local = Console.ReadLine()!.Trim().Substring(0, 1).ToUpper();
Console.ResetColor();


Console.WriteLine();

if (Local != AGUASM && Local != AGUASC)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Selecione uma das Duas Opções...");
    Console.ResetColor();
    return;
}


if ((Local == AGUASC && Pescado <= LimiteAguaC)
||
(Local == AGUASM && Pescado <= LimiteAguaM))

{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Pescaria dentro do Limite");
    Console.ResetColor();
    return;
}



Double PesoPermitido;

if (Local == AGUASC)
{
    PesoPermitido = LimiteAguaC;
}
else
{
    PesoPermitido = LimiteAguaM;
}



Double PesoExesso = Pescado - PesoPermitido;
Multa = MultaExessoPeso + (MultaPorkg * Convert.ToDecimal(PesoExesso));

Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"Essa Pesca Execeu o limite legais em {PesoExesso} KG.");
Console.WriteLine($"Sujeito a Multa de {Multa:C2}");

Console.ResetColor();
