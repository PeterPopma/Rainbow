using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainbow.Synth
{
    public class CategoryItem
    {
        string name;
        string category;

        public string Name { get => name; set => name = value; }
        public string Category { get => category; set => category = value; }

        public CategoryItem(string name, string category)
        {
            this.name = name;
            this.category = category;
        }
    }
}
