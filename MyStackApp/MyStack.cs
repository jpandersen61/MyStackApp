using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStackApp
{
    public  class MyStack
    {
        public int Size { get; set; }
        public int[] Stack;
        int _top;
        public MyStack(int size)
        {
            _top = 0;
            Stack = new int[size];
        }
        public int Pop()
        {
            
            //todo: throw MyStackIsEmptyException if stack is empty

            _top--;
            int result = Stack[_top];
            Stack[_top] = 0;
            return result;
        }
        public void Push(int element)
        {
            //todo: throw MyStackIsFullException if stack is full
            
            Stack[_top] = element;
            _top++;
        }
    }
}
