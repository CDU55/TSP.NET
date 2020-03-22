using System;

namespace Laborator1
{
    class EventProducer
    {
        public delegate void OnEncryption(object source, CustomEvent args);
        public event OnEncryption Encrypted;
        public event EventHandler<CustomEvent> Encrypted2;
        public String Substract(String plaintext)
        {
            char[] txt = plaintext.ToCharArray();
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == 'z')
                {
                    txt[i] = 'a';
                }
                else if (txt[i] == 'Z')
                {
                    txt[i] = 'A';
                }
                else
                {
                    txt[i] += (char)1;

                }
            }
            if (Encrypted != null)
            {
                Encrypted(this, new CustomEvent(new string(txt)));
            }
            return new string(txt);
        }
    }
}
