using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGA1.Model
{
    class Casa
    {
        private string nome;
        private string endereco;
        private int capacidadeMaxima;
        private int valorDiaria;
        private int numQuartos;
        private int numBanheiros;

        private bool lareira;

        public Casa()
        {
            nome = "";
            endereco = "";
            capacidadeMaxima = 0;
            valorDiaria = 0;
            numBanheiros = 0;
            numQuartos = 0;

            lareira = false;
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Endereco
        {
            get
            {
                return endereco;
            }

            set
            {
                endereco = value;
            }
        }

        public int CapacidadeMaxima
        {
            get
            {
                return capacidadeMaxima;
            }

            set
            {
                capacidadeMaxima = value;
            }
        }

        public int ValorDiaria
        {
            get
            {
                return valorDiaria;
            }

            set
            {
                valorDiaria = value;
            }
        }

        public int NumQuartos
        {
            get
            {
                return numQuartos;
            }

            set
            {
                numQuartos = value;
            }
        }

        public int NumBanheiros
        {
            get
            {
                return numBanheiros;
            }

            set
            {
                numBanheiros = value;
            }
        }

        public bool Lareira
        {
            get
            {
                return lareira;
            }

            set
            {
                lareira = value;
            }
        }
    }
}
