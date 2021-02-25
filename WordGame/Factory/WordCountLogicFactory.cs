using Interface;
using Library.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class WordCountLogicFactory
    {
        public static IWordCountLogic Create(string directory, string wordFilename, string lookupFileName)
        {
            return new WordCountLogic (directory, wordFilename, lookupFileName);
        }

        public static IWordCountLogic Create()
        {
            return new WordCountLogic();
        }
    }
}
