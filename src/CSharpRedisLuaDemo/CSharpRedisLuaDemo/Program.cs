using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRedisLuaDemo
{
    class Program
    {
        static RedisClient redisClient = new RedisClient("localhost", 6379);//redis服务IP和端口
        static void Main(string[] args)
        {
            Console.WriteLine(redisClient.Get<string>("city")); 
            Console.ReadKey();
        }
    }
 
}
