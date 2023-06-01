// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// На столе лежат n монеток. Некоторые из них лежат вверх решкой,
// а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть,
// чтобы все монетки были повернуты вверх одной и той же стороной.
// 1-Решка
// 0-Орел

Console.WriteLine("Введите число монеток на столе: ");
int n = int.Parse(Console.ReadLine());

int[] result = new int[n];

int min = 0;
int max = 1;

Random randNum = new Random();
for (int i = 0; i < result.Length; i++)
{
    result[i] = randNum.Next(min, max + 1);
}

Console.WriteLine($"[{String.Join(" , ", result)}]");

int sum = 0;

for (int i = 0; i < result.Length; i++)
{

    sum += result[i];

}

int coins1 = n - sum;
int coins2 = n - coins1;

if (coins1 > coins2){
    Console.WriteLine($"Перевернуть {coins2} монеток.");
}
else{
    Console.WriteLine($"Перевернуть {coins1} монеток.");
}
