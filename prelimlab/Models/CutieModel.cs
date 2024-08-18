using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prelimlab.Models
{
    public class CutieModel
    {
        public int CutieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Image Image { get; set; }
        public string User { get; set; }

    }
}
