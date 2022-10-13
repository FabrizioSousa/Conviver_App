using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conviver_App.VO
{
    public class Cuidador
    {
        private int id;
        private string nome;
        private string endereco;

        public int ID(int ID)
        {
            return this.id = ID;   
        }

        public string Nome(string Nome)
        {
            return this.nome = Nome;
        }
        public string Endereco(string Endereco)
        {
            return this.endereco = Endereco;
        }



    }
}
