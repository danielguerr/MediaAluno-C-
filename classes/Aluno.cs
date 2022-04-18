using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaAluno.classes
{
    public class Aluno
    {
        private string Nome;
        private string Matricula;
        private double Nota1;
        private double Nota2;
        private double Media;
        private bool StatusAprovacao;

        public Aluno(string Nome, string Matricula)
        {
            this.Nome = Nome;
            this.Matricula = Matricula;
        }

        public void setNome(string Nome)
        {
            this.Nome = Nome;
        }

        public void setMatricula(string Matricula)
        {
            this.Matricula = Matricula;
        }

        public void setNota1(double Nota1)
        {
            this.Nota1 = Nota1;
        }

        public void setNota2(double Nota2)
        {
            this.Nota2 = Nota2;
        }

        public void setMedia(double Media)
        {
            this.Media = Media;
        }

        public void setStatusAprovacao(bool StatusAprovacao)
        {
            this.StatusAprovacao = StatusAprovacao;
        }

        public string getNome()
        {
            return Nome;
        }

        public string getMatricula()
        {
            return Matricula;
        }

        public double getNota1()
        {
            return Nota1;
        }

        public double getNota2()
        {
            return Nota2;
        }

        public double getMedia()
        {
            return Media;
        }

        public bool getStatusAprovacao()
        {
            return StatusAprovacao;
        }

        // Métodos

        public double calcularMedia(double nota1, double nota2)
        {
            this.setNota1(nota1);
            this.setNota2(nota2);
            if(getNota1() >= 0 && getNota1() <= 10 && getNota2() >= 0 && getNota2() <= 10) 
            {
                setMedia((getNota1() + getNota2()) / 2);
                return getMedia();
            } else
            {
                return 0;
            }
        }

        public string avaliaMedia(double media)
        {
            setMedia(media);
            if(getMedia() <= 4)
            {
                return "Aluno reprovado: " + getMedia();
            } else if(getMedia() < 6)
            {
                return "Aluno em recuperação: " + getMedia();
            } else if(getMedia() >= 6)
            {
                return "Aluno aprovado com a média: " + getMedia();
            } else
            {
                return "Média fora de 0 a 10.";
            }
        }

        public string returnInformacoesAluno()
        {
            return "Nome: " + getNome() + "\n" + "Matrícula: " + getMatricula() + "\n" + "Média: " + getMedia() + "\n" + "Status de Aprovação: " + getStatusAprovacao() + "\n";
        }

    }
}
