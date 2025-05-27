namespace Interfaces;

internal class GravarJson : ArquivoBase, IGravar
{
    public void GravarArquivo()
    {
        throw new NotImplementedException();
    }

    public override void Nome()
    {
        Console.WriteLine("Definir nome em GravarJson");
    }
}
