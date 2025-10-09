using GeometriaModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.DALs
{
    public  interface IFigurasDAL
    {
        List<FiguraModel> GetAll();

        FiguraModel GetById(int id);

        FiguraModel Add(FiguraModel nuevo);

        FiguraModel Save(FiguraModel entidad);

        void Remove(int id );

    }
}
