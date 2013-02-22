using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace BindingFoo
{
    public class Foo
    {
        [DllImport("__Internal", CallingConvention = CallingConvention.Cdecl)]
        public static extern int CallFoo();
    }
}
