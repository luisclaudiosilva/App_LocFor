using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Imovel
    {
        public int codigoImovel { get; set; }
        public string nomeBairro { get; set; }
        public string nomeTipoImovel { get; set; }
        public string negocioNome { get; set; }
        public int quantidadeQuarto { get; set; }
        public string tipoSituacao { get; set; }
        public float valorImovel { get; set; }

    }
}
