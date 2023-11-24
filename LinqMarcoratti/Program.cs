using LinqMarcoratti;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

Console.WriteLine("Consultas LINQ");

IEnumerable<List<string>> retornoListaAluno = FontDados.GetAluno().Select(c => c.Cursos).ToList();

foreach (var retornoLista in retornoListaAluno) 
{
    foreach (var curso in retornoLista)
    {
        Console.WriteLine(curso);   
       
    }
}

Console.WriteLine();
Console.WriteLine("====Resultado Distinct=====");

var result = FontDados.GetIdades().Distinct().ToList();

foreach (var idade in result) 
{
    Console.Write(" " + idade);
}

Console.WriteLine();

var result2 = FontDados.GetNomes().Distinct(StringComparer.OrdinalIgnoreCase).ToList();

foreach (var nome in result2)
{ 
    Console.Write("/" + nome);
}

Console.WriteLine();

Console.WriteLine();
Console.WriteLine("====Resultado DistinctBy=====");

var result3 =  FontDados.GetAluno().ToList();

var alunosDistintos = result3.DistinctBy(a => a.Idade);

foreach (var idadeDistintas in alunosDistintos)
{
    Console.WriteLine("O aluno: " + idadeDistintas.Nome + " tem a ideade de: " + idadeDistintas.Idade);
}

Console.WriteLine();
Console.WriteLine("====Resultado EceptBy=====");

var result4 = FontDados.GetAlunosReprovados().Distinct().ToList();

foreach (var reprovado in result4) { 
    Console.WriteLine(reprovado);
}

Console.WriteLine();
Console.WriteLine("====Resultado OrderBy em ordem Crescente=====");

var result5 = FontDados.GetAluno().OrderBy(a => a.Nome).ToList();

foreach (var nomeAluno in result5)
{
    Console.WriteLine(nomeAluno.Nome);
}

Console.WriteLine();
Console.WriteLine("=========Ordem Decrescente=========");

var result6 = FontDados.GetAluno().OrderByDescending(a => a.Nome).ToList();

foreach (var nomeAluno in result6) {
    Console.WriteLine(nomeAluno.Nome);
}

Console.WriteLine();
Console.WriteLine("=========Ordem Crescente com dois criterios=========");

var result7 =  FontDados.GetAluno().OrderBy(a => a.Nome).ThenBy(a => a.Idade).ToList();

foreach (var nomeAluno in result7) { 
    Console.WriteLine(nomeAluno.Nome + " " + nomeAluno.Idade);
}

Console.WriteLine();
Console.WriteLine("=========Consulta que retorna Alunos C/ idades superiores a 30 anos/ Ordeme idades Crescentes=========");

var result8 = FontDados.GetAluno().Where(i => i.Idade >= 30).OrderBy(a => a.Nome).ToList();

foreach (var nomeAluno in result8) {
    Console.WriteLine(nomeAluno.Nome + " " +  nomeAluno.Idade);
};


Console.WriteLine();
Console.WriteLine("=========Consulta agregate que recebe 2 parametros e concatena com virgula=========");

var result9 = FontDados.GetNomes().Aggregate((n1, n2) => n1 + "," + n2);

foreach (var nome in result9)
{
    Console.Write(nome);
}

Console.WriteLine();
Console.WriteLine("=========Consulta agregate que recebe 2  numeros e devolve o resultado=========");

int[] numeros = { 3, 5, 7, 9, 10 };

var result10 = numeros.Aggregate((n1,n2) => n1 * n2);//A função agregate itera sob todos os campos da coleção
var result10Con =  (from n in numeros
                    select n).Aggregate((n1,n2) => n1 * n2);

Console.WriteLine("Consulta utilizando Agregate: " + result10);
Console.WriteLine("Metodo c/ agregate: " + result10Con);


Console.WriteLine();
Console.WriteLine("=========Consulta agregate c/ valor de semente inicial=========");

var result11 = FontDados.GetAluno().Aggregate<Aluno, string>(
    "Nomes: ", //valor semente aqui)
    (semente, a) => semente += a.Nome + ",");
//Note que o metodo Agregate itera sobre todos os elementos da coleção 
//e concatena todos os nomes da coleção logo apos a string "Nomes: "
int indice = result11.LastIndexOf(","); 
result11 = result11.Remove(indice);

Console.WriteLine(result11);

Console.WriteLine();
Console.WriteLine("========================================");

var result12 = FontDados.GetAluno().Aggregate<Aluno, string,string>(
    "Nomes: ", //valor semente aqui)
    (semente, a) => semente += a.Nome + ",",
    r => r.Substring(0,r.Length-1));


Console.WriteLine(result12);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("==================Consulta average retornando medias de idade======================");

var result13 = FontDados.GetFuncionarios().Average(f => f.Idade);

Console.WriteLine("A média de idade dos funcionários: " + result13);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("====================Uso do Count====================");

string[] cursos = { "Java", "Angular", "React", "C#", ".Net Framwork", "JavaScript", "Assembly", "Pyton" };

var result14 = cursos.Count();
Console.WriteLine(result14);

var result15 = (from c in cursos
               select c).Count();
Console.WriteLine(result15);

var result16 = cursos.Count(c => c.Contains("J"));
Console.WriteLine(result16);

var result17 = (from c in cursos
                where c.Contains("A")
                select c).Count();
Console.WriteLine(result17);

Console.WriteLine();
Console.WriteLine("=================Utilização sum=====================");
int[] valores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
var result18 = valores.Sum();
Console.WriteLine(result18);

var result19 = valores.Where(v => v % 2 == 0).Sum();
Console.WriteLine(result19);

Console.WriteLine();
Console.WriteLine("========================================");

var result20 = FontDados.GetFuncionarios();

var menor = result20.Min(s => s.Salario);

var menorCon = (from s in result20
                select s).Min(s => s.Salario);

var menorIdade = result20.Min(i => i.Idade);

var menorIdadeCon = (from s in result20
                     select s).Min(i => i.Idade);

Console.WriteLine("Metodo Salario: " + menor);
Console.WriteLine("Consulta Salario: " + menorIdadeCon);
Console.WriteLine("Metodo Idade: " + menorIdade);
Console.WriteLine("Consulta Idade: " + menorIdadeCon);

var menor20 = result20.Where(i => i.Idade < 20).Min(s => s.Salario);   

var menor20Con = (from m in result20
                  where m.Idade < 20
                  select m).Min(s => s.Salario);

Console.WriteLine("Consulta: " + menor20Con);
Console.WriteLine("Metodo: " + menor20);

Console.WriteLine();
Console.WriteLine("===============Quantificador All=========================");

int[] numerosPares = {2, 6, 10, 22, 38, 48, 56 };

var result21 = numerosPares.All(n => n % 2 == 0);
Console.WriteLine(result21 ? "Elemntos Pares" : "Resultado invalido");

var result22 = (from n in numerosPares
                select n).All(n => n % 2 == 0);
Console.WriteLine(result21 ? "Elemntos Pares" : "Resultado invalido");

Console.WriteLine();
Console.WriteLine("====================Todos os Salarios acima de====================");

var salario2500 = FontDados.GetFuncionarios().Where(n => n.Salario > 2500).Select(n => n.Nome).ToList();

var ConsultaSalario = FontDados.GetFuncionarios();

var funcionariosA = ConsultaSalario.All(n => n.Nome.Contains('J'));
Console.WriteLine("Todos funcionarios letra J: " + funcionariosA);



var salario2500Con = (from n in ConsultaSalario
                      where n.Salario > 2500
                      select n.Nome).ToList();

for (int i = 0; i < salario2500Con.Count(); i++) {
    Console.WriteLine("Salario de Peooas por Consulta: " + salario2500Con[i]);
};

Console.WriteLine();
Console.WriteLine();

foreach (var n in salario2500) {
    Console.WriteLine("Salario de Pessoas por Consulta Metodo: " + n);
}

Console.WriteLine();
Console.WriteLine("==================Consultas All e Any======================");

var ConsultaNome = FontDados.GetFuncionarios(); 

var a =  ConsultaNome.Any(n => n.Nome.Contains('J'));
Console.WriteLine("Todos funcionarios letra J: " + a);

var b = (from n in ConsultaNome
         where n.Nome.Contains("J")
         select n.Nome).ToList();

foreach (var n in b)
{
    Console.WriteLine("Contains nome com J: " + n);
}

Console.WriteLine();
Console.WriteLine("====================Uso do Any c/ condição ternária===================");

bool vacinados = FontDados.GetCachorros().Any(i => i.Idade < 5 && i.vacinado == true);

Console.WriteLine(vacinados? "Vacina em dia" : "Vacina atrasada");

Console.WriteLine();
Console.WriteLine("==================Consultas Com agrupamento======================");

var grupos = FontDados.GetAluno().GroupBy(i => i.Idade).OrderBy(k => k.Key);

foreach (var grupo in grupos) 
{
    Console.WriteLine("\n Grupos de Idade: " + $"{grupo.Key}");

    foreach (var n in grupo) 
    {
        Console.WriteLine("\t Nomes: " + n.Nome + "/ Sexo: " + n.Sexo + "/ Cursos: "+ n.Cursos.First());
    }
}

var grupoMetodo = FontDados.GetAluno()
    .GroupBy(n => n.Idade)
    .OrderBy(k => k.Key)
    .Select(c => new
    {
        key = c.Key,
        Aluno = c.OrderBy(x => x.Cursos)
    });


Console.ReadKey();

Console.WriteLine();
Console.WriteLine("========================================");
