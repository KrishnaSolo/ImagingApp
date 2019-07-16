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
                a = a.ToUpperInvariant();
                b = b.ToUpperInvariant();
            }

            if (a == "Krishna" && b == "507136")
            {
                return "Login accepted";
            }
            else
                return "failed login"; 
        }
    }
}
                
            