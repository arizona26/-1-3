Console.Write("Введiть D = ");
int D = int.Parse(Console.ReadLine()); 
List<int> A = new List<int> { 121, 324, 467, 124, 783, 978, 125, 654, 143 };
int result = A.FirstOrDefault(num => num > 0 && num % 10 == D);
Console.WriteLine("Результат: " + (result != 0 ? result.ToString() : "0"));

Console.ReadLine();