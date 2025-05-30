using System.Net.Mail;

namespace SingleResponsability.Violation;

class BadPedido
{
    public int Quantidade { get; set; }
    public DateTime Data { get; set; }

    public void IncluirPedido()
    {
        try
        {
            MailMessage mailMessage = new MailMessage(
                "EmailFrom", "EmailTo", "EmailSubject", "EmailBody");

            this.EnviaEmailPedido(mailMessage);
        }
        catch (Exception ex)
        {
            File.WriteAllText(@"C:\Users\wilsa\OneDrive\Desktop\C#\in.txt", ex.ToString());
        }
    }

    public void DeletaPedido()
    {
        try
        {
            // Código para deletar pedido
        }
        catch(Exception ex)
        {
            File.WriteAllText(@"C:\Users\wilsa\OneDrive\Desktop\C#\in.txt", ex.ToString());
        }
    }

    public void EnviaEmailPedido(MailMessage mailMessage)
    {
        try
        {
            // Código para enviar email
        }
        catch(Exception ex)
        {
            File.WriteAllText(@"C:\Users\wilsa\OneDrive\Desktop\C#\in.txt", ex.ToString());
        }
    }
    /* A classe viola o princípio da responsabilidade única pois possui mais de uma
     única responsabilidade */
}
