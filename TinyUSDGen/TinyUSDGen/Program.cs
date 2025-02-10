using CppAst;
using System;
using System.Diagnostics;
using System.IO;

namespace TinyUSDGen
{
    class Program
    {
        static void Main(string[] args)
        {
            var headerFile = Path.Combine(AppContext.BaseDirectory, "Headers", "c-tinyusd.h");
            var options = new CppParserOptions()
            {
                ParseMacros = true,
            };

            var compilation = CppParser.ParseFile(headerFile, options);

            // Print diagnostic messages
            if (compilation.HasErrors)
            {
                foreach (var message in compilation.Diagnostics.Messages)
                {
                    Debug.WriteLine(message);
                }
            }
            else
            {
                string outputPath = "..\\..\\..\\..\\..\\Evergine.Bindings.TinyUSD\\Generated";
                CsCodeGenerator.Instance.Generate(compilation, outputPath);
            }

        }
    }
}
