Console.WriteLine("Digite o número para gerar a tabuada:");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 11; i++)
{
    int tab = num * i;
    Console.WriteLine(num + " x " + i + " = " + tab);
}