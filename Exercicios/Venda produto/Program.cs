// Um comerciante comprou um produto e quer vende-lo com um lucro de 45% se o valor da compra for menor que R$20,00; caso contrário, o lucro será de 30%. Entrar como valor do produto e imprimir o valor da venda.

// Resolução: Caso a entrada seja um número negativo ou não consiga ser convertida para double, retornará uma mensagem para o usuário.

Console.WriteLine("Qual o valor do produto comprado?");

bool sucesso = double.TryParse(Console.ReadLine(), out double valorProduto);
if (sucesso)
{
  if (valorProduto < 0)
  {
    Console.Clear();
    System.Console.WriteLine("Valor digitado não pode ser negativo. Insira um número positivo!");
  }
  else
  {
    if (valorProduto < 20.00)
    {
      double valorVenda45 = valorProduto * 1.45;
      Console.Clear();
      Console.WriteLine($"Venda o produto por R$ {valorVenda45.ToString("F2")}.");
    }
    else
    {
      double valorVenda30 = valorProduto * 1.30;
      Console.Clear();
      Console.WriteLine($"Venda o produto por R$ {valorVenda30.ToString("F2")}.");
    }
  }
}
else
{
  Console.Clear();
  System.Console.WriteLine("Valor digitado inválido. Insira um número positivo!");
}