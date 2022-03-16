using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace XML_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string xml = @"<Names> 
                           <Name>A</Name>
                            <Name>B</Name>
                              <Name>C</Name>
                                <Name>D</Name>

                             </Names>";
            XDocument xd = new XDocument();
            xd=XDocument.Parse(xml);
            var res = xd.Element("Names").Descendants();
            foreach (XElement item in res)
            {
                Console.WriteLine("Name is : {0}"  ,item.Value);
            }
            xd.Element("Names").Add(new XElement("Name", "E"));
            Console.WriteLine("After Adding!!!");
            var res1 = xd.Element("Names").Descendants();
            foreach (XElement item in res1)
            {
                Console.WriteLine("Name is : {0}"  , item.Value);
            }
            xd.Descendants().Where(s => s.Value == "B").Remove();
            Console.WriteLine("After Deletion!!!");
            var res2 = xd.Element("Names").Descendants();
            foreach (XElement item in res2)
            {
                Console.WriteLine("Name is : {0}", item.Value);
            }


        }
    }
}
