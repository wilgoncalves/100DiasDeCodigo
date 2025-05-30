using System.Net.Mail;

namespace SingleResponsability.SR_Principle;

class Pedido
{
    public int Quantidade { get; set; }
    public DateTime Data { get; set; }
    private ILogger _logger;
    private  EnviarEmail _enviarEmail;

    public Pedido()
    {
        _enviarEmail = new EnviarEmail();
        _logger = new RegistraLog();
    }

    public void IncluirPedido()
    {
        try
        {
            _logger.Info("Incluindo um pedido");
            _enviarEmail.EmailFrom = "wil@gmail.com";
            _enviarEmail.EmailTo = "eduardo@gmail.com";
            _enviarEmail.EmailSubject = "SRP";
            _enviarEmail.EmailBody = "Um";
            _enviarEmail.Enviar();
        }
        catch (Exception ex)
        {
            _logger.Info("Erro ao enviar email: " + ex.Message);
        }
    }

    public void DeletaPedido()
    {
        try
        {
            // código para deletar pedido
            _logger.Info("Pedido deletado em: " + DateTime.Now);
        }
        catch (Exception ex)
        {
            _logger.Info("Erro ao deletar pedido: " + ex.Message);
        }
    }
}
