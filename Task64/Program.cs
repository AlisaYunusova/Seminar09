int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

void PrintNumber(int m, int n)
{
  if (n > m) return;
  PrintNumber(m, n + 1);
  Console.Write(n + ", ");
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
Console.WriteLine();