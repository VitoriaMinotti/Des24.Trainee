#region-Atividade 00 (Convertendo variavel)
//float x = 10;

//int y= x; //não é possivel pois o int é menor que float
//int  y= (int) x; //conversão explicita
//int y= Convert.ToInt32(x); //conversão implicita

//double y = 5.1;

//x = y;  //não pode converter por causa do tamanho

#endregion
#region-Atividade 01 (Conversão e Impressão)
//string a;
//double b;
//int c;
//char d;

//a = Console.ReadLine();
//b = double.Parse(Console.ReadLine()); //usa o .parse para converter
//c = int.Parse(Console.ReadLine());
//d = char.Parse(Console.ReadLine());

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(d);
#endregion
#region-Atividade 02 ()
string nome;
string genero;
int idade;
float valor_consulta;

Console.WriteLine("Qual o seu nome?");
nome = Console.ReadLine();
Console.WriteLine("Qual o seu genero?");
genero = Console.ReadLine();
Console.WriteLine("Qual a sua idade?");
idade = int.Parse(Console.ReadLine());
Console.WriteLine("Qual o valor da consulta?");
valor_consulta = float.Parse(Console.ReadLine());

Console.WriteLine($"O nome do paciente é {nome}e o genero {genero} e possui {idade} anos." +
    $" O valor total da consulta é R${valor_consulta}.");

#endregion