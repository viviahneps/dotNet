/*
Console.WriteLine("Declarando variaveis numericas");
Console.WriteLine();

//Declarando variaveis

byte valor1 = 255;
sbyte valor2 = -127;
int valor3 = -214746581;

Console.WriteLine(valor1);
Console.WriteLine(valor2);
Console.WriteLine(valor3);

   
  
//Console.ReadLine();

Console.WriteLine("Atribuindo valores a float ,double e decimal");

float valor4 = 1.234f ;
decimal valor5= 1.234M;
double valor6 = 1.234;


Console.WriteLine(valor4);
Console.WriteLine(valor5);
Console.WriteLine(valor6);

Console.ReadLine();
Console.WriteLine("Comparando a precisão dos tipos");

float valor7 = 1f / 3f;
double valor8 = 1d / 3d;
decimal valor9 = 1m / 3m;

Console.WriteLine(valor7);
Console.WriteLine(valor8);
Console.WriteLine(valor9);
Console.ReadLine();


Console.WriteLine("Atribuindo valores char e bool");

bool valor10 = true;
char valor11 = 'c';

Console.WriteLine(10<20);
Console.WriteLine(valor10);
Console.WriteLine(valor11);

Console.ReadLine();

string valor12 = "Bora estudar pra ser melhor!";
Console.WriteLine(valor12);

Console.ReadLine();
Console.WriteLine("Trabalhando data e hora");

DateTime data1 = new DateTime(2023,08,01);
DateTime data2 = DateTime.Now;

Console.WriteLine(data1);
Console.WriteLine(data2);

Console.WriteLine("Extraindo valores da data");
Console.WriteLine(data2.Year);
Console.WriteLine(data2.Month);
Console.WriteLine(data2.Day);
Console.WriteLine(data2.Hour);
Console.WriteLine(data2.Minute);
Console.WriteLine(data2.Second);
Console.WriteLine(data2.Millisecond);

Console.WriteLine("Adicionando e capturando valores da data");
Console.WriteLine(data2.AddDays(8));
Console.WriteLine(data2.AddHours(3));
Console.WriteLine(data2.DayOfYear);

Console.ReadLine();

Console.WriteLine("Data no formato longo");
Console.WriteLine(data2.ToLongDateString());
Console.WriteLine(data2.ToShortDateString());

Console.ReadLine();
Console.WriteLine("Nullable Type");
Nullable<int> inteiro = null;
Nullable<bool> bol2 = null;
Nullable<float> flut3 = null;
int? int1 = null;//usando o operador ?
*/
int ? b = 100;
if (b.HasValue)
{
    Console.WriteLine($"Valor de B={b}");
}
else
{
    Console.WriteLine("B é nulo");
}



