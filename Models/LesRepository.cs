using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MentiMeterTest.Models
{
    public interface IRepository
    {
        Vraag GetVraagById(int lesId, int vraagId);
        List<Vraag> GetVragen();

        List<Les> GetAlleLessen();

        Vraag GetNextVraag(int previousVraagId);
    }
    public class LesRepository:IRepository
    {
        List<Les> lessen;
        List<Vraag> vragen;

        public LesRepository()
        {
            lessen = new List<Les>();
            Les les = new Les() { LesId = 1 };
            vragen = new List<Vraag>();
            vragen.Add(new Vraag() { VraagId = 1, Text = "Hoeveel is 1 + 1" });
            vragen.Add(new Vraag() { VraagId = 2, Text = "Hoeveel is 2+2" });
            les.Vragen = vragen;
            lessen.Add(les);

        }

        public Vraag GetVraagById(int lesId, int vraagId)
        {
            var vraag = lessen[0].Vragen.Where(v => v.VraagId == vraagId).Single();

            return vraag;

        }

        public List<Vraag> GetVragen()
        {
            return lessen[0].Vragen;
        }

        public List<Les> GetAlleLessen()
        {
            return lessen;
        }

        public Vraag GetNextVraag(int previousVraagId)
        {
            var vraag = lessen[0].Vragen.Where(v => v.VraagId == previousVraagId + 1).Single();
            return vraag;
            //if (previousVraagId + 1 < lessen[0].Vragen.Count)
              //  return lessen[0].Vragen[previousVraagId++];
           // return null;
        }
    }
}
