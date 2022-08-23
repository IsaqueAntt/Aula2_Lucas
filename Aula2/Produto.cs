using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Produto
    { 
        // declaração de atributos
        int codigo;
        string descricao;
        double valor;
        string categoria;

        // declaração dos métodos getters e setters
        public void setCodigo(int codigo)
        {
            this.codigo = codigo;   
        }

        public int getCodigo()
        {
            return this.codigo;
        }

        public void setDescricao(string descricao)
        {
            this.descricao = descricao; 
        }

        public string getDescricao()
        {
            return this.descricao;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }
        
        public double getValor()
        {
            return this.valor;
        }
        public void setCategoria(string categoria)
        {
            this.categoria = categoria;
        }
        public string getCategoria()
        {
            return this.categoria;
        }
    }
}
