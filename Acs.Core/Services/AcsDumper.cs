using Acs.Core.Helpers;

namespace Acs.Core.Services;

public static class AcsDumper
{
    /// <summary>
    /// This will dump all accessible processes.
    /// </summary>
    /// <returns>
    /// Every result file path of each process memory dump.
    /// </returns>
    public static string[] DumpAvailable()
    {
        return DumperHelper.s_dumpAvailable().ToArray();
    }

    /// <returns>
    /// Every result file path of each process memory dump.
    /// </returns>
    public static string[] Dump(IEnumerable<int> processesId)
    {
        return DumperHelper.s_dump(processesId.ToList()).ToArray();
    }

    static AcsDumper()
    {
        DumperHelper.s_extractExternalDumper();
    }
}