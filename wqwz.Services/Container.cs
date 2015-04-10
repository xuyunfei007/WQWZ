using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wqwz.Services
{
    public static class Container
    {
        private static wqwz.Models.wqwzContainer instance;
        public static wqwz.Models.wqwzContainer GetContainerInstance()
        {
            if (instance == null)
            {
                instance = new Models.wqwzContainer();
            }
            return instance;
        }
    }
}