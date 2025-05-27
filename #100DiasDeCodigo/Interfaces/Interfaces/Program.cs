using Interfaces;

GravaXML gravar = new GravaXML();
gravar.GravarArquivo();
gravar.Nome();

// usando interface
IGravar igravar = new GravaXML();
igravar.GravarArquivo();
/* igravar.Nome(); - a instância da interface
não permite o acesso a membros da classe. */