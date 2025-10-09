using GeometriaModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.DALs
{
    public class FiguraListDAL : IFigurasDAL
    {

        List<FiguraModel> Figuras = new List<FiguraModel>();

        public FiguraModel Add(FiguraModel figura)
        {
            figura.Id = GenId();
            Figuras.Add(figura);
            return figura;



        }

        public List<FiguraModel> GetAll()
        {
            return Figuras;
        }

        public FiguraModel? GetById(int id)
        {
            return (from F in Figuras 
                    where F.Id==id
                    select F ).FirstOrDefault();


        }

        public void Remove(int id)
        {
            
        }

        public FiguraModel? Save(FiguraModel entidad)
        {

            entidad.Id = GenId();
            Figuras.Add(entidad);
            return entidad;
        }
        protected int? GenId()
        {
            return (from f in Figuras select f.Id).DefaultIfEmpty(0).Max() + 1;
        }
    }
}
