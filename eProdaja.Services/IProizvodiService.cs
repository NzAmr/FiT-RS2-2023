﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface IProizvodiService
    {
        IEnumerable<Proizvodi> Get();
        public Proizvodi GetById(int id);
    }
}
