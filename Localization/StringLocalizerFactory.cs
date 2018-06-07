using StringLocalizerFactoryCreateDemo.Models;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringLocalizerFactoryCreateDemo.Localization
{
    public class StringLocalizerFactory : IStringLocalizerFactory
    {
        public IStringLocalizer Create(Type resourceSource)
        {
            if (resourceSource == typeof(SomeModel))
            {
                // set a debug breakpoint on the below line - it should be executed at least n + 1 times
                var x = 1;
            }

            return new StringLocalizer();
        }

        public IStringLocalizer Create(string baseName, string location)
        {
            return new StringLocalizer();
        }
    }
}
