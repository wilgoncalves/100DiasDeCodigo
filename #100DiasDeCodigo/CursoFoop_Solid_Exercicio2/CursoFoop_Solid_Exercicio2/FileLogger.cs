using System.IO;

namespace CursoFoop_Solid_Exercicio2
{
    internal class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            File.WriteAllText(@"C:\Users\wilsa\OneDrive\Desktop\C#\in.txt", mensagem);
        }
    }
}
