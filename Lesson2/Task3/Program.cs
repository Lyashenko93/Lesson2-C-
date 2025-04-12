int n = 10;
int[] array = {2, 8, 6 , 10, 7 ,3, 1, 22, 5, 9};
int i = 0;

while(i<n)
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i+1;
}