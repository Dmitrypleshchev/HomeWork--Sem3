// Напишите программу, которая принимает на вход число N и выдает таблицу кубов чисел от 1 до N.

int Read(string argument)
{
  int number;
  Console.WriteLine($"input {argument}: ");
  while((!int.TryParse(Console.ReadLine(), out number)) || number < 0)
  {
    Console.WriteLine("Not a number");
  }
  return number;
}

void Line()
{
  int N = Read("N");
  for (int i =1; i <= N; i++)
  {
    double Cub = Math.Pow (i,3);
    Console.WriteLine($"{Cub}");
  }
}

Line();