using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0924
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AAA();
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }

            Console.ReadLine();
        }

        static void AAA()
        {
            try //오류가 나면 오류가 난 지점에서 바로 catch으로 넘어간다.
            {
                int[] arr = new int[5] { 1, 2, 0, 4, 5 };
                Console.Write("몇번째 배열의 값으로 계산할까요?");
                int idx = int.Parse(Console.ReadLine());
                if (idx < 0 || idx > 4)
                {
                    throw new Exception("0~4의 수를 입력하세요");
                }
                int p = arr[idx];
                int k = 10 / p;
                Console.WriteLine(k);
            }
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("0으로 나눌수 없습니다.");
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("0~4 범위안의 수를 입력하세요");
            //}
            catch (Exception err) //Exception이 부모
            {
                throw err;
            }
        }
    }
}
