namespace Classe
{
    class Pilha
    {
        public no? cabeca;
        public no? cauda;
        public int qtdElementos;
        public Pilha()
        {
            this.cabeca?.setProx(null);
            this.cabeca?.setAnterior(null);
            this.cauda?.setProx(null);
            this.cauda?.setAnterior(null);
            this.qtdElementos = 0;
        }
        public void Retirar()
        {
            if (this.qtdElementos > 0)
            {
                no? cabecaNova = this.cabeca?.getAnterior();
                this.cabeca?.setAnterior(null);
                cabecaNova?.setProx(null);
                this.cabeca = cabecaNova;
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
}