﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoologico.Interface;

namespace Zoologico.classes
{
    public class TratadorMamiferos : Tratador, ICuidavel
    {
        public TratadorMamiferos(string nome, string especialidade)
            : base(nome, especialidade) { }

        public void Cuidar()
        {
            Console.WriteLine($"{Nome} está cuidando dos mamíferos");
        }
    }
}
