using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTH2.LTHDT
{
    class Stack
    {
        private int top;
        private int[] s;
        public bool empty()
        {
            return (top == -1);
        }
        public bool full()
        {
            return (top >= s.Length);
        }
        public Stack()
        {
            s = new int[20];
            top = -1;
        }
        public void push(int x)
        {
            if (!full())
            {
                top = top + 1;
                s[top] = x;
            }
            else
                Console.Write("stack tran");
        }
        public int pop()
        {
            if (empty())
            {
                Console.Write("stack can");
                return 0;
            }
            else
                return s[top--];
        }
    }
}
