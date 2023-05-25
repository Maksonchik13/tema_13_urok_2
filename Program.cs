//1)
Random random = new Random();
int rand = 0;
do
{
    rand = random.Next(1, 11);
    Console.WriteLine(rand);
}
while (rand != 7);


//2)
int sum = 0;
int n = -1;
do
{
    Console.WriteLine("Введите любое число кроме 0");
    n=int.Parse(Console.ReadLine());
    sum += n;
}
while (n != 0);
Console.WriteLine($"сумма = {sum}");