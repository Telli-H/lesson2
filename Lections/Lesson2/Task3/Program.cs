// int n=10;
int [] arr={2,5,6,7,8,9,10,11,12,13};
int i=0;

while (i<arr.Length)
{
    if(arr[i]%2==0)
    {
        Console.Write($"{arr[i]} ");
    }
    i=i+1;
}
