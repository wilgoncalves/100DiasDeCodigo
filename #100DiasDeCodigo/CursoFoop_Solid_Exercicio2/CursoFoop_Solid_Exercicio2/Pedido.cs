using System;

namespace CursoFoop_Solid_Exercicio2
{
    public class Pedido
    {
        private ILogger _logger;

        public Pedido(ILogger logger)
        {
            _logger = logger;
        }

        public virtual void AdicionarPedido()
        {
            try
            {
                //código para validar e incluir pedido
                _logger.Registrar($"Pedido Incluido em :  {DateTime.Now}");
            }
            catch (Exception ex)
            {
                _logger.Registrar($"{ex} - {DateTime.Now}");
            }
        }
    }
}
