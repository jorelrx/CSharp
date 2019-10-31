using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Modelo;

namespace Persistencia
{
    public class PGame
    {
        private string arquivo = "Game.xml";
        public List<MGame> Open()
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MGame>));
            StreamReader f = null;
            List<MGame> cs = null;
            try
            {
                f = new StreamReader(arquivo, Encoding.Default);
                cs = x.Deserialize(f) as List<MGame>;
            }
            catch
            {
                cs = new List<MGame>();
            }
            finally
            {
                if (f != null) f.Close();
            }
            return cs;
        }
        public void Save(List<MGame> cs)
        {
            XmlSerializer x = new XmlSerializer(typeof(List<MGame>));
            StreamWriter f = new StreamWriter(arquivo, false, Encoding.Default);
            x.Serialize(f, cs);
            f.Close();
        }
    }
}
