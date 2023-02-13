double Factorial (double n)
{
    if (n == 1 || n == 0) return 1;
    else return n * Factorial (n-1);
}

for (int i  = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
//Console.Write(Factorial(3));