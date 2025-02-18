using System.Linq;

bool IsPalindrome(string s)
{
    int l = 0; int r = s.Length - 1;

    while (l < r)
    {
        if (!Char.IsLetterOrDigit(s[l]))
        {
            l++;
            continue;
        }

        if (!Char.IsLetterOrDigit(s[r]))
        {
            r--;
            continue;
        }


        if (Char.ToLower(s[l]) != Char.ToLower(s[r]))
        {
            return false;
        }

        l++;
        r--;

    }

    return true;
}

Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));

Console.WriteLine(IsPalindrome("race a car"));

Console.WriteLine(IsPalindrome(" "));