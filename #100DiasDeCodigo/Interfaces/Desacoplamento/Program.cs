

using Desacoplamento;

var registrarOcorrenciasConsole = 
    new RegistraOcorrencias(new RegistrarNoConsole());

registrarOcorrenciasConsole.Registrar("registro console");

var registraOcorrenciasArquivo =
    new RegistraOcorrencias(new RegistrarNoArquivo(@"C:\Users\wilsa\OneDrive\Desktop\C#\in.txt"));

registraOcorrenciasArquivo.Registrar("registro arquivo");
