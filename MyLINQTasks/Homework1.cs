using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLINQTasks
{
    class Homework1
    {
        static public void Homework01()
        {
            string str = "Davis, Clyne, Fonte, Hooiveld, Shaw, Davis, Schneiderlin, Cork, Lallana, Rodriguez, Lambert";
            var A = str.Split(new[] { ',', ' ' }).Where(x => x.Length > 0).Select((x, index) =>  (index + 1) + ". " + x + ", ").Aggregate((x,y) => x + y);
        }
        static public void Homework02()
        {
            string str = "Jason Puncheon, 26/06/1986; Jos Hooiveld, 22/04/1983; Kelvin Davis, 29/09/1976; Luke Shaw, 12/07/1995; Gaston Ramirez, 02/12/1990; Adam Lallana, 10/05/1988";
            var A = str.Split(';').Select(x => x.Split(new[] { ',', ' ' })).OrderBy(x => DateTime.ParseExact(x.Last(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture))
                .Select(x => x.Aggregate((y, z) => y + " " + z)).ToArray();
        }
        static public void Homework03()
        {
            string str = "4:12,2:43,3:51,4:29,3:24,3:14,4:46,3:25,4:52,3:27";
            var A = new TimeSpan(0,0,(int)str.Split(',').Sum(x => (long)TimeSpan.Parse("00:0" + x).TotalSeconds));
        }
    }
}
