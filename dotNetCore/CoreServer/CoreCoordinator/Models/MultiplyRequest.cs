﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CoreCoordinator.Models
{
    [DataContract]
    public class MultiplyRequest
    {
        [DataMember(Order = 1)]
        public int X { get; set; }

        [DataMember(Order = 2)]
        public int Y { get; set; }
    }
}
