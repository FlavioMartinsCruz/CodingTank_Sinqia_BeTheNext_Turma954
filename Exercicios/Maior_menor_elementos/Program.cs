// Ler um vetor com 10 inteiros e descubra o maior e o menor elemento do vetor.

Console.Clear();
int[] numeros = new int[10];
String[] listaAuxiliar = new String[10];

System.Console.WriteLine("Digite 10 números inteiros:");

for(int i=0; i<10; i++)
{
  System.Console.Write($"Número {i+1}: ");
  numeros[i] = int.Parse(Console.ReadLine()!);
}
Array.Sort(numeros);
foreach(int i in numeros)
{
  System.Console.WriteLine(i);
}
Console.Clear();
System.Console.WriteLine($"O menor número é o {numeros[0]}.");
System.Console.WriteLine($"O maior número é o {numeros[9]}.");