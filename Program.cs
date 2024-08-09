using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();

Console.Write("Digite seu nome: ");
string Nome = Console.ReadLine();
Console.Write("Digite sua idade: ");
int Idade = Convert.ToInt32(Console.ReadLine());

p1.Nome = Nome;
p1.Idade = Idade;
p1.Apresentar();