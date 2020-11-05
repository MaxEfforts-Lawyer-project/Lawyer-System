using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lawyer_System.Areas
{
    public static class ApplicationManager
    {
      public  enum LawsuitType
        {
            MadanyKoly = 0,
            MadanyGoz2y = 1,
            Est2naf = 2,
            Gon7 = 3,
            Kda2Edary = 4,
        }
       public static Dictionary<string, string> LawsuitTypDictionary = new Dictionary<string, string>()
       {
            { LawsuitType.MadanyKoly.ToString() , "مدنى كلى" },
            { LawsuitType.MadanyGoz2y.ToString(), "مدنى جزئى" },
            {LawsuitType.Est2naf.ToString(), "استئناف" },
            {LawsuitType.Gon7.ToString(), "جنح" },
            {LawsuitType.Kda2Edary.ToString(), "قضاء ادارى" },
        };

        public enum MadanyGoz2yTyp
        {
            MadanyGoz2y = 0,
            sa7tTaw2e3 = 1,
            family = 2,

        }
        public static Dictionary<string, string> LawsuitTypDictionarymadanygoz2y = new Dictionary<string, string>()
        {
            {MadanyGoz2yTyp.MadanyGoz2y.ToString(), "مدنى جزئى"},
            { MadanyGoz2yTyp.sa7tTaw2e3.ToString(), "صحة توقيع" },
            { MadanyGoz2yTyp.family.ToString(), "اسرة" }
            };
       public enum MadanyKolyType
        {
            MadanyKoly = 0,
            fast = 1,
            MadanyMost2nf = 2,
            Egarat = 3,
            Polise = 4,
        }


        public static Dictionary<string, string> LawsuitTypDictionarymadanykoly = new Dictionary<string, string>()
        {
            { MadanyKolyType.MadanyKoly.ToString(), "مدنى كلى" },
            { MadanyKolyType.fast.ToString(), "مستعجل" },
            { MadanyKolyType.MadanyMost2nf.ToString(), "مدنى مستأنف" },
            { MadanyKolyType.Egarat.ToString(), "ايجارات" },
            { MadanyKolyType.Polise.ToString(), "حكومة" }
        };
    }
}
