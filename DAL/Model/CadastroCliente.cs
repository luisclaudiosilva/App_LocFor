using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
   public class CadastroCliente
    {
        //Declaração dos atributos da classe: Cliente
        public int codigoCliente { get; set; }
        public string nomeCliente { get; set; }
        public int telefoneCliente { get; set; }
        public int cpfCliente { get; set; }
        public string loginCliente { get; set; }
        public string senhaCliente { get; set; }
    }
}
