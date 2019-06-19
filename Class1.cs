using System.Text;
using System;
namespace Core
{
    public static class Splice
    {
        public static string Login(string a, string b)
        {
            if (string.IsNullOrWhiteSpace(a) || string.IsNullOrWhiteSpace(b))
            {
                return "Did not enter username or password!";
            }

            else
            {
                rawa = raw.ToUpperInvariant(a);
                rawb = raw.ToUpperInvariant(b);
            }