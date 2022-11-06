// Ler um vetor com 10 inteiros e descubra o maior e o menor elemento do vetor.

Console.Clear();
int[] numeros = new int[10];

System.Console.WriteLine("Digite 10 números inteiros:");

for(int i=0; i<10; i++)
{
  System.Console.Write($"Número {i+1}: ");
  bool sucesso = int.TryParse(Console.ReadLine(), out int numeroSaida);
  numeros[i] = numeroSaida;
}

Array.Sort(numeros); // Sobre o Array.Sort: https://www.geeksforgeeks.org/different-ways-to-sort-an-array-in-descending-order-in-c-sharp/

Console.Clear();
System.Console.WriteLine("Resultado:");
System.Console.WriteLine($"Menor número do vetor: {numeros[0]}.");
System.Console.WriteLine($"Maior número do vetor: {numeros[9]}.");