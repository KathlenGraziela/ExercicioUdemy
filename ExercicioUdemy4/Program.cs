using ExercicioUdemy4;
using System.Globalization;

//------------------------------- Exercicio 03 -------------------------------\\ 
Aluno aluno = new Aluno();

Console.Write("Nome do aluno: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite as três notas do aluno: ");
aluno.Nota01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Nota03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("NOTA FINAL = "
 + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

if (aluno.Aprovado())
{
    Console.WriteLine("APROVADO");
}
else
{
    Console.WriteLine("REPROVADO");
    Console.WriteLine("FALTARAM "
    + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
    + " PONTOS");
}

//------------------------------- Exercicio 02 -------------------------------\\ 
//Funcionario funcionario = new Funcionario();

//Console.Write("Nome: ");
//funcionario.Nome = Console.ReadLine();
//Console.Write("Salário Bruto: ");
//funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//Console.Write("Imposto: ");
//funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Console.WriteLine();

//Console.WriteLine("Funcionario: " + funcionario);

//Console.WriteLine();

//Console.Write("Digite a porcentagem para aumentar o salário: ");
//double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//funcionario.AumentarSalario(porcent);

//Console.WriteLine();
//Console.Write("Dados atualizados: " + funcionario);
