using System;
using System.Collections.Generic;


namespace Xperiments.DesignPatterns.Memento.Models
{

    public class Estado
    {
        public Contrato Contrato { get; private set; }

        public Estado(Contrato contrato)
        {
            this.Contrato = contrato;
        }

        
    }
}
