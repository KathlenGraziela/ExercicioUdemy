using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioUdemy4
{
    class Aluno
    {
        public string Nome;
        public double Nota01;
        public double Nota02;
        public double Nota03;

        public double NotaFinal()
        {
            return Nota01 + Nota02 + Nota03;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 6.0)
                return true;
      
            else 
                return false; 
        }

        public double NotaRestante()
        {
            if (Aprovado())
                return 0.0;

            else
                return 6.0 - NotaFinal();
        }
    }
}
