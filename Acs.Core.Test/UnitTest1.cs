using System.Diagnostics;
using Acs.Core.Helpers;
using Acs.Core.Services;

namespace Acs.Core.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // var result = AcsFinder.GetDifferences(new []
            // {
            //     @"D:\New Documento di testo.txt", @"D:\New Documento di testo - Copy.txt"
            // });
            // Assets.OpenFile(result);
            //
            // result = AcsFinder.GetDifferences(new []
            // {
            //     @"D:\Downloads\test legit.txt", @"D:\Downloads\test unlegit.txt"
            // });
            // Assets.OpenFile(result);
            //
            // result = AcsFinder.GetOccurrences(new []
            // {
            //     @"D:\New Documento di testo.txt", @"D:\New Documento di testo - Copy.txt"
            // });
            // Assets.OpenFile(result);
            //
            // result = AcsFinder.GetOccurrences(new []
            // {
            //     @"D:\New Documento di testo.txt", @"D:\New Documento di testo - Copy.txt"
            // }, "a");
            // Assets.OpenFile(result);

            var result = AcsDumper.Dump(new List<int>
            {
                7776, 8248
            });
            foreach (var s in result)
            {
                Assets.OpenFile(s);
            }


            var results = AcsDumper.DumpAvailable();
            int count = results.Length;
            // foreach (var s in results)
            // {
            //     Assets.OpenFile(s);
            // }
        }
    }
}