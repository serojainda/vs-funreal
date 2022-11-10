﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUnrealTest
{
    public static class FAssert
    {   
        /// <summary>
        /// AreEqual and Not null
        /// </summary>
        public static void AreEqualNN(object o1, object o2)
        {
            if (o1 == null && o2 == null) Assert.Fail("AreEqualNN: Both values are null!");
            else Assert.AreEqual(o1, o2);
        }
    }
}
