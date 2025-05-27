namespace Interfaces;

internal class GravaXML : ArquivoBase, IGravar
{
    public void GravarArquivo()
    {
        throw new NotImplementedException();
    }

    public override void Nome()
    {
        Console.WriteLine("Definir nome em GravarXML");
    }
}
