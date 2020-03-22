using System;
using System.Collections.Generic;
namespace Laborator1
{
    class Args
    {
        public String ThreadName { get; set; }
        public long number { get; set; }
        public List<String> messages { get; set; }

        public Args(string threadName, long number, List<string> messages)
        {
            ThreadName = threadName;
            this.number = number;
            this.messages = messages;
        }
    }
}
