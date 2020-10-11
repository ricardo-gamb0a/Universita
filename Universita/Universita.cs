using System;
using System.Collections.Generic;
using System.Text;

namespace Universita
{
    class Universita
    {
        //ATTRIBUTI
        private string nome;
        private Rettore rettore;

        //COSTRUTTORE
        public Universita(string nome)
        {
            this.nome = nome;
        }

        //METODI
        public string GetNome()
        {
            return this.nome;
        }

        public void SetNome(string nome) 
        {
            this.nome = nome;
        }

        public void SetRettore(Rettore rettore)
        {
            this.rettore = rettore;
        }

        public override string ToString()
        {
            return this.nome;
        }



    }
}
