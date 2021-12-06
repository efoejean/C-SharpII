using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pubApp
{
    class Publication
    {

        public string Title { get; set; }
        public int Year { get; set; }
        public bool Read { get; set; }

        public Publication(String t, int y)
        {
            Title = t;
            Year = y;                      
            Read = false;
        }


        public  virtual string GetInfo()
        {
            string info = string.Empty;
            info += "Title: " + Title + "\n";
            info += "Publication Year: " + Year + "\n";
            info += "Read: " + Read + "\n";
            return info;
        }

    }
}
