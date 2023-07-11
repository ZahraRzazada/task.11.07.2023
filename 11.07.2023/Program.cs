int number = 11;
int sum = 0;
for (int i = 0; i < 11; i++)
{
    sum += i;
}
Console.WriteLine(sum);


int number2 = 30;
int factorial = 1;
for (int i = 1; i <= 30; i++)
{
    factorial *= i;
}
Console.WriteLine(factorial);


int[] arr = { 6, 7, 8, 9, 10, 11, 12 };
for (int i = 1; i < Array.MaxLength; i += 2)
{
    Console.WriteLine(arr[i]);
}


int[] arr2 = { 2, 3, 4, 5, 6, 7, 8 };
bool result = true;
for (int i = 0; i <= arr2.Length; i++)
{
    if (arr2[i] % 2 != 0)
        result = false;
    Console.WriteLine(result);
}
