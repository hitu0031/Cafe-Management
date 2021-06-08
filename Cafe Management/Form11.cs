using System;

namespace Cafe_Management
{
    internal class Form1
    {
        public Form1(string v)
        {
            V = v;
        }

        public string V { get; }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}