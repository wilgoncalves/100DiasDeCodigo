// Modificadores de acesso
// public, private, protected, internal, protected internal, private protected

public abstract class Payment
{
    public DateTime ExpiredDate;

    // PUBLIC - Pode ser acessado em qualquer lugar de nossa aplicação.
    public void Pay()
    {

    }

    // PRIVATE - permite o acesso apenas dentro da própria classe.
    private void PayDay()
    {

    }

    // PROTECTED - permite o acesso apenas nas classes filhas (classes que herdam da classe Pay).
    protected void PayMonth()
    {

    }

    // INTERNAL - só poderá ser acessado dentro do mesmo assembly.
    internal void PayYear()
    {

    }

    // PROTECTED INTERNAL - só será acessado pelo mesmo assembly e classes filhas.
    protected internal void PayMonthYear()
    {

    }

    // PRIVATE PROTECTED - apenas será acessado na mesma classe e classes filhas.
    private protected void PayMonthDay()
    {

    }
}


public class Billing : Payment
{
    void SetBilling()
    {
        base.PayMonth();
    }
}
