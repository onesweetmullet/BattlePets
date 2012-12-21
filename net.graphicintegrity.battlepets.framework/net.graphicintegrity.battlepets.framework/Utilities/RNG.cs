using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.graphicintegrity.battlepets.framework.Utilities
{
    public static class RNG
    {
        public static int GetRandomNumber(int minValue, int maxValue)
        {
            return new Random().Next(minValue, maxValue);
        }

        public static int GetRandomNumber(int minValue, int maxValue, int seed)
        {            
            return new Random(seed).Next(minValue, maxValue);
        }
    }
}
