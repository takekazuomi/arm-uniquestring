// https://www.nuget.org/packages/Azure.Deployments.Expression/
// https://cs.github.com/Azure/bicep/blob/6afa660cba723c79181b98b80f9965234e94857e/src/Bicep.Core/Emit/ScopeHelper.cs#L205
using Azure.Deployments.Expression.Expressions;
using Newtonsoft.Json.Linq;

var (input, ok) = ParseCommandLine(args);
if (!ok)
    Environment.Exit(1);

var output = ExpressionBuiltInFunctions.Functions.EvaluateFunction(
    "uniqueString",
    new JToken[] {
         (new JTokenExpression(input)).Value
    }).ToString();

Console.Out.Write(output);

(string, bool) ParseCommandLine(string[] args)
{
    if (args.Length == 0)
    {
        PrintHelp();
        return ("", false);
    }
    return (args[0], true);
}

void PrintHelp() => Console.Error.WriteLine("A command line parameter requires a uniqueString () argument.");