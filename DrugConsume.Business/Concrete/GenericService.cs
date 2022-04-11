using DrugConsume.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrugConsume.Business.Concrete
{
    public class GenericService
    {
        public static List<GenericOfDrug> ListGenericDatas(string filePath)
        {
            List<GenericOfDrug> genericDatas = new List<GenericOfDrug>();
            string[] lines = File.ReadAllLines(filePath + @"\ilaç-jenerik bilgileri.xls", Encoding.GetEncoding("iso-8859-9"));
            foreach (string line in lines)
            {
                GenericOfDrug genericOfDrug = new GenericOfDrug();
                string[] split = line.Split(Convert.ToChar(9));
                genericOfDrug.DrugName = split[0];
                genericOfDrug.GenericName = split[1];
                genericDatas.Add(genericOfDrug);
            }
            return genericDatas;
        }
    }
}
