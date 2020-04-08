using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace quran
{
    class Quran
    {
        public string[] ayat = new string[] { "الم	(1)", "ذلك الكتاب لا ريب فيه هدى للمتقين	(2)", "الذين يؤمنون بالغيب ويقيمون الصلاة ومما رزقناهم ينفقون (3)"};



        public List<string> find(string nam)
        {
            List<string> arr = new List<string>();
            Parallel.ForEach<string>(ayat, (curen) => {
                if (curen.Contains(nam))
                {
                    arr.Add(curen);
                }
            });

            return arr;
        }
    }

      
}
