using System.IO;


public class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader("input.txt");
        StreamWriter sw = new StreamWriter("output.txt");

        string str1 = sr.ReadLine();
        string str2 = sr.ReadLine();

        int[] mas = new int[10];

        int[] s1;
        int[] s2;

        //Console.WriteLine(str1);
        //Console.WriteLine(str2);

        WriteTimeInMas(out s1, str1);
        WriteTimeInMas(out s2, str2);

        while (!Compare(s1, s2))
        {
            CountNum(ref mas, s1);
            Inc(ref s1);
        }
        CountNum(ref mas, s2);

        for (int k = 0; k < 10; k++)
        {
            sw.WriteLine("{0}", mas[k]);
            //Console.WriteLine(mas[k]);
        }

        sr.Close();
        sw.Close();
        //Console.ReadLine();


    }

    static void WriteTimeInMas(out int[] s, string str)
    {
        s = new int[6];

        int k = 0;
        foreach (char i in str)
        {
            if (i != ':')
            {
                s[k] = i;
                s[k] -= 48;
                k++;
            }
        }
    }
    static void CountNum(ref int[] mas, int[] s)
    {
        for (int k = 0; k < 6; k++)
        {
            mas[s[k]]++;
        }
    }
    static bool Compare(int[] s1, int[] s2)
    {
        for (int k = 0; k < 6; k++)
            if (s1[k] != s2[k])
                return false;
        return true;
    }
    static void Inc(ref int[] s)
    {
        int hour = s[0] * 10 + s[1];
        int min = s[2] * 10 + s[3];
        int sec = s[4] * 10 + s[5];
        sec++;
        if (sec == 60)
        {
            s[5] = 0;
            s[4] = 0;
            min++;
            if (min == 60)
            {
                s[3] = 0;
                s[2] = 0;
                hour++;
                if (hour == 24)
                {
                    s[0] = 0;
                    s[1] = 0;
                }
                else
                {
                    s[0] = hour / 10;
                    s[1] = hour % 10;
                }
            }
            else
            {
                s[2] = min / 10;
                s[3] = min % 10;
            }
        }
        else
        {
            s[4] = sec / 10;
            s[5] = sec % 10;  
        }

    }
}

