using System.ComponentModel.Design;
using System.Diagnostics.Contracts;

Console.WriteLine("Vamos jogar dados!\nEscolha quantas jogadas você quer:");
int jogadas = Int32.Parse(Console.ReadLine());

Console.WriteLine("Vamos para as respostas!\nQuantas vezes os lados do dado caíram:");

Random dado = new Random();
int cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0, cont6 = 0;

for (int i = 0;i <= jogadas; i++){
    int sortearDado = dado.Next(1, 6+1);

    if (sortearDado == 1)
    {
        cont1++;
    }
        else if (sortearDado == 2)
        {
            cont2++;
        }
            else if (sortearDado == 3)
            {
                cont3++;
            } 
                else if(sortearDado == 4)
                {
                    cont4++;
                }
                     else if (sortearDado == 5)
                     {
                         cont5++;
                     }
                            else if (sortearDado == 6)
                            {
                                cont6++;
                            }
    }
Console.WriteLine($"O número de jogadas foram:\n1:{cont1}\n2:{cont2}\n3:{cont3}\n4:{cont4}\n5:{cont5}\n6:{cont6}");