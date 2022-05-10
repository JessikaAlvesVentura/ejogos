using ejogos.Models;
using System.Collections.Generic;

namespace ejogos.Interface
{
    public interface IEquipe
    {
        //contrato representa os métodos que são obrigatórios em uma classe.

        void Criar(equipe novaequipe);
        List<equipe> Lerequipes();
    }
}
