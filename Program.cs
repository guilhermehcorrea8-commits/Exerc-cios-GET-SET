using Aula_API_3.Models;

// ====================
// ALUNO
// ====================
Console.WriteLine("=== ALUNO ===");

Aluno aluno = new Aluno();

Console.Write("Nome: ");
aluno.SetNome(Console.ReadLine()!);

Console.Write("Matrícula: ");
aluno.SetMatricula(Convert.ToInt32(Console.ReadLine()!));

Console.Write("Nota: ");
aluno.SetNota(Convert.ToDouble(Console.ReadLine()!));

Console.WriteLine("\nDados do Aluno:");
Console.WriteLine($"Nome: {aluno.GetNome()}");
Console.WriteLine($"Matrícula: {aluno.GetMatricula()}");
Console.WriteLine($"Nota: {aluno.GetNota()}");

// ====================
// PRODUTO
// ====================
Console.WriteLine("\n=== PRODUTO ===");

Produto produto = new Produto();

Console.Write("Nome: ");
produto.Nome = Console.ReadLine()!;

Console.Write("Preço: ");
produto.Preco = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Quantidade: ");
produto.Quantidade = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine($"\nNome: {produto.Nome}");
Console.WriteLine($"Preço: R$ {produto.Preco}");
Console.WriteLine($"Quantidade: {produto.Quantidade}");

// ====================
// LIVRO
// ====================
Console.WriteLine("\n=== LIVRO ===");

Livro livro = new Livro();

Console.Write("Título: ");
livro.Titulo = Console.ReadLine()!;

Console.Write("Autor: ");
livro.Autor = Console.ReadLine()!;

Console.Write("Número de páginas: ");
livro.NumeroPaginas = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine($"\nTítulo: {livro.Titulo}");
Console.WriteLine($"Autor: {livro.Autor}");
Console.WriteLine($"Páginas: {livro.NumeroPaginas}");

// ====================
// CONTA BANCÁRIA
// ====================
Console.WriteLine("\n=== CONTA BANCÁRIA ===");

ContaBancaria conta = new ContaBancaria();

Console.Write("Número da conta: ");
conta.NumeroConta = Console.ReadLine()!;

Console.Write("Valor para depósito: ");
conta.Depositar(Convert.ToDouble(Console.ReadLine()!));

Console.Write("Valor para saque: ");
conta.Sacar(Convert.ToDouble(Console.ReadLine()!));

Console.WriteLine($"\nConta: {conta.NumeroConta}");
Console.WriteLine($"Saldo: R$ {conta.Saldo}");

// ====================
// CARRO
// ====================
Console.WriteLine("\n=== CARRO ===");

Carro carro = new Carro();

Console.Write("Marca: ");
carro.Marca = Console.ReadLine()!;

Console.Write("Modelo: ");
carro.Modelo = Console.ReadLine()!;

Console.Write("Ano: ");
carro.Ano = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine($"\n{carro.Marca} {carro.Modelo} - {carro.Ano}");

// ====================
// PESSOA
// ====================
Console.WriteLine("\n=== PESSOA ===");

Pessoa pessoa = new Pessoa();

Console.Write("Idade: ");
bool maior = pessoa.SetIdade(Convert.ToInt32(Console.ReadLine()!));

Console.WriteLine($"Idade: {pessoa.GetIdade()}");
Console.WriteLine(maior ? "Maior de idade" : "Menor de idade");

// ====================
// TRIÂNGULO
// ====================
Console.WriteLine("\n=== TRIÂNGULO ===");

Console.Write("Lado A: ");
double ladoA = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Lado B: ");
double ladoB = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Lado C: ");
double ladoC = Convert.ToDouble(Console.ReadLine()!);

Triangulo triangulo = new Triangulo();

if (triangulo.DefinirLados(ladoA, ladoB, ladoC))
{
    Console.WriteLine("Triângulo válido!");
}
else
{
    Console.WriteLine("Triângulo inválido!");
}

// ====================
// FUNCIONÁRIO
// ====================
Console.WriteLine("\n=== FUNCIONÁRIO ===");

Funcionario funcionario = new Funcionario();

Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine()!;

Console.Write("Salário: ");
funcionario.Salario = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine($"\nNome: {funcionario.Nome}");
Console.WriteLine($"Salário: R$ {funcionario.Salario}");

// ====================
// CÍRCULO
// ====================
Console.WriteLine("\n=== CÍRCULO ===");

Circulo circulo = new Circulo();

Console.Write("Raio: ");
circulo.Raio = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine($"Diâmetro: {circulo.Diametro}");
Console.WriteLine($"Área: {circulo.Area:F2}");

// ====================
// TEMPERATURA
// ====================
Console.WriteLine("\n=== TEMPERATURA ===");

Temperatura temperatura = new Temperatura();

Console.Write("Temperatura em Celsius: ");
temperatura.Celsius = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine($"Fahrenheit: {temperatura.Fahrenheit():F2}");

// ====================
// IMÓVEL
// ====================
Console.WriteLine("\n=== IMÓVEL ===");

Imovel imovel = new Imovel();

Console.Write("Endereço: ");
imovel.Endereco = Console.ReadLine()!;

Console.Write("Valor: ");
imovel.Valor = Convert.ToDouble(Console.ReadLine()!);

Console.Write("Desconto (%): ");
imovel.AplicarDesconto(Convert.ToDouble(Console.ReadLine()!));

Console.WriteLine($"Valor final: R$ {imovel.Valor}");

// ====================
// CONTATO E AGENDA
// ====================
Console.WriteLine("\n=== AGENDA ===");

Contato contato = new Contato();

Console.Write("Nome do contato: ");
contato.Nome = Console.ReadLine()!;

Console.Write("Telefone: ");
contato.Telefone = Console.ReadLine()!;

Agenda agenda = new Agenda();
agenda.Contato = contato;

Console.WriteLine($"Contato: {agenda.Contato.Nome}");
Console.WriteLine($"Telefone: {agenda.Contato.Telefone}");

// ====================
// EMPRESA
// ====================
Console.WriteLine("\n=== EMPRESA ===");

Empresa empresa = new Empresa();

Console.Write("Nome da empresa: ");
empresa.Nome = Console.ReadLine()!;

empresa.AdicionarFuncionario(funcionario);

Funcionario funcionario2 = new Funcionario();

Console.Write("Nome do segundo funcionário: ");
funcionario2.Nome = Console.ReadLine()!;

Console.Write("Salário do segundo funcionário: ");
funcionario2.Salario = Convert.ToDouble(Console.ReadLine()!);

empresa.AdicionarFuncionario(funcionario2);

Console.WriteLine($"\nEmpresa: {empresa.Nome}");
Console.WriteLine($"Folha de pagamento: R$ {empresa.FolhaPagamento}");

Console.WriteLine("\nFim do programa.");