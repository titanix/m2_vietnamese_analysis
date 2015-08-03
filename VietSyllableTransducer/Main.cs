using System;
using System.Collections.Generic;
using System.Linq;
using VietSyllableTransducer;

namespace VietSyllableTransducer
{
    public class Transducer
    {
        public static void Main ()
        {
            string test1 = "quan là một nhà cách mạng, người sáng lập Đảng Cộng sản Việt Nam, một trong những người đặt nền " +
                "móng và lãnh đạo công cuộc đấu tranh giành độc lập, toàn vẹn lãnh thổ cho Việt Nam trong thế kỷ ";
            string test2 = "Là một lãnh tụ được nhiều người ngưỡng mộ và tôn sùng, lăng của ông được xây ở Hà Nội, " +
                "nhiều tượng đài của ôngđược đặt ở khắp mọi miền Việt Nam, hình ảnh của ông được nhiều người dân " +
                "trong nhà, đặt trên bàn thờ và được in ở hầu hết mệnh giá đồng tiền Thụ đề nghị ông về nước trực tiếp lãnh đạo";
            test1 += test2;
            test1 = test1.Replace(",", "");
            test1 = test1.ToLower();
            test1 = Program.applyReplaceFunctions(test1);
            string[] syllable = test1.Split(new char[] { ' ' }, StringSplitOptions.None);
            List<string> sList = syllable.ToList().Distinct().ToList();
            sList.Sort();

            foreach (string s in sList) 
            {
                VietSyllableTransducer vst = new VietSyllableTransducer();
                Syllable result = vst.AnalyzeSyllable(s);
                if(String.IsNullOrEmpty(vst.DefaultTransitionReached))
                {
                    Console.WriteLine(String.Format("{1}\t{0}", result, s));
                }
                else 
                {
                    Console.WriteLine(String.Format("{2}\t{0}\t[{1}]", result, vst.DefaultTransitionReached, s));
                }
            }
        }
    }
}


