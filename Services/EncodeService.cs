using System;
using System.Collections.Generic;
using System.Text;

namespace ShortUrl.Services
{
    public class EncodeService : IEncodeService
    {
        private static int _first;
        private static int _last;
        private static int _interval;

        public EncodeService()
        {
            char a = 'A';
            char z = 'Z';

            EncodeService._first = Convert.ToInt32(a);
            EncodeService._last = Convert.ToInt32(z);
            EncodeService._interval = _last - _first + 1;
        }

        public string Encode(string url)
        {
            var hash = Math.Abs(url.GetHashCode());

            List<int> cList = new List<int>();

            var v = hash;
            var c = v % EncodeService._interval;
            cList.Add(c);
            while (v > EncodeService._interval)
            {
                v = v / EncodeService._interval;
                c = v % EncodeService._interval;
                cList.Add(c);
            }

            StringBuilder sb = new StringBuilder();
            foreach (var i in cList)
            {
                sb.Append(Convert.ToChar(i + EncodeService._first));
            }

            return sb.ToString();
        }
    }
}