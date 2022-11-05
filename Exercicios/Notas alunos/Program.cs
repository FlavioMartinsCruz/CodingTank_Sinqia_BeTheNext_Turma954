// Escreva um programa que leia quatro notas escolares de um aluno e apresentar uma mensagem que o aluno foi
// aprovado se o valor da média escolar for maior ou igual a 7. Se o valor da média for menor que 7, solicitar a nota
// do recuperação, somar com o valor da média e obter a nova média. Se a nova média for maior ou igual a 7,
// apresentar uma mensagem informando que o aluno foi aprovado na recuperação. Se o aluno não foi aprovado,
// apresentar uma mensagem informando esta condição. Apresentar junto com as mensagens o valor da média do
// aluno.

// Resolução: Caso a entrada seja um número negativo ou não consiga ser convertida para double, retornará uma mensagem para o usuário. Isso foi feito para todas as notas, inclusive para a nota de recuperação.

Console.Clear();
System.Console.WriteLine("Insira a primeira nota do aluno: ");
string nota1 = Console.ReadLine()!;

System.Console.WriteLine("Insira a segunda nota do aluno: ");
string nota2 = Console.ReadLine()!;

System.Console.WriteLine("Insira a terceira nota do aluno: ");
string nota3 = Console.ReadLine()!;

System.Console.WriteLine("Insira a quarta nota do aluno: ");
string nota4 = Console.ReadLine()!;

bool sucesso1 = double.TryParse(nota1, out double nota1convertida);
bool sucesso2 = double.TryParse(nota2, out double nota2convertida);
bool sucesso3 = double.TryParse(nota3, out double nota3convertida);
bool sucesso4 = double.TryParse(nota4, out double nota4convertida);

if (sucesso1 && sucesso2 && sucesso3 && sucesso4)
{
  if (nota1convertida < 0 || nota2convertida < 0 || nota3convertida < 0 || nota4convertida < 0)
  {
    Console.Clear();
    System.Console.WriteLine("Nenhum valor digitado pode ser negativo. Todas as notas devem ser maiores que zero!");
  }
  else
  {
    double mediaNotas = (nota1convertida + nota2convertida + nota3convertida + nota4convertida) / 4;
    if (mediaNotas >= 7.00)
    {
      Console.Clear();
      Console.WriteLine($"Aluno aprovado com média de notas igual a {mediaNotas.ToString("F2")}.");
    }
    else
    {
      Console.Clear();
      System.Console.WriteLine($"Aluno está de recuperação, pois sua média de notas atual foi de {mediaNotas.ToString("F2")}.\nInsira a nota obtida na recuperação: ");
      string notaRecuperacao = Console.ReadLine()!;
      bool sucessoRecuperacao = double.TryParse(notaRecuperacao, out double notaRecuperacaoConvertida);

      if (sucessoRecuperacao)
      {
        if (notaRecuperacaoConvertida < 0)
        {
          Console.Clear();
          System.Console.WriteLine("Nota de recuperação não pode ser negativa. Todas as notas devem ser maiores que zero!");
        }
        else
        {
          double mediaNotasFinal = (mediaNotas + notaRecuperacaoConvertida) / 2;
          if (mediaNotasFinal >= 7.00)
          {
            Console.Clear();
            Console.WriteLine($"Aluno aprovado na recuperação com média de notas igual a {mediaNotasFinal.ToString("F2")}.");
          }
          else
          {
            Console.Clear();
            Console.WriteLine($"Aluno não aprovado na recuperação!\nA média final das notas foi de {mediaNotasFinal.ToString("F2")}.");
          }
        }
      }
      else
      {
        Console.Clear();
        System.Console.WriteLine("Nota de recuperação inválida. Insira um número positivo!");
      }
    }
  }
}
else
{
  Console.Clear();
  System.Console.WriteLine("Uma ou mais notas digitadas são inválidas. Insira um número positivo!");
}