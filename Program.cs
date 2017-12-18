using System;
using Xperiments.DesignPatterns.Memento.Models;

namespace Xperiments.DesignPatterns.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Historico historico = new Historico();
            Contrato contr = new Contrato(DateTime.Now, "Bruno Lopes", TipoContrato.Novo);

            historico.Adiciona(contr.SalvaEstado());

            contr.Avanca();
            historico.Adiciona(contr.SalvaEstado());

            contr.Avanca();
            historico.Adiciona(contr.SalvaEstado());
            Console.WriteLine(contr.Tipo);


            Console.WriteLine(historico.Pega(0).Contrato.Tipo);
            Console.WriteLine(historico.Pega(1).Contrato.Tipo);
            Console.WriteLine(historico.Pega(2).Contrato.Tipo);

        }
    }
}
