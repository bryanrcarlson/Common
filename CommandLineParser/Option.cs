using System;
using System.Collections.Generic;
using System.Text;

namespace CommandLineParser
{
    public class Option
    {
        public string Short { get; set; }
        public string Long { get; set; }
        public string Description { get; set; }
        protected string Value { get; set; }
    }
}
