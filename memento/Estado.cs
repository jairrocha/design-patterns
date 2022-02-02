﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Estado
    {
        public Contrato Contrato { get; set; }

        public Estado(Contrato contrato)
        {
            Contrato = contrato;
        }

    }
}
