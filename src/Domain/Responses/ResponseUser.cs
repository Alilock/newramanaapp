﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Responses
{
    public class ResponseUser
    {
        public int StatusCode { get; set; } 
        public string Message { get; set; } = null!;
        public string? Token { get; set; }
    }
}
