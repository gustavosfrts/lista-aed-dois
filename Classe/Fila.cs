namespace Classe
{
    class Fila
    {
        public no? cabeca;
        public no? cauda;
        public int qtdElementos;
        public Fila()
        {
            this.cabeca?.setProx(null);
            this.cabeca?.setAnterior(null);
            this.cauda?.setProx(null);
            this.cauda?.setAnterior(null);
            this.qtdElementos = 0;
        }
        public void Retirar()
        {
            // só irá remover se possuir algo dentro da Fila.
            if (this.qtdElementos > 0)
            {
                no? cabecaNova = this.cabeca?.getAnterior(); //Pega o anterior da cabeça
                this.cabeca?.setAnterior(null); //Seta o anterior do atual 'cabeça' como nulo, para nao conseguir acessar ele
                cabecaNova?.setProx(null); //Seta o proximo da atual cabeça como nulo também, para perder referencia e nao conseguir ir para este antigo cabeça
                this.cabeca = cabecaNova; //Seta a nova cabeça
                this.qtdElementos--; //remove o total de elementos em 1
            }
        }
        public no? Buscar(int pos)
        {
            no? buscar = null;
            
            if (this.qtdElementos > 0)
            {
                //comecar pela cabeca
                if (pos > (this.qtdElementos / 2))
                {
                    buscar = cabeca;
                    for (int i = 0; i < pos; i++)
                    {
                        if (buscar?.getPosicao() == pos)
                        {
                            break;
                        }
                        buscar = buscar?.getAnterior();
                    }
                }
                //comecar pela cauda
                else
                {
                    buscar = cauda;
                    for (int i = 0; i < pos; i++)
                    {
                        if (buscar?.getPosicao() == pos)
                        {
                            break;
                        }
                        buscar = buscar?.getProx();
                    }
                }
            }
            
            return buscar;
        }
        public no? getFirst()
        {
            return this.cabeca;
        }
        public no? getLast()
        {
            return this.cauda;
        }
        public void Inserir(string informacao)
        {
            no ultimoFila = new no(informacao, this.qtdElementos);
            no? ultimoAntigo = this.cauda;
            if (ultimoAntigo?.getInformacao() == null)
            {
                this.cauda = ultimoFila;
            }
            else
            {
                if (this.cabeca?.getInformacao() == null)
                {
                    this.cabeca = ultimoAntigo;
                    this.cauda = ultimoFila;
                    this.cabeca.setAnterior(this.cauda);
                    this.cauda.setProx(this.cabeca);
                }
                else
                {
                    this.cauda = ultimoFila;
                    this.cauda.setProx(ultimoAntigo);
                    ultimoAntigo.setAnterior(this.cauda);
                }
            }
            this.qtdElementos++;
        }
    }
}