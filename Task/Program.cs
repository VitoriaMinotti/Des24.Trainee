#region-Trim
//remove os espaços em brancos da direita e da esquerda
Console.WriteLine("Exemplo usando o Trim, onde remove os espaços em brancos da direita e esquerda:");

Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome:");
string sobrenome = Console.ReadLine();

string nomeCompleto = ((nome.Trim() + "" + sobrenome.Trim())).Trim();
Console.WriteLine("Nome completo:" + nomeCompleto + ".");

#endregion

#region-TrimEnd 
//remove os espaços em brancos da direita
Console.WriteLine("\nExemplo usando o TrimEnd, onde remove os espaços em brancos da direita:");

Console.WriteLine("Digite seu nome:");
string nomeEnd = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome:");
string sobrenomeEnd = Console.ReadLine();

string nomeCompletoEnd = ((nomeEnd.TrimEnd() + "" + sobrenomeEnd.TrimEnd())).TrimEnd();
Console.WriteLine("Nome completo:" + nomeCompletoEnd + ".");

#endregion

#region-TrimStart 
//remove os espaços em brancos da esquerda
Console.WriteLine("\nResultado usando o TrimStart, onde remove os espaços em brancos da esquerda:");

Console.WriteLine("Digite seu nome:");
string nomeStart = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome:");
string sobrenomeStart = Console.ReadLine();

string nomeCompletoStart = ((nomeStart.TrimStart() + "" + sobrenomeStart.TrimStart())).TrimStart();
Console.WriteLine("Nome completo:" + nomeCompletoStart + ".");

#endregion