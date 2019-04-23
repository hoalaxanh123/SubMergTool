using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubMasterTool
{
    public class Sub
    {
        public int Number { get; set; }
        public string Time { get; set; }
        public string Content { get; set; }

        public Sub(int Number, string Time, string Content)
        {
            this.Number = Number;
            this.Time = Time;
            this.Content = Content;
        }
        public Sub()
        {
         
        }
    }
}
