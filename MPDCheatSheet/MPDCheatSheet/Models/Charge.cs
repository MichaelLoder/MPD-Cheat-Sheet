using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MPDCheatSheet.Models
{
    public class Charge
    {
        public string Name { get; set; }
        public double Sentence { get; set; }
        public double ArgSentence { get; set; }
        public bool HasArgSentence { get; set; }
    }
}