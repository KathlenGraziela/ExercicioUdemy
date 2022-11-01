using System.Globalization;

//Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto). Em seguida, mostrar os
//dados do funcionário (nome e salário líquido). Em seguida, aumentar o salário do funcionário com base em uma 
//porcentagem dada (somente o salário bruto é afetado pela porcentagem) e mostrar novamente os dados do
//funcionário.

namespace ExercicioUdemy4
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + ((SalarioBruto * porcentagem)/100);
        }

        public override string ToString()
        {
            return Nome
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
