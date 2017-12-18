using System;
using System.Collections.Generic;


namespace Xperiments.DesignPatterns.Memento.Models
{

    public class Historico
    {
        private IList<Estado> Estado = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            this.Estado.Add(estado);
        }

        public Estado Pega(int indice)
        {
            return Estado[indice];
        }
        
    }
}
