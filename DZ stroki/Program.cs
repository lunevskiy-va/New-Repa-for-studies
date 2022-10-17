Console.WriteLine("Введите текст из нескольких предложений, где разделителем будет (.)");
string text = Console.ReadLine();
int size=text.Length;
char[] Arr=new char[size];
text.CopyTo(0, Arr, 0, size);
//Console.WriteLine(Arr);

for (int i = 0; i < size; i++)
{
    if (i == 0)
    {
        Arr[i] = text.ToUpper()[i];
    }

    else if (Arr[i] == '.')
    {
        if (i == size-1)
        {
            break;
        }
        else
        {
            i++;
            i++;
            Arr[i] = text.ToUpper()[i];
        }
    }
    else if (Arr[i] == '!')
    {
        if (i == size - 1)
        {
            break;
        }
        else
        {
            i++;
            i++;
            Arr[i] = text.ToUpper()[i];
        }
    }
    else if (Arr[i] == '?')
    {
        if (i == size - 1)
        {
            break;
        }
        else
        {
            i++;
            i++;
            Arr[i] = text.ToUpper()[i];
        }
    }
   
}
Console.WriteLine(Arr);