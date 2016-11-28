using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja2WForm
{
    class menuCategory
    {
        private string categoryName;
        
        private List<Product> lifOfCategoryContent = new List<Product>();


        public List<string> getListOfCategories()
        {
           
            menuFileReader fr = new menuFileReader();
            List<string> listOfCategories = new List<string>();
            List<string> fileContent = fr.getFileContent();
           foreach (string fileLine in fileContent)
            {
                for (int i = 0; fileLine[i] != ';'; i++)
                {
                    categoryName += fileLine[i];


                }
                if (listOfCategories.Count ==0)
                {
                    listOfCategories.Add(categoryName);
                }
                if (listOfCategories.Last() != categoryName)
                {
                    listOfCategories.Add(categoryName);
                }
                categoryName = null; 
            }

            return listOfCategories;
        }

        public List<Product> getListOfCategoryContent(string categoryM)
        {
            string id = null;
            string name = null;
            string price = null;
            string color = null;
            string category = null; ;
            List<string> ingredients = new List<string>();

            menuFileReader fr = new menuFileReader();
            List<string> fileContent = fr.getFileContent();
            string tmpString = null;
            Product tmpProduct;

            int tmpInt = 0;
            int tmpCounter = 0;
            foreach (string fileLine in fileContent)
            {
                    for (int j = tmpInt; j < fileLine.Length; j++)
                    {
                        while (fileLine[j] != ';')
                        {
                            tmpString += fileLine[j];
                            j++;
                        }

                        if (fileLine[j] == ';') tmpCounter++;
                        
                            if (tmpCounter == 1) category = tmpString;
                            if (tmpCounter == 2) color = tmpString;
                            if (tmpCounter == 3) id = tmpString;
                            if (tmpCounter == 4) name = tmpString;
                            if (tmpCounter == 5) price = tmpString;
                            if (tmpCounter > 6)
                            {
                                ingredients.Add(tmpString);
                            }
                         

                        tmpString = null;

                    }
                    tmpCounter = 0;
                if (category == categoryM)
                {
                    tmpProduct = new Product(category, color, id, name, price, ingredients);
                    this.lifOfCategoryContent.Add(tmpProduct);
                }
                ingredients.Clear();

                }
            return this.lifOfCategoryContent;
            }


    }
}
