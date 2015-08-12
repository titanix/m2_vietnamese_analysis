namespace Lecailliez.Japanese.Helpers
{
    public enum ContentType
    {
        UNKOWN,
        EURO_LANG,
        FULL_HIRAGANA,
        FULL_KATAKANA,
        FULL_KANJI,
        JAPANESE_MIXED
    }

    public static class Utils
    {
        public static ContentType AnalyzeContent(string str)
        {
            ContentType content = ContentType.UNKOWN;

            if (IsHiragana(str))
            {
                return ContentType.FULL_HIRAGANA;
            }
            if (IsKatakana(str))
            {
                return ContentType.FULL_KATAKANA;
            }
            if (IsKanji(str))
            {
                return ContentType.FULL_KANJI;
            }
            if (IsRomaji(str))
            {
                return ContentType.EURO_LANG;
            }
            if (ContainsHiragana(str) || ContainsKatakana(str) || ContainsKanji(str))
            {
                return ContentType.JAPANESE_MIXED;
            }
            return content;
        }

        public static ContentType AnalyzeContent(char c)
        {
            return AnalyzeContent(c.ToString());
        }

        public static bool IsHiragana(char c)
        {
            char begin = '\u3040';
            char end = '\u309F';
            return begin.CompareTo(c) <= 0 &&
            end.CompareTo(c) >= 0;
        }

        public static bool IsHiragana(string str)
        {
            foreach (char c in str.ToCharArray())
            {
                if (!IsHiragana(c))
                    return false;
            }
            return true;
        }

        public static bool IsKatakana(char c)
        {

            char begin = '\u30A0';
            char end = '\u30FF';
            return begin.CompareTo(c) <= 0 &&
            end.CompareTo(c) >= 0;
        }

        public static bool IsKatakana(string str)
        {
            foreach (char c in str.ToCharArray())
            {
                if (!IsKatakana(c))
                    return false;
            }
            return true;
        }

        public static bool IsKanji(char c)
        {
            return c > 0x3400 && c < 0x9FC3;
        }

        public static bool IsKanji(string str)
        {
            foreach (char c in str.ToCharArray())
            {
                if (!IsKanji(c))
                    return false;
            }
            return true;
        }

        public static bool IsRomaji(string str)
        {
            foreach (char c in str.ToCharArray())
            {
                if (!(c < 0x024F))
                    return false;
            }
            return true;
        }

        public static bool ContainsRomaji(string str)
        {
            foreach (char c in str.ToCharArray())
            {
                if (c < 0x024F)
                    return true;
            }
            return false;
        }

        public static bool ContainsHiragana(string str)
        {
            foreach (char c in str.ToCharArray())
            {
                if (IsHiragana(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainsKatakana(string str)
        {
            foreach (char c in str.ToCharArray())
            {
                if (IsKatakana(c))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainsKanji(string str)
        {
            foreach (char c in str.ToCharArray())
            {
                if (IsKanji(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}