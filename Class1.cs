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
                var rawa = raw.ToUpperInvariant(a);
                var rawb = raw.ToUpperInvariant(b);
            }

            if (rawa == "Krishna" && rawb == "507136")
            {
                return "Login accepted";
            }
            else
                return "failed login"; 
        }
    }
}
                
            