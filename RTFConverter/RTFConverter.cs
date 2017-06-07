using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTFConverter
{
    abstract class TextConverter
    {
        public abstract void ConvertBold(bool hasBold);
        public abstract void ConvertItalic(bool hasItalic);

    }
}
