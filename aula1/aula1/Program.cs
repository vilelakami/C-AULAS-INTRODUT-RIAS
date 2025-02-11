// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome:");
string lname = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
string idade = Console.ReadLine();
int valorIdade = Int32.Parse(idade);

Console.WriteLine("Digite sua altura:");
string altura = Console.ReadLine();
double cm = Convert.ToDouble(altura);

Console.WriteLine("Digite seu peso:");
string peso = Console.ReadLine();
int kg = Int32.Parse(peso);

double imc = kg / cm * cm;

Console.WriteLine($"Bem-vindo {nome} {lname}\n" + $"Você tem {valorIdade} anos\n" + $"Sua altura é de {cm} e seu peso de {kg}\n" + $"E seu IMC é de {imc}");*/

//Console.WriteLine("Escreva seu primeiro nome:");
//string fname = Console.ReadLine();

//Console.WriteLine("Escreva seu nome do meio:");
//string mname = Console.ReadLine();

//Console.WriteLine("Escreva seu nome final:");
//string lname = Console.ReadLine();


//Console.WriteLine($"Olá {fname} {mname} {lname}");
//Console.WriteLine("Olá {0} {1} {2}", fname, mname, lname);
//Console.WriteLine("Olá " + fname + " " + mname + " " + lname);

//string nome = "Kami";
//string sobrenome = "Vilela";

//Console.WriteLine($"Olá {nome} {sobrenome}");

//Console.WriteLine("Olá {0} {1}", nome, sobrenome);

//Console.Write("Olá " + nome + " " + sobrenome);

//Console.Write("Hello, World! ");
//int idade = 5;
//idade++;
//string nome = "Kami";
//Console.Write(nome);


//aula 2

Console.WriteLine("DIGITE DOIS NÚMEROS: ");
int n1 = Int32.Parse(Console.ReadLine());
int n2 = Int32.Parse(Console.ReadLine());

//outra forma de fazer:
// string numeroUm = Console.ReadLine();
//int n1 = Int32.Parse(numeroUm);


if (!(n1 > 0 && n2 > 0))
{
    Console.WriteLine("Erro! Os números devem ser maiores que 0");
    return;
}

if (n2 < n1)
    {
        Console.WriteLine("Erro! O segundo número deve ser maior ou igual que o primeiro");
    return;
    }

    Random sorteador = new Random();
    for (int i = 0; i <= 1000; i++)
{
    
    int sortear = sorteador.Next(n1, n2+1);
    Console.WriteLine("O número sorteado foi: {0}", sortear);
}
