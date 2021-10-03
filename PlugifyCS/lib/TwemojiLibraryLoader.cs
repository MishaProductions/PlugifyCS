//https://github.com/HartoSha/TwemojiSharp/blob/master/TwemojiSharp/TwemojiLibraryLoader.cs
namespace TwemojiSharp
{
    /// <summary>
    /// Gets original twemoji library
    /// </summary>
    internal static class TwemojiLibraryLoader
    {
        internal static string GetJs()
        {
            return PlugifyCS.Properties.Resources.twemoji;
        }
    }
}