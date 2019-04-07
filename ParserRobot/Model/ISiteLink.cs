using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserRobot.Model
{
    public interface ISiteLink
    {
        int Id { get; set; }
        string Link { get; set; }
        string Title { get; set; }
        DateTime DateTime { get; set; }

     }
}
