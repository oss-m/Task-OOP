﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universties
{
    public interface I_Operations<T>
    {
        List<Operations<T>> Add(List<Operations<T>> Group);
        List<Operations<T>> Create(List<Operations<T>> Group);
    }
}
