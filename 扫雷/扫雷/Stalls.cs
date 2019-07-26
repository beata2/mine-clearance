using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 扫雷
{
    public delegate void OnshiftHande(object sender, LevelArgs e);//声明委托 
    public class Stalls
    {
        public event OnshiftHande Onshift;
        public void Shift(object sender, LevelArgs e)
        {
            if (Onshift != null)
            {
                Onshift(sender, e);
            }
        }
    }
}
