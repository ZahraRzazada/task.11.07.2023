//Task 1

int number = 11;
int sum = 0;
for (int i = 0; i < number; i++)
{
    sum += i;
}
Console.WriteLine(sum);

// Task 2

int number2 = 30;
int factorial = 1;
for (int i = 1; i <= number2; i++)
{
    factorial *= i;
}
Console.WriteLine(factorial);

// Task 3

int[] arr = { 6, 7, 8, 9, 10, 11, 12 };
for (int i = 1; i < arr.Length; i += 2)
{
    Console.WriteLine(arr[i]);
}


//Task 4

int[] arr2 = { 2, 3, 4, 5, 6, 7, 8 };
bool result = true;
for (int i = 0; i < arr2.Length; i++)
{
    if (arr2[i] % 2 != 0)
        result = false;
}

Console.WriteLine(result);


