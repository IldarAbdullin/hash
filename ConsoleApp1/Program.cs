using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.IO;
using System.Configuration;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            byte[] text = File.ReadAllBytes(@"5_9.cpp");
            File.WriteAllBytes(@"5_9.cpp", text);
            Console.WriteLine("Enter the hashing method 1 - MD5,2 - SHA256,3 - SHA512\n");
            int.TryParse(Console.ReadLine(), out int hashMethod);

            var hash = ConfigurationManager.AppSettings[string.Format("hash{0}", hashMethod)];

            if (hash == "MD5")
            {
                var sw = Stopwatch.StartNew();
                var md5 = MD5.Create();
                var computeHash = md5.ComputeHash(text);
                Console.WriteLine("{0} - {1} ", hash, Convert.ToBase64String(computeHash));
                sw.Stop();
                Console.WriteLine("Elapsed Time (ms): {0}\n", sw.ElapsedMilliseconds);
                Console.ReadKey();
            }
            else if (hash == "SHA256")
            {
                var sw = Stopwatch.StartNew();
                var create_hash = SHA256.Create();
                var computeHash = create_hash.ComputeHash(text);
                Console.WriteLine("{0} - {1} ", hash, Convert.ToBase64String(computeHash));
                sw.Stop();
                Console.WriteLine("Elapsed Time (ms): {0}\n", sw.ElapsedMilliseconds);
                Console.ReadKey();
            }
            else if (hash == "SHA512")
            {
                var sw = Stopwatch.StartNew();
                var create_hash = SHA512.Create();
                var computeHash = create_hash.ComputeHash(text);
                Console.WriteLine("{0} - {1} ", hash, Convert.ToBase64String(computeHash));
                sw.Stop();
                Console.WriteLine("Elapsed Time (ms): {0}\n", sw.ElapsedMilliseconds);
                Console.ReadKey();
            }
        }
    }
}
