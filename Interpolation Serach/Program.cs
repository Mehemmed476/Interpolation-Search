int[] arr = [10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 33, 35, 42, 47 ];

// Axtarılan Element 
int x = 18;

int n = arr.Length;
int lo = 0;
int hi = n - 1;
int pos = -1;


bool isFound = false;
// İnterpolation Search'ü həyata keçirək 
while (lo <= hi && x >= arr[lo] && x <= arr[hi])
{
    // Vahid paylanmanı nəzərə alaraq mövqeyi yoxlayaq
    pos = lo + (((hi - lo) / (arr[hi] - arr[lo])) * (x - arr[lo]));

    // Əgər elemek tapılarsa
    if (arr[pos] == x)
    {
        isFound = true;
        break;
    }

    // Element daha böyükdürsə, o, sağ alt (alt çoxluq kimi düşünə bilərsiz) massivdə olmalıdır
    if (arr[pos] < x)
    {
        lo = pos + 1;
    }
    // Element daha kiçikdirsə, o, sol alt (alt çoxluq kimi düşünə bilərsiz) massivdə olmalıdır
    else
    {
        hi = pos - 1;
    }
}

// Element tapılarsa
if (isFound)
{
    Console.WriteLine("Element found at position: " + pos);
}
// Element tapılmadıqda
else
{
    Console.WriteLine("Element not found.");
};