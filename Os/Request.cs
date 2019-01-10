using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace Os
{
    class Request
    {
        public static ArrayList  test_FIFO = new ArrayList(); 
        public static ArrayList  test_LRU = new ArrayList(); 
        public static ArrayList  test_OPT = new ArrayList(); 
        public static bool kuaibiao = true;//快表的有无
        public static int NumsOfwulikuai = 3;  //页内物理块个数
        public static int TimeOfneicun = 100; //内存的存取时间
        public static int TimeOfkuaibiao = 10;//访问快表时间
        public static int TimeOfqueye = 5000;//缺页中断时间
        public static int NumsOfneicun = 20;//内存中的数量
        // public static string xulie = "1323H,3516H,16A7H,6B23H,3D21H,16FCH,7121H,36FCH,9121H";
        public static string xulie = "7000H,0000H,1YYYH,2HHHH,0UUUH,3HHHH,0TTTH,4TTTH,2TTTH,3TTTH,0EEEH,3YYYH,2TTTH,1UUUH,2TTTH,0TTTH,1YYYH,7TTTH,0RRRH,1IIIH";
    }
}
