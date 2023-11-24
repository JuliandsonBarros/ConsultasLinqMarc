using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMarcoratti
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Nota { get; set; }
        public string Sexo { get; set; }
        public List<string> Cursos { get; set; } = new List<string>();
    }
}
