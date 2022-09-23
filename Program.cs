using DotnetAula1.Models;

// Case

Console.WriteLine("Digite uma letra:");

string letra = Console.ReadLine();


// Usando o Switch

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":

    Console.WriteLine("Vogal!");
    break;

    default:
    Console.WriteLine("Não é uma vogal!");
    break;
}

















// if (letra == "a" || // Pipe é sinal que representa - OU -
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
    
//     Console.WriteLine("Vogal!");
    
// }
// else
// {
    
//     Console.WriteLine("Não é uma Vogal!");
    
// }















// else if (letra == "e")
// {
    
//     Console.WriteLine("Vogal!");

// }
// else if (letra == "i")
// {
    
//     Console.WriteLine("Vogal!");

// }
// else if (letra == "o")
// {
    
//     Console.WriteLine("Vogal!");

// }
// else if (letra == "u")
// {
    
//     Console.WriteLine("Vogal!");

// }
// else
// {
    
//     Console.WriteLine("Não é uma Vogal!");

// }












// Realizando uma Condição

// int quantidadeEmEstoque = 4;

// int quantidadeCompra = 10;

// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

// Console.WriteLine("\nSISTEMA DE VENDAS MAGAZINE\n");
// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"\nQuantidade de compra: {quantidadeCompra}");
// Console.WriteLine($"\nÉ possível realizar a venda? {possivelVenda}\n");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida!\n");
// }
// else if (possivelVenda)
// {
//     //Console.WriteLine("Sim!\n");
//     Console.WriteLine("Venda Realizada com sucesso! Obrigado e volte sempre.\n");
// }
// else
// {
//     //Console.WriteLine("Não\n");
//     Console.WriteLine("Não foi possível realizar a venda.\n");
// }
// IF Aninhado (onde você tem várias condições para executar).














//{quantidadeEmEstoque >= quantidadeCompra}





// string a = "15-";

// //int b = 0;

// int.TryParse(a, out b);
// //Convert.ToInt32(a);

// Console.WriteLine(a);
// Console.WriteLine("Conversão realizada com sucesso!!!");

















// Conversão do tipo String

// int inteiro = 5;
// string a = inteiro.ToString();

// Console.WriteLine(a);


//int a = Convert.ToInt32(null);

// Cast - Casting




//int a = Convert.ToInt32("5"); // Convert => é uma class /// ToInt32 => é um método (Ele converteu um tipo de dado para outro tipo de dado)

// int a = int.Parse("1000");

// decimal.Parse("40");

// Convert.ToInt32("10");



// int a = 5;


//Operadores

// int a = 20;
// int b = 30;

// int c = a + b;

// c += 5; essa operação de atribuição é igual a operação abaixo => c = c + 5;

// //c = c + 5;

// c -= 5;




// DateTime dataAtual = DateTime.Now.AddDays(5);

// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));


// string apresentacao = "\nOlá, seja bem-vindo!";
// apresentacao = "Título da Apresentação.";

// int quantidade = 1;
// quantidade = 10;
// quantidade = 50;

// double altura = 1.80;
// altura = 2.10;

// decimal preco = 1.80M;
// preco = 10.050M;

// bool condicao = !true;
// condicao = !false;

// Console.WriteLine(apresentacao);
// Console.WriteLine("\nValor da variável quantidade:\n" + quantidade);
// Console.WriteLine("\nValor da variável altura:\n" + altura.ToString("0.00"));
// Console.WriteLine("\nValor da variável preço:\n" + preco);
// Console.WriteLine("\nValor da variável condição:\n" + condicao);


//Pessoa pessoa1 = new Pessoa();
//pessoa1.Nome = "Jhonny";
//pessoa1.Idade = 42;
//pessoa1.Endereco = "Los Angeles City";
//pessoa1.Apresentar();

