using System;
namespace EtiquetaDePreco.Entidades.Execao
{
    internal class ExecaoDominio : ApplicationException
    {
        public ExecaoDominio(string message) : base(message)
        {

        }
    }
}
