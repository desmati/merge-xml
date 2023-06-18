using System.Xml;

string? sourceFile = null;
string? otherFile = null;
string? outputFile = null;

for (int i = 0; i < args.Length; i++)
{
    if (args[i] == "-Source" && i + 1 < args.Length)
    {
        sourceFile = args[i + 1];
    }
    else if (args[i] == "-Other" && i + 1 < args.Length)
    {
        otherFile = args[i + 1];
    }
    else if (args[i] == "-Output" && i + 1 < args.Length)
    {
        outputFile = args[i + 1];
    }
}

if (string.IsNullOrWhiteSpace(sourceFile) || string.IsNullOrEmpty(sourceFile) || !File.Exists(sourceFile))
{
    Console.WriteLine("Invalid -Source. It should be a path to an XML file.");
    return;
}

if (string.IsNullOrWhiteSpace(otherFile) || string.IsNullOrEmpty(otherFile) || !File.Exists(otherFile))
{
    Console.WriteLine("Invalid -Other. It sould be a path to a folder.");
    return;
}

if (string.IsNullOrWhiteSpace(outputFile) || string.IsNullOrEmpty(outputFile))
{
    Console.WriteLine("Invalid -Other. It sould be a path to a folder.");
    return;
}


var mergedXml = MergeXml.MergeXmlFiles(sourceFile, otherFile);

mergedXml.Save(outputFile);