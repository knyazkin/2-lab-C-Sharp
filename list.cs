using System;

namespace listik
{
    public class list
    {
        
        private int val;
        private bool dupl;

        public void setVal (int x)
        {
            val=x;
        }
        public int getVal()
        {
            return(val);
        }
        public void setDupl (bool b)
        {
            dupl=b;
        }
        public bool getDupl ()
        {
            return(dupl);
        }

        public list ()
        {
            val = 0;
            dupl = false;
        }

        public list (int _val, bool _dupl)
        {
            val = _val;
            dupl = _dupl;
        }

    }
}