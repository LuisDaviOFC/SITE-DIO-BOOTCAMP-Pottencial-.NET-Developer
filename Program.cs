using SITE_DIO_BOOTCAMP_Pottencial_.NET_Developer.Models;

string opcao;
bool exibirMenu = true;

while(exibirMenu){
  Console.Clear();
  Console.WriteLine("Digite a sua opção: ");
  Console.WriteLine("1 - Cadastrar clientes");
  Console.WriteLine("2 - Buscar clientes");
  Console.WriteLine("3 - Apagar clientes");
  Console.WriteLine("4 - Encerrar");

  opcao = Console.ReadLine();

  switch(opcao){
    case "1":
    Console.WriteLine("Cadastro de Cliente");
    break;
    case "2":
    Console.WriteLine("Busca de Cliente");
    break;
    case "3":
    Console.WriteLine("Apagar Cliente");
    break;
    case "4":
    Console.WriteLine("Encerrar");
    exibirMenu = false;
    //Environment.Exit(0);
    break;
    default:
    Console.WriteLine("Opcao inválida");
    break;
  }
}

//int soma = 0, numero = 0;

//do{
//  Console.WriteLine("Digite um número (0 para parar)");
//  numero = Convert.ToInt32(Console.ReadLine());

//  soma += numero;
   
//}while(numero != 0);

//Console.WriteLine($"Total da soma dos números digitados é: {soma}");

//int numero = 5;
//int contador = 0;

//while (contador <= 10){
//  Console.WriteLine($"{contador + 1} x Execução: {numero} x {contador} = {numero * contador}");
//  contador++;
//  if (contador == 6){
//    break;
//  }
//}

//int numero = 10;

//for(int contador = 0; contador <= 10; contador++){
//  Console.WriteLine($"{numero} x {contador} = {numero * contador}");
//}

//       Calculadora calc = new Calculadora();
//       calc.Somar (10, 30);
//        calc.Subtrair (10, 50);
//        calc.Multiplicar (15, 45);
//        calc.Dividir (2, 2);
//        calc.Potencia (2, 10);
//        calc.Seno(30);
//        calc.Conseno(30);
//        calc.Tangente(30);
//        calc.RaizQuadrada(9);

//bool choveu = true;
//bool estatarde = false;

//if (!choveu && !estatarde){
//    Console.WriteLine("Vou pedalar!");
//}else{
//   Console.WriteLine("Vou pedalar um outro dia!");
//}

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