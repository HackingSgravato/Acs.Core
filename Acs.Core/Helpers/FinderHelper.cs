using System.Runtime.InteropServices;

namespace Acs.Core.Helpers;

internal static class FinderHelper
{
    internal static string s_getDifferences(List<string> filesPath)
    {
        string result = Assets.s_createFile();

        ReadOnlySpan<string> files = CollectionsMarshal.AsSpan(filesPath);

        List<string> mergedFiles = new();
        foreach (string file in files)
        {
            string[] fileContent = File.ReadAllLines(file);

            mergedFiles.AddRange(fileContent.Distinct());
        }

        string[] differences = mergedFiles.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).ToArray();

        File.WriteAllLines(result, differences);

        return result;
    }

    internal static string s_getOccurrences(List<string> filesPath)
    {
        string result = Assets.s_createFile();

        ReadOnlySpan<string> files = CollectionsMarshal.AsSpan(filesPath);

        List<string> mergedFiles = new();
        foreach (string file in files)
        {
            string[] fileContent = File.ReadAllLines(file);

            mergedFiles.AddRange(fileContent.Distinct());
        }

        string[] occurrences = mergedFiles.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key).ToArray();

        File.WriteAllLines(result, occurrences);

        return result;
    }

    internal static string s_getOccurrences(List<string> filesPath, string stringToSearchFor)
    {
        string result = Assets.s_createFile();

        foreach (string file in filesPath)
        {
            string[] occurrences = File.ReadAllLines(file).Where(line => line.Contains(stringToSearchFor,
                StringComparison.OrdinalIgnoreCase)).ToArray();

            File.AppendAllLines(result, occurrences);
        }

        return result;
    }
}