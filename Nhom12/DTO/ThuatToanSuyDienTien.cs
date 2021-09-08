using Nhom12.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom12.DTO
{
    public class ThuatToanSuyDienTien
    {
        Luat r = new Luat();
        List<String> TG = new List<string>();// chứa các sự kiện nhận giá trị True
        List<Luat> SAT = new List<Luat>();// chứa các luật thỏa( là luật có vế trái bằng true)
        List<Luat> R = new List<Luat>();//Tập luật

        public List<GiaiThich> giaiThich = new List<GiaiThich>();

        public ThuatToanSuyDienTien(List<String> TG, List<Luat> R)
        {
            this.TG = TG;
            this.R = new List<Luat>(R);
        }

        public List<String> ThuatToan()
        {
            giaiThich.Clear();
            checkAddSAT(TG);

            //add giaiThich
            giaiThich.Add(new GiaiThich(r, TG.ToList(), SAT.ToList(), R));

            while (SAT.Count != 0)
            {
                r = SAT[0];
                checkExistAndAdd(TG, r.VePhai);
                removeRules();
                SAT.RemoveAt(0);
                checkAddSAT(TG);

                giaiThich.Add(new GiaiThich(r, TG.ToList(), SAT.ToList(), R));
            }
            return TG;
        }

        private void checkAddSAT(List<String> TG)
        { 
            for(int i=0; i < R.Count-1; i++)
            {   
                int dem = 0;
                String[] veTrai = R[i].VeTrai.Split('^');
                for(int j = 0; j < veTrai.Length; j++)
                {
                    for(int k = 0; k < TG.Count; k++)
                    {
                        if (veTrai[j] == TG[k])
                            dem++;
                    }
                }
                if (dem == veTrai.Length)
                    SAT.Add(R[i]);
            } 
        }
        //kiểm tra xem vế phải đã tồn tại kết luận hay chưa
        private void checkExistAndAdd(List<String> TG, String vePhai)
        {
            int dem = 0;
            foreach(String tg in TG)
            {
                if (tg == vePhai)
                    dem++;
            }
            if (dem == 0)
                TG.Add(vePhai);
        }
        // xóa luật nằm trong SAT khỏi R
        private void removeRules()
        {
            for(int j =0; j<SAT.Count; j++)
            {
                for (int i = 0; i < R.Count; i++)
                    if (R[i].ID1 == SAT[j].ID1)
                        R.RemoveAt(i);
            }
        }
        public List<GiaiThich> returnGiaiThich()
        {
            return giaiThich;
        }
    }
}
