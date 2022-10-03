using Acs.Core.Helpers;

namespace Acs.Core.Services;

public static class AcsFinder
{
    /// <param name="filesPath"></param>
    /// <returns>
    /// The result file path with the process results associated.
    /// </returns>
    public static string GetDifferences(IEnumerable<string> filesPath)
    {
        return FinderHelper.s_getDifferences(filesPath.ToList());
    }

    /// <param name="filesPath"></param>
    /// <returns>
    /// The result file path with the process results associated.
    /// </returns>
    public static string GetOccurrences(IEnumerable<string> filesPath)
    {
        return FinderHelper.s_getOccurrences(filesPath.ToList());
    }

    /// <param name="filesPath"></param>
    /// <returns>
    /// The result file path with the process results associated.
    /// </returns>
    public static string GetOccurrences(IEnumerable<string> filesPath, string stringToSearchFor)
    {
        return FinderHelper.s_getOccurrences(filesPath.ToList(), stringToSearchFor);
    }
}