// Faça um programa que leia um número e mostre a tabuada de multiplicação dele.

// Resolução: Caso a entrada seja um número negativo ou não consiga ser convertida para double, retornará uma mensagem para o usuário.

Console.Clear();
System.Console.WriteLine("Criação automatizadas de tabuadas.");
System.Console.Write("Insira um número inteiro: ");

bool sucesso = int.TryParse(Console.ReadLine(), out int numeroInteiro);
if (sucesso)
{
  if (numeroInteiro < 0)
  {
    Console.Clear();
    System.Console.WriteLine("Valor digitado não pode ser negativo. Insira um número inteiro positivo!");
  }
  else
  {
    Console.Clear();
    System.Console.WriteLine($"Tabuada do número {numeroInteiro}:");
    int contador;
    for(contador = 0; contador < 10; contador++)
    {
      System.Console.WriteLine($"{numeroInteiro} x {contador + 1} = {numeroInteiro * (contador + 1)}");
    }
  }
}
else
{
  Console.Clear();
  System.Console.WriteLine("Valor digitado inválido. Insira um número inteiro positivo!");
}