﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrl.Services
{
    public interface IEncodeService
    {
        string Encode(string url);
    }
}
