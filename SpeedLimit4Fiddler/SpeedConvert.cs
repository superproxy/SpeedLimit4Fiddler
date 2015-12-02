using System;
using System.Collections.Generic;
using System.Text;

namespace SuperProxy.SpeedLimt4Fiddler
{
   public class SpeedConvert
    {
       // 返回fiddler的delay时间
       public static int covert(int kbps)
       {
           return Convert.ToInt32(1000*1.0 / (kbps*1.0 / 8));
       }
    }
}
