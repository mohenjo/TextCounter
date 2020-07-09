using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HNP.Text;

namespace TestWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = @"12345 한글 English";
            inputText = @"인천공항 근처에 위치한 종합 리조트 단지 Paradise City의 호텔 Art Paradiso는 최근 새로운 미술품들과 함께 새단장을 마치고 2개의 패키지 상품을 제공한다.
Intergrated resort complex Paradise city's hotel Art Paradiso has recently added more artworks and decorations to offer two packages.";
            Console.WriteLine(TextUtils.GetStringLength(inputText));
            Console.WriteLine(TextUtils.GetStringByteLength(inputText));
            Console.WriteLine(TextUtils.GetStringLength(inputText, true));
            Console.WriteLine(TextUtils.GetStringByteLength(inputText, true));
        }
    }
}
