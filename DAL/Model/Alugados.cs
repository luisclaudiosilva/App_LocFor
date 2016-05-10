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
        public DateTime dataInicio { get; set; }
        public Nullable<DateTime> dataFim { get; set; }
        public int pagamento { get; set; }
    }
}
