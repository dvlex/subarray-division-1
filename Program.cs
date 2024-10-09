// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<int> s = [4];
int d = 4;
int m = 1;

int result = Result.birthday(s, d, m);
System.Console.WriteLine(result);
class Result
{

    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        int result = 0;
        int length = s.Count() - m;
        for (int i = 0; i <= length; i++)
        {
            if (s.GetRange(i, m).Sum() == d)
            {
                result++;
            }
        }
        return result;
    }

}