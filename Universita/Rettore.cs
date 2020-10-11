using System;
using System.Collections.Generic;
using System.Text;

namespace Universita
{
    class Rettore
    {
        private string nome;
        private string cognome;
        private string cf;
        private Universita universita;

        public Rettore(string nome, string cognome, string cf)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.cf = cf;
        }

        public string GetNome()
        {
            return this.nome;
        }

        public string GetCognome()
        {
            return this.cognome;
        }

        public string GetCF()
        {
            return this.cf;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public void SetCognome(string cognome)
        {
            this.cognome = cognome;
        }

        public void SetCF(string cf)
        {
            this.cf = cf;
        }

        public void SetUniversita(Universita universita)
        {
            this.universita = universita;
        }

        public override string ToString()
        {
            return this.nome + " " + this.cognome;
        }


    }
}
