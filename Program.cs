using Classe;

Pilha pilha = new Pilha();
Fila fila = new Fila();

// Teste de Pilha (First in First Out ou FIFO)
pilha.Inserir("Teste");
pilha.Inserir("Teste1");
pilha.Inserir("Teste2");
pilha.Inserir("Teste3");
pilha.Inserir("Teste4");

// Teste de Fila (First in Last out ou FILO)
fila.Inserir("Teste");
fila.Inserir("Teste1");
fila.Inserir("Teste2");
fila.Inserir("Teste3");
fila.Inserir("Teste4");

// Teste retirando valores da Pilha
Console.WriteLine(pilha.cabeca?.getInformacao());
Console.WriteLine(pilha.cauda?.getInformacao());
pilha.Retirar();
Console.WriteLine(pilha.cabeca?.getInformacao());
Console.WriteLine(pilha.cauda?.getInformacao());

// Teste retirando e inserindo valores da Fila
Console.WriteLine(fila.cabeca?.getInformacao());
Console.WriteLine(fila.cauda?.getInformacao());
fila.Retirar();
Console.WriteLine(fila.cabeca?.getInformacao());
Console.WriteLine(fila.cauda?.getInformacao());
fila.Inserir("Teste5");
Console.WriteLine(fila.cabeca?.getInformacao());
Console.WriteLine(fila.cauda?.getInformacao());