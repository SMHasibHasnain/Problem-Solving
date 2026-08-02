//Bruteforce -- time exceed

int n = int.Parse(Console.ReadLine() ?? "0");
int[] arr = new int[n];
int i=0;
while(i<n)
{
    arr[i] = int.Parse(Console.ReadLine() ?? "0");
    i++;
}

int max = 0;

for(int j=0; j<n; j++)
{
    for(int k=j+1; k<n; k++)
    {
        if(Math.Min(arr[j], arr[k])*Math.Abs(j-k) > max) {
            max = Math.Min(arr[j], arr[k])* Math.Abs(j-k);
            System.Console.WriteLine($"arr{j} arr{k} = {max}");
        }
    }
}

System.Console.WriteLine(max);