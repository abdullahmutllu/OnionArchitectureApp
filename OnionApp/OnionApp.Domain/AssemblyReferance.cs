using System.Reflection;

namespace OnionApp.Domain
{
    public static class AssemblyReferance
    {
        public static readonly Assembly Assembly = typeof(AssemblyReferance).Assembly;
    }
}
