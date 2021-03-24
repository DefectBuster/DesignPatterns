using System;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using CSharpLib.AdapterPattern.Pluralsight_AdapterSample.Library;
using CSharpLib.AdapterPattern.Pluralsight_AdapterSample.Model;
using CSharpLib.AdapterPattern.Pluralsight_AdapterSample.Adaptor;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdaptorPattern.Test.PluralsightAdaptorPatternTest
{
    /// <summary>
    /// Summary description for DataRendererShould
    /// </summary>
    [TestClass]
    public class DataRendererShould
    {
        [TestMethod]
        public void RenderOneRowGivenStubDataAdapter()
        {
            var myRenderer = new DataRenderer(new StubDbAdapter());

            var writer = new StringWriter();
            myRenderer.Render(writer);

            string result = writer.ToString();
            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(3, lineCount);
        }

        [TestMethod]
        public void RenderTwoRowsGivenOleDbDataAdapter()
        {
            var adapter = new OleDbDataAdapter();
            adapter.SelectCommand = new OleDbCommand("SELECT * FROM Pattern");
            adapter.SelectCommand.Connection =
                new OleDbConnection(
                    @"Provider=Microsoft.SQLSERVER.CE.OLEDB.3.5;Data Source=E:\Study Materials\DesignPattern\DesignPatternSamples\AdapterPattern\CSharpLib.AdapterPattern\Pluralsight_AdapterSample\DB\Sample.sdf");
            var myRenderer = new DataRenderer(adapter);

            var writer = new StringWriter();
            myRenderer.Render(writer);

            string result = writer.ToString();
            Console.Write(result);

            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(4, lineCount);
        }
    }
}
