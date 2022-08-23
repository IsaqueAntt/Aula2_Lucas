using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Pedido
    {
        int numero;
        int quantidade;
        double total;
        
        public void setnumero(int numero)
        {
            this.numero = numero;   
        }
        public int getnumero()
        {
            return numero;  
        }
        public void setquantidade(int quantidade)
        {
            this.quantidade = quantidade;   
        }
        public int getquantidade()
        {
            return quantidade;  
        }
        public void settotal(double total)
        {
            this.total = total; 
        }
        public double gettotal()
        {
            return total;   
        }

    }
}
