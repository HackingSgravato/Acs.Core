using System.Diagnostics;

namespace Acs.Core.Helpers;

public static class Assets
{
    public static void OpenFile(string path)
    {
        ProcessStartInfo processStartInfo = new()
        {
            FileName = path,
            UseShellExecute = true
        };

        _ = Process.Start(processStartInfo);
    }

    internal static string s_createFile()
    {
        int uniqueId = s_generateNumber();

        string fileName = $"result-{uniqueId}.txt";

        string path = Path.Combine(Path.GetTempPath(), fileName);

        using FileStream file = File.Create(path);

        return path;
    }

    internal static int s_generateNumber()
    {
        Random rand = new();
        return rand.Next(1000, 10_000);
    }
}