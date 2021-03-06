﻿/*
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using VietSyllableTransducer;

namespace VietSyllableTransducer
{
    public class Transducer
    {
        public static void Main()
        {
            string test1 = "quan là một nhà cách mạng, người sáng lập Đảng Cộng sản Việt Nam, một trong những người đặt nền " +
                "móng và lãnh đạo công cuộc đấu tranh giành độc lập, toàn vẹn lãnh thổ cho Việt Nam trong thế kỷ ";
            string test2 = "Là một lãnh tụ được nhiều người ngưỡng mộ và tôn sùng, lăng của ông được xây ở Hà Nội, " +
                "nhiều tượng đài của ôngđược đặt ở khắp mọi miền Việt Nam, hình ảnh của ông được nhiều người dân " +
                "trong nhà, đặt trên bàn thờ và được in ở hầu hết mệnh giá đồng tiền Thụ đề nghị ông về nước trực tiếp lãnh đạo";
            test1 += test2;

            //AnalyzeString(test1);

            string content = "";
            using (StreamReader sr = new StreamReader("Data/syllable_level_1+2.txt"))
            {
                content = sr.ReadToEnd();
            }
            content = content.Replace("\n", " ");
            content = content.Replace("\r", " ");
            content = content.Replace("  ", " ");
            AnalyzeString(content);

            Console.ReadKey();
        }

        public static void AnalyzeString(string str)
        {
            str = str.Replace(",", "");
            str = str.ToLower();
            str = Program.applyReplaceFunctions(str);
            string[] syllable = str.Split(new char[] { ' ' }, StringSplitOptions.None);
            List<string> sList = syllable.ToList().Distinct().ToList();
            sList.Sort();

            foreach (string s in sList)
            {
                Syllable sy = AnalyseSyllable(s);
            }
        }

        public static Syllable AnalyseSyllable(string syllable)
        {
            VietSyllableTransducer vst = new VietSyllableTransducer();
            Syllable result = vst.AnalyzeSyllable(syllable);

            // à refactoriser
            if (String.IsNullOrEmpty(vst.DefaultTransitionReached))
            {
                Console.WriteLine(String.Format("{0}\t{1}\t{2}", syllable, result, result.VietDex()));
            }
            else
            {
                Console.WriteLine(String.Format("{0}\t{1}\t[{2}]", syllable, result, vst.DefaultTransitionReached));
            }

            return result;
        }
    }
}
*/