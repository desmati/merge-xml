using System.Xml.Linq;

namespace System.Xml
{
    internal static class MergeXml
    {

        public static XElement MergeXmlFiles(this string source, string otherFile)
        {
            var xml1 = XElement.Load(source);
            var xml2 = XElement.Load(otherFile);

            return MergeXmlNodes(xml1, xml2);
        }

        public static XElement MergeXmlNodes(XElement node1, XElement node2)
        {
            var mergedNode = new XElement(node1.Name);

            // Merge attributes
            var attributes1 = node1.Attributes();
            var attributes2 = node2.Attributes();
            var mergedAttributes = attributes1.Concat(attributes2)
                                              .GroupBy(attr => attr.Name)
                                              .Select(grp => grp.First());

            mergedNode.Add(mergedAttributes);

            // Merge child nodes
            var childNodes1 = node1.Elements();
            var childNodes2 = node2.Elements();

            var mergedChildNodes = childNodes1.Concat(childNodes2)
                                             .GroupBy(child => child.Name)
                                             .Select(grp => MergeChildNodes(grp.Key, grp));

            mergedNode.Add(mergedChildNodes);

            return mergedNode;
        }

        public static XElement MergeChildNodes(XName nodeName, IEnumerable<XElement> nodes)
        {
            if (nodes.Count() == 1)
            {
                return nodes.First();
            }

            var mergedNode = new XElement(nodeName);

            foreach (var node in nodes)
            {
                var childNodes = node.Elements();
                var mergedChildNodes = childNodes.GroupBy(child => child.Name)
                                                 .Select(grp => MergeChildNodes(grp.Key, grp));

                mergedNode.Add(mergedChildNodes);
            }

            return mergedNode;
        }



    }
}
