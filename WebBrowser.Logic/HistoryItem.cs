using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBrowser.Logic
{
    public class HistoryItem
    {
        public String URL { get; set; }
        public String Title { get; set; }

        public DateTime Date { get; set; }
        public int Id { get; set; }

    }
}
