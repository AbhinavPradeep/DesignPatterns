using System;

namespace Command
{
    using System;
    public class VCRPlayCommand : ICommand
    {
        public VCRPlayCommand()
        {
        }
        public void Execute()
        {
            Console.WriteLine("VCR Started.");
        }
    }
}