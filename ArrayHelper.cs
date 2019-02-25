using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }

            if (source.Length == 0)
            {
                throw new ArgumentException();
            }

            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != 0 && source[i] != 1 )
                    throw new ArgumentException();
            }

            int N = source.Length;
            bool sim = true;
            for (int i = 0; i < source.Length; i++)
            {
                if (source[i] != source[N - 1 - i])
                {
                    sim = false;
                    break;
                }
            }

            if (sim == true) return "Yes";
            else return "No";
        }
    }
}
