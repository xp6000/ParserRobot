using ParserRobot.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserRobot.Parser
{
   public interface IParser
    {
         string GetLink(string linkPage, string mainUrl);
    }
}
