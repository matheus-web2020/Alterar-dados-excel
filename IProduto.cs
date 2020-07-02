using System.Collections.Generic;

namespace Aula30_POO
{
    public interface IProduto 
    {
        void Criar(Produto _produto);
        List<Produto> Ler();
        void Remover(string _termo);
        void Alterar(Produto _produtoAlterado);
    }
}