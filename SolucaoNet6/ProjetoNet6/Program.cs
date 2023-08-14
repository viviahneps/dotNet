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



//Aprendendo Entrada de dados 
Console.WriteLine("---Entrada de dados-----\n");
Console.WriteLine("Digite seu nome: \n");
String nome = Console.ReadLine();
Console.WriteLine("Digite sua idade: \n");
int idade = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("-----Dados Digitados------");
Console.WriteLine($"Seu nome é :{nome}");
Console.WriteLine($"Sua idade:{idade}");

Console.WriteLine("Confirma essas informações ? S/N");
char confirma= Convert.ToChar(Console.Read());

if (confirma.Equals('s'))
{
    Console.WriteLine("Obrigada pela confirmação");
}
else
{
    Console.WriteLine("Não são seus dados!");
}

Console.ReadKey();



// Aprendendo operadores
Console.WriteLine("## Operadores Aritméticos \n");
Console.WriteLine("Informe o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Soma de X+Y ={x+y}");
Console.WriteLine($"Soma de X-Y ={x-y}");
Console.WriteLine($"Soma de X*Y ={x*y}");
double divisao = (double)x / y;
Console.WriteLine($"Soma de X/Y ={Math.Round(divisao,2)}");// exibe apenas a quantidade de casas estipuladas
Console.WriteLine($"Módulo de X/Y ={x % y}");

//funções aritimeticas
Console.WriteLine("----Funções Aritmeticas----");
Console.WriteLine($"Raiz de X ={Math.Sqrt(x)}");
Console.WriteLine($"Potencia de X elev. y ={Math.Pow(x,y)}");
Console.WriteLine($"Val min. de X e Y ={Math.Min(x,y)}");
Console.WriteLine($"Val max. de X e Y ={Math.Max(x,y)}");
Console.WriteLine($"Coseno={Math.Cos(x)}");
Console.WriteLine($"Seno ={Math.Sin(x)}");
Console.WriteLine($"Exponecial de X = {Math.Exp(x)}");


// inferecias de tipos :  var

var numero = "true";

//--------------------------------------Exercicios fase 2 ------------------------------------------

string nome ="Paulo";
int idade = 17;
double nota = 7.5;

Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");
Console.WriteLine($"Aluno {nome}\n");
Console.WriteLine($"Idade {idade}\n");
Console.WriteLine($"Nota {nota} \n");


Console.WriteLine("Informe três letras: \n");
Console.WriteLine("Letra 1: \n");

var letter1 = Console.ReadLine();
Console.ReadKey();

Console.WriteLine("Letra 2: \n");
var  letter2 = Console.ReadLine();
Console.ReadKey();

Console.WriteLine("Letra 3: \n");
var letter3 = Console.ReadLine();  
Console.WriteLine($"Letras ordem reversa: {letter3},{letter2}, {letter1}");


Console.WriteLine("Recebendo dois valores: \n");
Console.WriteLine("Valor 1:");

double val1 = Convert.ToDouble(Console.ReadLine());
Console.ReadKey();

Console.WriteLine("\n Valor 2:");
double val2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine($"Soma: {val1+val2}");
Console.WriteLine($"Subtração: {val1-val2}");
Console.WriteLine($"Multiplicação: {val1*val2}");
Console.WriteLine($"Divisão: {val1/ val2}");
Console.WriteLine($"Modulo: {val1% val2}");
Console.WriteLine($"Exponencial: {Math.Pow(val1,val2)}");


Console.ReadKey();


//Estrutura de repetição GOTO e Label

int i = 1;
repetir:

/Console.WriteLine($"i={i}");
i++;
if (i <= 10)
    goto repetir;
Console.WriteLine("Fim do processamento");


for (i=0;i<10; i++)
{
    if (i == 5)
        continue;
    if (i > 8)
        break;
    Console.WriteLine(i);
}
Console.WriteLine("Fim do processamento");

//---------------------------Exercicios Aula 57---------------------------------------


using System.ComponentModel.Design;

int hum , dois , tres;

Console.WriteLine("Digite tres números\n"+"Primeiro:");
hum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n Segundo:");
dois = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n Terceiro:");
tres = Convert.ToInt32(Console.ReadLine());

Console.ReadKey();

Console.WriteLine($"Primeiro Numero:{hum}");
Console.WriteLine($"Segundo Numero:{dois}");
Console.WriteLine($"Terceiro Numero:{tres}");

Console.ReadKey();

if (hum > dois)
{
    if (hum > tres)

        Console.WriteLine($"O primeiro numero é o maior: {hum}");
}

else if (dois > hum)
{
    if (dois > tres)
        Console.WriteLine($"O segundo numero é o maior: {dois}");

    else
    {

        Console.WriteLine($"O terceiro numero é o maior: {tres}");
    }
}



// calculo de raiz da equaçao ax+bx+c


using System;
using System.Text.RegularExpressions;

int a, b, c;
double delta,x1, x2;

Console.WriteLine("Digite tres números\n" + "Valor de A:");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n Valor de B:");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n Valor de C:");
c = Convert.ToInt32(Console.ReadLine());

delta = (Math.Pow(b,2)) - (4 * a * c);
Console.WriteLine("Calculo Delta: \n");
Console.WriteLine($"Delta: {delta}  \n");


if (delta == 0)
{
    Console.WriteLine("As duas raizaes são iguais \n");
    x1 = -b / (2*a);
    x2 = x1;
    Console.WriteLine($"Primera raiz:{x1}  \n");
    Console.WriteLine($"Segunda raiz:{x2}  \n");
}

else if (delta > 0)
{
    Console.WriteLine("Raizes são reais e diferentes\n");
    x1 = -(b + Math.Sqrt(delta)) / (2 * a);
    x2 = -(b - Math.Sqrt(delta)) / (2 * a); ;
    Console.WriteLine($"Primera raiz:{x1} \n");
    Console.WriteLine($"Segunda raiz:{x2} \n");
}
else
{
    Console.WriteLine("As raizes são imaginarias;\n Sem solução");
}



//Calculo numeros naturais

int i, soma=0;

Console.WriteLine("Os 10 primeiros numeros naturais são:");
for (i=1;i<=10;i++)
{
 Console.Write($"{i}\t");
  soma = soma + i;
}
Console.WriteLine($"\n A soma dos números é :{ soma}");



// Tabuada com numero digitado pelo usuário:

int i, num;

do
{
    Console.WriteLine("Digite um numero maior que zero:");
    num = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine($"Tabuado do {num}");
    if (num > 0)
    {
        for (i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{num} x {i} ={num * i}");

        }
    }
    else
    {
    Console.WriteLine("Tabuada somente de numeros  naturais maior que 0.");
        break;
    }
} while (num > 0);
*/

//Quiz 

    Console.WriteLine("---------Quiz C#-------------------\n");


char opcao;

do {
Console.WriteLine("Qual a instrução para sair de um loop ?");
Console.WriteLine("a.Quit " + "\n b.Continue" + "\n c.Break" + "\n d.Exit");
opcao = Convert.ToChar(Console.ReadLine());

if (opcao.Equals('c') || opcao.Equals('C'))
{
Console.WriteLine("Parabéns ! Resposta Correta.");
}
else
{
Console.WriteLine("Eroooou ! Tente novamente...");
}

  Console.WriteLine("Tecle x para sair");

} while (!(opcao== 'x'));

   
 


