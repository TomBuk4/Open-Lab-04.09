using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            string[] RemoveAllDuplicate = strings.Distinct().ToArray();
            return RemoveAllDuplicate;
        }
    }
}
