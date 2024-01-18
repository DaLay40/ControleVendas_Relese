using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios.Enumerators;

namespace Model
{
    public class Config
    {

        public long Id { get; set; }
        public String Version { get; set; }
        public bool ExibirItens { get; set; }

        public byte? Layout { get; set; }
    }
}
