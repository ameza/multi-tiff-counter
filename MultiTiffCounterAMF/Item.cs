using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTiffCounterAMF
{
    public class Item
    {
        public Item(String path, int totalPages)
        {
            this.Path = path;
            this.TotalPages = totalPages;
        }

        public String Path { get; set; }
        public int TotalPages { get; set; }
    }
}
