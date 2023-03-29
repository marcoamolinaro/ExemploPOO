using ExemploPOO.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Marco";
// p1.Idade = 59;

// p1.Apresentar();

ContaCorrente cc = new ContaCorrente(123, 1000);

cc.ExibirSaldo();
cc.Sacar(5000);
cc.ExibirSaldo();
