﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rights.Entity.ViewModel
{
    [Serializable]
    public class FirstLoginRequest
    {
        public int Id { get; set; }

        public string NewPwd { get; set; }

    }
}
