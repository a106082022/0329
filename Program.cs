using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0329
{
    class Program
    {
        static void Main(string[] args)
        {
            //   string[] genders = {}
            string[] sex = { "男", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "男", "女", "男", "男", "男", "女", "女", "男", "男", "女", "男", "女", "男", "男", "女", "男", "男", "女", "男", "男", "男", "男", "女", "男", "男", "女", "女", "男", "男", "女", "女", "男", "男", "男", "男", "男", "男", "女", "男", "女", "女", "女", "女", "女", "女", "男", "女", "女", "女", "女", "女", "男", "男", "女", "女", "男", "女", "男", "男", "男", "男", "男", "男" };
            string[] bloods = { "O", "其他", "O", "O", "A", "O", "A", "A", "O", "O", "A", "O", "A", "B", "O", "O", "A", "其他", "O", "O", "A", "", "B", "O", "", "O", "B", "O", "B", "B", "B", "O", "O", "AB", "O", "B", "A", "O", "O", "", "O", "A", "", "O", "O", "A", "O", "O", "其他", "B", "O", "O", "O", "A", "AB", "A", "O", "B", "AB", "", "O", "O", "O", "", "O", "A", "", "A", "O", "AB", "", "", "O", "" };
            int[] height = { 173, 0, 179, 155, 183, 170, 163, 174, 165, 189, 177, 180, 154, 167, 170, 173, 165, 158, 180, 165, 153, 175, 162, 165, 0, 160, 165, 173, 164, 177, 177, 180, 170, 151, 176, 180, 168, 152, 666, 2147483647, 165, 155, 777, 173, 169, 170, 169, 171, 0, 170, 150, 160, 155, 164, 163, 165, 184, 165, 155, 0, 168, 160, 169, 0, 150, 163, 0, 168, 173, 0, 0, 0, 0, 0 };
            string[] names = { "葉俊廷", "張澤瑜", "龘䶛䨻䎱㸞蚮䡶䴞䴝䯬䬛䰕㹚王程捷", "江儀婷", "張秉華", "陳柏霖", "黃紀瑜", "黃昱維", "蔡逸群", "登琳", "世新魏鈞孝吧", "劉定南", "陳信如", "童信傑", "李岳倫", "鄒和恆", "簡毓玟", "劉子瑄", "蕭紹洋", "李亞宸la", "張以潔", "邱仕紳", "呂家瑩", "世新林鑫佑", "徐均得", "陳佳欣", "張恩瑋 遊戲虛寶序號免費送ヾ(◎´・ω・｀)ノ", "周詮", "王湘婷", "蕭宇成", "張家銘", "馬嘉誠Σヽ(ﾟД ﾟ; )ﾉ魔貫光殺砲(ﾟДﾟ)σ━0000", "陳昱嘉", "康珈熏", "盧奕宏", "陳郁佳的大哥黃博涵", "遲正雯", "世新小嗨星", "許晏誠ｘ勒是奇多＿８＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝＝Ｄ　", "許子安", "高子晴", "陳思婷", "矝鵘鮿", "余彥廷", "吳耀輝", "鄭丞智", "林冠廷", "世新何曜宇", "邵喬雨", "張豐愷", "林子晴", "邱雁回", "陳家欣是韓妞", "鄧雅馨", "謝汶珊", "李曼寧", "徐偉哲 錯誤代碼CB48", "張鈺慈", "鍾宜珊", "raer_tsai", "世新李姳諼", "鄭曼君", "陳柏霖", "世新許子安", "世新方若帆", "李曼寧", "世新張豐愷", "世新遲正雯", "世新周詮", "施 續保", "世新黃紀瑜", "世新蕭宇成", "世新鍾維辰", "彭子軒" };
            string[] zodiac = { "金牛", "", "巨蟹", "白羊", "雙魚", "雙子", "天蠍", "巨蟹", "獅子", "雙魚", "雙子", "雙子", "獅子", "雙魚", "天蠍", "天蠍", "處女", "處女", "金牛", "雙魚", "處女", "摩羯", "雙魚", "白羊", "天蠍", "處女", "雙子", "金牛", "雙子", "白羊", "白羊", "摩羯", "射手", "巨蟹", "雙魚", "獅子", "射手", "摩羯", "天蠍", "", "雙魚", "雙子", "", "雙魚", "處女", "金牛", "天秤", "水瓶", "巨蟹", "處女", "白羊", "摩羯", "水瓶", "天秤", "金牛", "天蠍", "天蠍", "處女", "雙子", "", "摩羯", "天蠍", "雙子", "", "獅子", "天蠍", "", "射手", "金牛", "處女", "", "", "天秤", "" };
            int boy = 0;
            int girl = 0;
            int A = 0;
            int B = 0;
            int AB = 0;
            int O = 0 ;
            int BH =0 ;
            int GH = 0;
            int BC = 0;
            int GC = 0;
            int hi = 0;
            int hic = 0;
           
            //男生數
            for (int i = 0; i < sex.Length; i++)
            {
                if (sex[i] == "男")
                {
                    boy++;
                }
            }
            //女生數
            for (int i = 0; i < sex.Length; i++)
                {
                if (sex[i] == "女")
                {
                    girl++;
                }
             }
            //血
            for (int i = 0; i < bloods.Length; i++)
            {
                if (bloods[i] == "A")
                {
                    A++;
                }
            }

            for (int i = 0; i < bloods.Length; i++)
            {
                if (bloods[i] == "B")
                {
                    B++;
                }
            }

            for (int i = 0; i < bloods.Length; i++)
            {
                if (bloods[i] == "AB")
                {
                    AB++;
                }
            }

            for (int i = 0; i < bloods.Length; i++)
            {
                if (bloods[i] == "O")
                {
                    O++;
                }
            }

            //男生身高統計和人數統計
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 100 && height[i] < 250 && sex[i] == "男")
                {
                    BH = BH + height[i];
                    BC++;
                }
            }

            //女生身高統計和人數統計
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 100 && height[i] < 200 && sex[i] == "女")
                {
                    GH = GH + height[i];
                     GC++;
                }
            }
            //全班身高統計和人數統計
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 100 && height[i] < 200)
                {
                    hi = hi + height[i];
                    hic++;
                }
            }

            //男女數%
            double boyper = (double)boy /(boy+girl) * 100;
            double girlper = (double)girl / (boy + girl) * 100;
            //全班身高%
            double avg = hi / hic;
            //血%
            int ba = (A + B + AB + O);
            double pA = (double)A /ba * 100;
            double pB = (double)B /ba * 100;
            double pAB = (double)AB /ba * 100;
            double pO = (double)O /ba * 100;
            //男生身高%
            double avgb = BH / BC;
            //女生身高%
            double avgg = GH / GC;
            //顯示結果
            Console.WriteLine("男生" + boy + "人" + "，占全班" + boyper + " %");
            Console.WriteLine("女生" + girl + "人"+"，占全班" + girlper + " %");
            Console.WriteLine("A型" + A + "人，占" + pA + " %");
            Console.WriteLine("B型" + B + "人，占" + pB + " %");
            Console.WriteLine("AB型" + AB + "人，占" + pAB + " %");
            Console.WriteLine("O型" + O + "人，占" + pO + " %");
            Console.WriteLine("男生總身高為" + BH + "公分" + "，平均高" + avgb + "公分");
            Console.WriteLine("女生總身高為" + GH + "公分" + "，平均高" + avgg + "公分");
            Console.WriteLine("全班總身高為" + hi + "公分" + "，平均高" + avg + "公分");
            for (int i = 0; i < names.Length; i++)
            {
                if (zodiac[i] == "天蠍" && bloods[i] == "O")
                {
                    Console.WriteLine("天蠍座O型的人:" + names[i]);
                }
            }
            Console.ReadKey();
        }
        
    }
}
