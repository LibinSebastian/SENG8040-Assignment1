using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040_Assignment_1
{
    public class Rect
    {
        private int len;
        private int wid;

        public Rect()
        {
            wid = 1;
            len = 1;
        }


        public Rect(int len, int wid)
        {
            this.len = len;
            this.wid = wid;
        }


        public int GetWid()
        {
            return wid;
        }


        public int GetLen()
        {
            return len;
        }


        public int SetLen(int len)
        {
            this.len = len;
            return this.len;
        }

        public int SetWid(int wid)
        {
            this.wid = wid;
            return this.wid;
        }
        public int GetArea()
        {
            return wid * len;
        }
        public int GetPeri()
        {
            return (len * 2) + (wid * 2);
        }

    }
}
