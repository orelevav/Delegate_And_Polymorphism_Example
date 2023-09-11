using System;


namespace DelegateAppl
{

    public class TestDelegate
    {
        private int num = 1;
        public  int AddNum(int p)
        {
            num += p;
            return num;
        }

        public int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public int getNum()
        {
            return num;
        } 
    }
}