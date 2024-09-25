using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Works.Models;

namespace Works
{
    internal class SavingDate
    {
        public static List<Клиенты>  klient=Helper.user.Клиентыs.ToList();
        public static List<Posehenium> posehs = Helper.user.Posehenia.ToList();
        public static List<Visit> visits = Helper.user.Visits.ToList();
    }
}
