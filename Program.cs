using ExemploPOO.interfaces;
using ExemploPOO.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Marco";
// p1.Idade = 59;

// p1.Apresentar();

// ContaCorrente cc = new ContaCorrente(123, 1000);

// cc.ExibirSaldo();
// cc.Sacar(5000);
// cc.ExibirSaldo();

// Aluno a1 = new Aluno();
// a1.Nome = "Marco";
// a1.Idade = 59;
// a1.Email = "marco@teste.com";
// a1.Nota = 9.5;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Molinaro";
// p1.Idade = 59;
// p1.Email = "molinaro@edu.com";
// p1.Salario = 10;
// p1.Apresentar();

// Corrente c = new Corrente();
// c.Creditar(1000);
// c.ExibirSaldo();

// Pessoa p1 = new Pessoa("Marco");
// Aluno a1 = new Aluno("Molinaro");
// a1.Apresentar();

// Computador c = new Computador();
// Console.WriteLine(c.ToString());

ICalculadora c = new Calculadora();
Console.WriteLine(c.Multiplicar(3, 9));