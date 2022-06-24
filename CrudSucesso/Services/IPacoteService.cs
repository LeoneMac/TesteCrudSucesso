using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudSucesso.Models;

namespace CrudSucesso.Services
{
    public interface IPacoteService
    {
        bool Create(Pacote pacote);
        bool Delete(int? id);
        Pacote Get(int id);
        List<Pacote> GetAll();
        bool Update(Pacote pacote);
    }
}
