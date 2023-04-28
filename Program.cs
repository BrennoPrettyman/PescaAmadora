Console.Clear();

const String AGUASM = "M";
const String AGUASC = "C";

const double LimiteAguaC = 10;
const double LimiteAguaM = 15;

const decimal MultaExessoPeso = 1000;
const decimal MultaPorkg = 20;

Double Pescado;
String Local;


Console.Write("Peso em KG.....................: ");
Pescado = Convert.ToDouble(Console.ReadLine());


Console.Write("Águas Continentais ou Maritimas? ");
Local = Console.ReadLine()!.Trim().Substring(0,1).ToUpper();

Console.WriteLine();

if (Local != AGUASM && Local != AGUASC)
{
    Console.WriteLine("Selecione Uma das Duas Opções...");
    return;
}

if((Local == AGUASC && Pescado <= LimiteAguaC)
||
(Local == AGUASM && Pescado <= LimiteAguaM ))

{
    Console.WriteLine("Pescaria dentro do Limite");
    return;
}

