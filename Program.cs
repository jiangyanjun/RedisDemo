using RedisDemo.Redis;
using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisHelper rd = new RedisHelper();
            TestClass tc = new TestClass();
            tc.Id = 1;
            tc.Name = System.Guid.NewGuid().ToString();
            tc.Pice =3.141592679;
            tc.IsFlage = false;
            rd.Remove("i9");
            var FindData = rd.Get<object>("441f2a63-2470-4809-967e-f24282b33ce1");
            Console.WriteLine("写入成功");
            //rd.Insert("i9", "我插进去了吗？");
            Console.ReadKey();
        }
    }
}
