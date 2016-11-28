using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restauracja2WForm
{
    class menuFileReader
    {
        private string line;
        private string[] kategoria = { "PIZZA 32", "Yellow", "PIZZA 43", "Red", "NAPOJ", "Blue", "INNE", "Violet" };
        StreamReader menu = new StreamReader(@"../../menu.txt");
        List<string> listLines = new List<string>();

        public List<string> getFileContent()
        {
            
            while ((line = menu.ReadLine()) != null)
            {
                listLines.Add(line);

            }
                return listLines;
        }

        
    }
}
