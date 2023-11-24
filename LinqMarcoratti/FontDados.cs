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
                new Aluno {Nome = "Fulano de Tal",Idade = 20,  Nota = 5,Sexo = "M",
                    Cursos = new List<string> { "Java, Angular", "Html e Css" } },
                new Aluno {Nome = "Cicrano de Tal",Idade = 20,  Nota = 4, Sexo = "M",
                    Cursos = new List<string> { ".NET, React", "VB." } },
                new Aluno {Nome = "Zelia de Tal",Idade = 20,  Nota = 5, Sexo = "F", 
                    Cursos = new List<string> { "VB net, Botstrap", "VB." } },
                new Aluno {Nome = "Neymar de Tal",Idade = 36,  Nota = 2, Sexo = "M",
                    Cursos = new List<string> { "JavaScript, Boststrap", "VB." } },
                new Aluno {Nome = "Messi de Tal",Idade = 36,  Nota = 5, Sexo = "M", 
                    Cursos = new List<string> { "PHP, Angular", "VB." } },
                new Aluno {Nome = "Cristiano Ronaldo de Tal",Idade = 37, Sexo = "M",  Nota = 5, 
                    Cursos = new List<string> { "sQL, Angular", "VB." } },
                new Aluno {Nome = "Graça de Tal",Idade = 48,  Nota = 4, Sexo = "F",
                    Cursos = new List<string> { "PYTON, Angular", "VB." } },
                new Aluno {Nome = "Hulk de Tal",Idade = 48,  Nota = 5, Sexo = "M", 
                    Cursos = new List<string> { "Assembly, Html", "VB." } },
                new Aluno {Nome = "Jack de Tal",Idade = 30,  Nota = 5, Sexo = "F",
                    Cursos = new List<string> { "Java, Angular", "VB." } },
            };
            return alunos;
        }

        public static List<Funcionario> GetFuncionarios()
        {
            List<Funcionario> Funcionarios = new()
            {
                new Funcionario {Nome = "Juliandson Barros Soares",Idade = 37, Salario = 1500.00 },
                new Funcionario {Nome = "Eduarda Leão Galvão Barros",Idade =  35,Salario = 800.00 },
                new Funcionario {Nome = "Bruna Leão Galvão Barros",Idade =  30,Salario = 4000.00 },
                new Funcionario {Nome = "Isabelle da Paz Barros",Idade =  20,Salario = 8000.00 },
                new Funcionario {Nome = "Tuco balos ",Idade = 37, Salario = 10000.00 },
                new Funcionario {Nome = "João de Cabeça",Idade =  18,Salario = 2800.00 },
                new Funcionario {Nome = "Marcos Senna",Idade =  29,Salario = 2000.00 },
                new Funcionario {Nome = "Manoel de Souza",Idade =  18,Salario = 1100.00 }
            };
            return Funcionarios;
        }

        public static List<Cachorro> GetCachorros() 
        {
            List<Cachorro> Cachorros = new()
            {
                new Cachorro {Nome = "Thor", Idade = 9, vacinado = true },
                new Cachorro {Nome = "Pipoca", Idade = 4, vacinado = false },
                new Cachorro {Nome = "Kiko", Idade = 2, vacinado = false },
                new Cachorro {Nome = "Fiona", Idade = 0, vacinado = false },
            };
            return Cachorros;
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
