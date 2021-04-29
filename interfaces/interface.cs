using System.Collections.Generic;
using App_cadastro.classes;

namespace App_cadastro.interfaces
{
    public interface Irepositorio<T>
    {
      List<T> Lista();

      T RetornaPorId(int id);

      T RetornaPorId2(int id);

      void Insere(T entidade);

      void Exclui(int id);

      void Atualiza(int id, T entidade);

      int ProximoId();
        void InsereFilme(Filmes entidade);
    }
}