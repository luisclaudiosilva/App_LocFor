using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
   public class Alugados
    {
        public int codigoAluguel { get; set; }
        public int codigoImovel { get; set; }
        public int codigoCliente { get; set; }
        public string dataInicioAluguel { get; set; }
        public string dataFimAluguel { get; set; }
        public int pagamento { get; set; }
    }
}
