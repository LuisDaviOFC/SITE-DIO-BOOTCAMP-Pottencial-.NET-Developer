using SITE_DIO_BOOTCAMP_Pottencial_.NET_Developer.Models;

bool choveu = true;
bool estatarde = false;

if (!choveu && !estatarde){
    Console.WriteLine("Vou pedalar!");
}else{
    Console.WriteLine("Vou pedalar um outro dia!");
}

//bool ehMaiorDeIdade = true;
//bool possuiAutorizacaoDoResponsavel = false;

//if (ehMaiorDeIdade && possuiAutorizacaoDoResponsavel){
//    Console.WriteLine("Entrada liberada!");
//}else{
//    Console.WriteLine("Entrada não liberada!");
//}

//bool ehMaiorDeIdade = true;
//bool possuiAutorizacaoDoResponsavel = false;

//if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel){
   // Console.WriteLine("Entrada liberada!");
//}else{
//    Console.WriteLine("Entrada não liberada!");
//}

//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine();
//switch (letra){
//    case "a":
//    case "e":
//    case "i":
//   case "o":
//    case "u":
//    Console.WriteLine("Vogal");
//    break;
//    default:
//    Console.WriteLine("Não é uma vogal");
//    break;
//}

//Console.WriteLine("Digite uma letra");
//string letra = Console.ReadLine();

//if (letra == "a" ||
//    letra == "e" ||
//    letra == "i" ||
//    letra == "o" ||
//    letra == "u"){
//    Console.WriteLine("Vogal");
//}else{
 //   Console.WriteLine("Não é uma vogal");
//}

//int quantidadeEmEstoque = 10;
//int quantidadeCompra = 4;
//bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

//Console.WriteLine($"Quantidade em estoque:{quantidadeEmEstoque}");
//Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
//Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

//if(quantidadeCompra == 0){
  //  Console.WriteLine("Venda Inválida!");
//}else if(possivelVenda){
//    Console.WriteLine("Venda realizada com sucesso!!");
//}else{
//    Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque no momento!! Volte mais tarde!!");
//}

//string a = "15";
//int b = 0;

//int.TryParse(a, out b);

//Console.WriteLine(b);
//Console.WriteLine("Conversão realizada com sucesso");

//double a = 4 / 2 + 2;

//Console.WriteLine(a);

//int a = 5;
//double b = a;

//Console.WriteLine(b);

//cast - casting
//int a = Convert.ToInt32("8");
//Console.WriteLine(a);

//int a = 10;
//int b = 20;
 
 //int c = a + b;
 //c = c + 5; // 30 + 5 = 35
 //OU
 //c += 5;
 //Console.WriteLine(c);

//DateTime dataatual = DateTime.Now;
//Console.WriteLine(dataatual);

//string apresentacao ="Olá, Seja Bem Vindo";
//int quantidade = 1;
//double altura = 1.80;
//decimal preco = 1.80M;
//bool condicao = true;

//Console.WriteLine("Valor da variável apresentação: " + apresentacao);
//Console.WriteLine("Valor da variável quantidade: " + quantidade);
//Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
//Console.WriteLine("Valor da variável preco: " + preco);
//Console.WriteLine("Valor da variável condicao: " + condicao);

//Pessoa pessoa1 = new Pessoa(); 
//pessoa1.Nome = "Luis Davi";
//pessoa1.Idade = 22;
//pessoa1.apresentar();
//Pessoa pessoafisicarepresentacao = new Pessoa();