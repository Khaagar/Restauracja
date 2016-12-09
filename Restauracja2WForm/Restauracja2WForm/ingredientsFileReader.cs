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
    class ingredientsFileReader
    {
        private string line;
        StreamReader ingredients = new StreamReader(@"../../ingredients.txt");
        List<string> listLines = new List<string>();

        public List<string> getFileContent()
        {
            
            while ((line = ingredients.ReadLine()) != null)
            {
                listLines.Add(line);

            }
                return listLines;
        }

        
    }
}
