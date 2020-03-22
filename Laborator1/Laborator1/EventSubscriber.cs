using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator1
{
    class EventSubscriber
    {
        public virtual void PrintEncryptedText(object source, CustomEvent args)
        {
            Console.WriteLine(args.CryptoText);
        }
    }
}
