﻿using Interface;
using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public static class WordCountFactory
    {
        public static IWordCounter Create()
        {
            return new WordCounter();
        }
    }

}
