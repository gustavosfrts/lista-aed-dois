namespace Classe
{
    class lista
    {
        public no? cabeca;
        public no? cauda;
        public int qtdElementos;
        public lista()
        {
            this.cabeca?.setProx(null);
            this.cabeca?.setAnterior(null);
            this.cauda?.setProx(null);
            this.cauda?.setAnterior(null);
            this.qtdElementos = 0;
        }
        public void Retirar(int pos)
        {
            if (this.qtdElementos > 0)
            {
                no posAnterior;
                //comecar pela cabeca
                if ((this.qtdElementos / 2) > pos)
                {
                    no posAtual = this.Buscar(pos);
                    no posProximo = posAtual.getProx();
                    posAnterior = posAtual.getAnterior();
                    posAnterior.setProx(posProximo);
                    posProximo.setAnterior(posAnterior);
                }
                //comecar pela cauda
                else
                {
                    no posAtual = this.Buscar(pos);
                    no posProximo = posAtual.getProx();
                    posAnterior = posAtual.getAnterior();
                    posAnterior.setProx(posProximo);
                    posProximo.setAnterior(posAnterior);
                }
                this.qtdElementos--;
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
        public no getFirst()
        {
            return this.cabeca;
        }
        public no getLast()
        {
            return this.cauda;
        }
        public void insertFirst(string informacao)
        {
            no primeiro = new no(informacao, this.qtdElementos);
            no? cabecaAntiga = this.cabeca;
            if (cabecaAntiga?.getInformacao() == null)
            {
                this.cabeca = primeiro;
            }
            else
            {
                if(this.cauda == null){
                    this.cabeca = primeiro;
                    this.cauda = cabecaAntiga;
                    this.cabeca.setAnterior(this.cauda);
                    this.cauda.setProx(this.cabeca);
                }
                else
                {
                    this.cabeca = primeiro;
                    this.cabeca.setAnterior(cabecaAntiga);
                    cabecaAntiga.setProx(this.cabeca);
                }
            }
            this.qtdElementos++;
        }
    }

    class no
    {
        private string? informacao;
        private no? anterior;
        private no? prox;
        private int posicao;
        public int getPosicao() { return this.posicao;}
        public void setPosicao(int p) { this.posicao = p; }
        public no getAnterior() { return this.anterior;}
        public void setAnterior(no? a) { this.anterior = a; }
        public no getProx() { return this.prox; }
        public void setProx(no? p) { this.prox = p; }
        public string getInformacao() { return this.informacao; }
        public void setInformacao(string i) { this.informacao = i; }

        public no (string informacao, int posicao)
        {
            this.informacao = informacao;
            this.anterior = null;
            this.prox = null;
            this.posicao = posicao;
        }
    }

}