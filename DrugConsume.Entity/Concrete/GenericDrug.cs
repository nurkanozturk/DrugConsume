using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugConsume.Entity.Concrete
{
    public class GenericDrug
    {
        public string Name { get; set; }
        public string DrugName { get; set; }
        public decimal UnitPrice { get; set; }
        public int EntryAmount { get; set; }
        public int ExitAmount { get; set; }
        public int Amount { get; set; }
        public int Consume { get; set; }
        public int DayLeft { get; set; }
        public int OcakTuketim { get; set; }
        public int SubatTuketim { get; set; }
        public int MartTuketim { get; set; }
        public int NisanTuketim { get; set; }
        public int MayisTuketim { get; set; }
        public int HaziranTuketim { get; set; }
        public int TemmuzTuketim { get; set; }
        public int AgustosTuketim { get; set; }
        public int EylulTuketim { get; set; }
        public int EkimTuketim { get; set; }
        public int KasimTuketim { get; set; }
        public int AralikTuketim { get; set; }
        public int TuketimHizi { get; set; }
    }
}
