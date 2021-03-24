using System.Collections.Generic;

namespace CSharpLib.AdapterPattern.Pluralsight_AdapterSample.Model
{
    public interface IDataPatternRendererAdapter
    {
        string ListPatterns(IEnumerable<Pattern> patterns);
    }
}
