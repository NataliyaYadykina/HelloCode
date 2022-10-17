int[] array = {13,24,3,14,58,45,6,47,58};

int n = array.Length;
int find = 58;

int i = 0;

while(i < n)
{
    if(array[i] == find)
    {
        Console.WriteLine(i);
        break;
    }
    i++;
}