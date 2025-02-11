using System.ComponentModel.Design;
using System.Diagnostics.Contracts;

Console.WriteLine("Vamos jogar dados!\nEscolha quantas jogadas você quer:");
int jogadas = Int32.Parse(Console.ReadLine());

Console.WriteLine("Vamos para as respostas!\nQuantas vezes os lados do dado caíram:");

Random dado = new Random();
//int cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0, cont6 = 0;

int[] freqDado = new int[6];

for (int i = 0;i <= jogadas; i++){
    int sortearDado = dado.Next(1, 6+1);

    freqDado[sortearDado - 1] = +1;
    }

for (int i = 0; i < freqDado.Length; i++)
{
    Console.WriteLine($"{i + 1}: {freqDado[i]}");
}

