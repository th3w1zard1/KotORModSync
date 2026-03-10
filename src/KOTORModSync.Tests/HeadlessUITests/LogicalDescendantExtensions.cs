using System.Collections.Generic;
using Avalonia;
using Avalonia.VisualTree;

namespace KOTORModSync.Tests.HeadlessUITests
{
    internal static class LogicalDescendantExtensions
    {
        internal static IEnumerable<Visual> GetLogicalDescendants(this Visual visual)
        {
            return visual.GetVisualDescendants();
        }
    }
}
