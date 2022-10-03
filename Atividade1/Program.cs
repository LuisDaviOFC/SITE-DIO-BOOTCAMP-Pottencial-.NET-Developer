using Atividade1.models;
using System.Globalization;

string dataString = "2022-10-03 18:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if(sucesso){
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
} else {
    Console.WriteLine($"{dataString} não é uma data valida!");
}

//DateTime data =  DateTime.Now;
//DateTime data = DateTime.Parse("17/04/2022 18:07"); // Voce mesmo coloca a data e hora, so que ele fica travado.
//Console.WriteLine(data); //Data e Hora Atual.
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); //Data e Hora Atual.
//Console.WriteLine(data.ToShortDateString()); //Data Atual
//Console.WriteLine(data.ToShortTimeString()); //Hora Atual

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// decimal valorMonetario = 82.40M;

//Console.WriteLine($"{valorMonetario:C}");
//Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("p"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));

//Testando as Concatenção
//Primeiro Teste
// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

//Segundo Teste
// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;

//Terceiro Teste
// string numero1 = "10";
// int numero2 = 20;

// string resultado = numero1 + numero2;

//Quatro Teste
// int numero1 = 10;
// string numero2 = "20";

// string resultado = numero1 + numero2;
// Console.WriteLine(resultado);

// Pessoa p1 = new Pessoa(nome: "Luis Davi",sobrenome: "Vieira Silva");
// Pessoa p2 = new Pessoa(nome: "Carlos",sobrenome: "Murilo");

// Curso CursoDeIngles = new Curso();
// CursoDeIngles.Nome = "Ingles";
// CursoDeIngles.Alunos = new List<Pessoa>();

// CursoDeIngles.AdicionarAluno(p1);
// CursoDeIngles.AdicionarAluno(p2);
// CursoDeIngles.ListarAlunos();