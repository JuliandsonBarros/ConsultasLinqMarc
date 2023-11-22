using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqMarcoratti
{
    class FontDados
    {
        public static List<Aluno> GetAluno()
        {
            List<Aluno> alunos = new()
            {
                new Aluno {Nome = "Fulano de Tal",Idade = 20,  Nota = 5, Cursos = new List<string> { "Java, Angular" } },
                new Aluno {Nome = "Cicrano de Tal",Idade = 20,  Nota = 4, Cursos = new List<string> { ".NET, React" } },
                new Aluno {Nome = "Beltrano de Tal",Idade = 20,  Nota = 5, Cursos = new List<string> { "VB net, Botstrap" } },
                new Aluno {Nome = "Neymar de Tal",Idade = 32,  Nota = 2, Cursos = new List<string> { "JavaScript, Boststrap" } },
                new Aluno {Nome = "Messi de Tal",Idade = 36,  Nota = 5, Cursos = new List<string> { "PHP, Angular" } },
                new Aluno {Nome = "Cristiano Ronaldo de Tal",Idade = 37,  Nota = 5, Cursos = new List<string> { "sQL, Angular" } },
                new Aluno {Nome = "Ronaldo de Tal",Idade = 48,  Nota = 4, Cursos = new List<string> { "PYTON, Angular" } },
                new Aluno {Nome = "Hulk de Tal",Idade = 28,  Nota = 5, Cursos = new List<string> { "Assembly, Html" } },
                new Aluno {Nome = "Jack de Tal",Idade = 30,  Nota = 5, Cursos = new List<string> { "Java, Angular" } },
            };
            return alunos;
        }

        public static List<Funcionario> GetFuncionarios()
        {
            List<Funcionario> Funcionarios = new()
            {
                new Funcionario {Nome = "Juliandson Barros Soares",Idade = 37, Salario = 10000.00 },
                new Funcionario {Nome = "Eduarda Leão Galvão Barros",Idade =  18,Salario = 8000.00 },
                new Funcionario {Nome = "Bruna Leão Galvão Barros",Idade =  18,Salario = 8000.00 },
                new Funcionario {Nome = "Isabelle da Paz Barros",Idade =  19,Salario = 8000.00 }
            };
            return Funcionarios;
        }

        public static int[] GetIdades() {

            var idades = new[] { 10, 20, 30,30, 40, 50, 60, 70, 80,80, 90 };
            return idades;
        }

        public static string[] GetNomes() {

            var nomes = new[] { "Messi", "Cristiano Ronaldo", "Salah", "salah", "sala"};
            return nomes;
        }

        public static string[] GetPaises() {

            var paises = new[] { "Brasil", "China", "Estados Unidos", "França", "Espanha", "Japão" };
            return paises;
        }
        public static string[] GetPaises2() {

            var paises2 = new[] { "Bolívia", "Equador", "Argentina", "Chile", "Paraguai", "Peru" };
            return paises2;
        }

        public static string[] GetAlunosReprovados() {

            var reprovados = new[] { "Fulano de tal", "Neymar", "Jack de tal" };
            return reprovados;
        }
    }
}
