using System;

namespace MyShop.Core.Models
{
    internal class StringLengthAttribute : Attribute
    {
        private int v;

        public StringLengthAttribute(int v)
        {
            this.v = v;
        }
    }
}