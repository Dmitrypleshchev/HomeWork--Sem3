// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Read(string argument)
{
  int number;
  Console.WriteLine($"input {argument}: ");
  while ((!int.TryParse(Console.ReadLine(), out number)))
  {
    Console.WriteLine(" Not a number");
  }
  return number;
}

double Length()
{
int x1 = Read("x1");
int y1 = Read("y1");
int z1 = Read("z1");
int x2 = Read("x2");
int y2 = Read("y2");
int z2 = Read("z2");
int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
return length;
}

void Answer()
{
  double L = Length();
  Console.WriteLine ($"Расстояние между точками равно {L}");
}

Answer();