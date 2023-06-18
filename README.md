# MergeXML

MergeXML is a command-line tool for merging XML files in a hierarchical manner. 
It allows you to merge the attributes and child nodes of two XML files into a single XML file.

## Usage

To use the MergeXML tool, follow these steps:

1. Open a command prompt or terminal.
2. Navigate to the directory where the MergeXML tool is located.
3. Execute the following command:

```shell
MergeXML.exe -Source [source_file] -Other [other_file] -Output [output_file]
```

Replace the placeholders `[source_file]`, `[other_file]`, and `[output_file]` with the appropriate file paths:

- `-Source [source_file]`: Specifies the path to the XML file that will serve as the main source.
- `-Other [other_file]`: Specifies the path to the XML file that contains additional data to be merged.
- `-Output [output_file]`: Specifies the path where the merged XML file will be saved.

Make sure to include the full file paths, and ensure that the source and other XML files exist.

## Example

Here's an example command to merge two XML files:

```shell
dotnet MergeXML.dll -Source C:\path\to\source.xml -Other C:\path\to\other.xml -Output "C:\path with space to\output.xml"
```

In this example, `source.xml` is the main source file, `other.xml` contains additional data, and `output.xml` is the resulting merged XML file.

## Dependencies

The released version inside Dist folder is self contained and does not have any dependencies. Inorder to build this project, you need dotnet 7.

## Issues

If you encounter any issues or have suggestions for improvement, please [open an issue](https://github.com/your-repo-name/issues) on our GitHub repository.

## Credits

MergeXML is developed and maintained by @desmati. Hossein Esmati