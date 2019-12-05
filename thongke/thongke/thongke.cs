using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thongke
{
    public class thongke
    {
        public MONHOC[] getMONOC()
        {
            var db = new sqlthongkeEntities();
            return db.MONHOCs.ToArray();
        }
        public MONHOC getMONHOC(int id)
        {
            var db = new sqlthongkeEntities();
            return db.MONHOCs.Find(id);
        }
        public KETQUA[] getKETQUA()
        {
            var db = new sqlthongkeEntities();
            return db.KETQUAs.ToArray();
        }

    }
}
