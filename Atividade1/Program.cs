using Atividade1.models;

Pessoa p1 = new Pessoa(nome: "Luis Davi",sobrenome: "Vieira Silva");
Pessoa p2 = new Pessoa(nome: "Carlos",sobrenome: "Murilo");

Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Ingles";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);
CursoDeIngles.ListarAlunos();