using Acs.Core.Resources.Files;
using Acs.Core.Resources.Strings;
using System.Diagnostics;

namespace Acs.Core.Helpers;

internal static class DumperHelper
{
    internal static List<string> s_dumpAvailable()
    {
        ProcessStartInfo processStartInfo = new()
        {
            FileName = "cmd.exe",
            UseShellExecute = false,
            CreateNoWindow = true
        };

        Process[] processes = Process.GetProcesses();

        List<string> results = new();

        _ = Parallel.ForEach(processes, process =>
        {
            string result = Assets.s_createFile();

            processStartInfo.Arguments = $"/C {StringsResource.ExternalDumperPath} -pid {process.Id} -nh > \"{result}\"";

            Process.Start(processStartInfo)?.WaitForExit();

            results.Add(result);
        });

        return results;
    }

    internal static IEnumerable<string> s_dump(List<int> processesId)
    {
        ProcessStartInfo processStartInfo = new()
        {
            FileName = "cmd.exe",
            UseShellExecute = false,
            CreateNoWindow = true
        };

        foreach (int id in processesId)
        {
            string result = Assets.s_createFile();

            processStartInfo.Arguments = $"/C {StringsResource.ExternalDumperPath} -pid {id} -nh > \"{result}\"";

            Process.Start(processStartInfo)?.WaitForExit();

            yield return result;
        }
    }

    internal static void s_extractExternalDumper()
    {
        string path = StringsResource.ExternalDumperPath.Replace("USERNAME", Environment.UserName);

        using FileStream file = File.Create(path);

        byte[] buffer = FilesResource.ExternalDumper;

        file.Write(buffer, 0, buffer.Length);
    }
}