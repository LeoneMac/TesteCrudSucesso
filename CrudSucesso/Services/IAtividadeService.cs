using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudSucesso.Models;

namespace CrudSucesso.Services
{
    public interface IAtividadeService
    {
        bool Create(Atividade atividade);
        bool Delete(int? id);
        Atividade Get(int id);
        List<Atividade> GetAll();
        bool Update(Atividade atividade);
    }
}
