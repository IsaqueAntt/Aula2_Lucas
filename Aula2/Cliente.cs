using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Cliente
    {
        string nome;
        string Cpf;
        string endereco;
        int idade;
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setCpf(string cpf)
        {
            this.Cpf = cpf;
        }
        public string getCpf()
        {
            return this.Cpf;
        }
        public void setendereco(string endereco)
        {
            this.endereco = endereco;   
        }
        public string getendereco()
        {
            return endereco;
        }
        public void setidade(int idade)
        {
            this.idade = idade;
        }
        public int getidade()
        {
            return this.idade;  
        }














    }
}
