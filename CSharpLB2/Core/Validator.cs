using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLB2.Core
{
    public static class Validator
    {
        public static bool Validate(string text)
        {

            if (!string.IsNullOrEmpty(text))
            {
                if(int.TryParse(text, out int i))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
