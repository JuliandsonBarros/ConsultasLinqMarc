using LinqMarcoratti;

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
Console.WriteLine("=========Consulta que retorna Alunos C/ idades superiores a 30 anos=========");

var result8 = FontDados.GetAluno().Where(i => i.Idade >= 30).OrderBy(a => a.Nome).ToList();

foreach (var nomeAluno in result8) {
    Console.WriteLine(nomeAluno.Nome + " " +  nomeAluno.Idade);
};


Console.ReadKey();