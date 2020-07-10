using System;

namespace Strategy
{
    class Context
    {
        private IStrategy IStrategy;
        public Context(IStrategy IStrategy)
        {
            this.IStrategy = IStrategy;
        }
        
        public Context()
        {
            
        }

        public void SetStrategy(IStrategy IStrategy)
        {
            this.IStrategy = IStrategy;
        }

        public int[] ExecuteStrategy(int[] input)
        {
            return IStrategy.Sort(input);
        }
    }
}