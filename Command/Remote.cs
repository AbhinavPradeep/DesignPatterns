using System;

namespace Command
{
    public class Remote
    {
        public Remote()
        {
        }
        public void Invoke(ICommand cmd)
        {
            Console.WriteLine("Invoking.......");
            cmd.Execute();
        }
    }
}