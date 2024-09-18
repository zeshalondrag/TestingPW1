using System.Linq;

namespace Password
{
    public class Pass
    {
        public int CheckPassword(string password)
        {
            int score = 0;
            if (password.Any(char.IsNumber)) score++;
            if (password.Any(char.IsLower)) score++;
            if (password.Any(char.IsUpper)) score++;
            if (password.Any(c => char.IsPunctuation(c) || char.IsSymbol(c))) score++;
            if (password.Length >= 10) score++;
            return score;
        }
    }
}