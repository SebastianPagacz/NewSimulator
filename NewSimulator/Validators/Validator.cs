using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSimulator;

public static class Validator
{   
    public static string StringValidator(string value, int min, int max, char placeholder)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return "Unknown";
        }

        string trimmed = value.Trim();
        
        if (trimmed.Length > max) 
        {
            trimmed = trimmed.Substring(min, max).Trim();
        }

        while (trimmed.Length < min)
        {
            trimmed += placeholder;
        }

        if (char.IsLower(trimmed[0]))
        {
            trimmed = char.ToUpper(trimmed[0]) + trimmed.Substring(1);
        }

        return trimmed;
    }

    public static int Limiter(int value, int min, int max)
    {
        if (value <= min)
            return min;
        if (value >= max)
            return max;
        return value;
    }
}
