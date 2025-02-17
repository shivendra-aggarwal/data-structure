bool IsSubsequence(string s, string t)
{
    int i = 0, l = 0;

    while(i < s.Length && l < t.Length)
    {
        if (s[i] == t[l])
            i++;
        l++;
    }

    return i == s.Length;
}

Console.WriteLine(IsSubsequence("axc", "ahbgdc").ToString());