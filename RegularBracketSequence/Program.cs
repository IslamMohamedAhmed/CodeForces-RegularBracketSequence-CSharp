using static System.Console;
using static System.Convert;
using static System.Math;


string str;
int counter = 0;

str = ReadLine();
int size  = str.Length;
for(int i = 0; i < str.Length; i++)
{
    char ch  = str[i];
    if (ch == '(')
    {
        counter++;
    }
    else
    {
        if(counter == 0) {
            size--;
        }
        else
        {
            counter--;
        }
    }
}

WriteLine(size-counter);