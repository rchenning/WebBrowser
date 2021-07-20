using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.HistoryDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class HistoryManager
    {
        public static void AddItem(HistoryItem item)
        {
            var adapter1 = new HistoryTableAdapter();
            adapter1.Insert(item.URL, item.Title, item.Date);
        }

        public static List<HistoryItem> GetItems()
        {
            var adapter2 = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter2.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                item.Id = row.Id;

                results.Add(item);
            }

            return results;
        }

        public static void RemoveItem(String URL)
        {
            var adapter3 = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter3.GetData();

            foreach (var row in rows)
            {
                if (URL.ToLower().Contains(row.URL.ToLower()))  
                {
                    var item = new HistoryItem();
                    item.URL = row.URL;
                    item.Title = row.Title;
                    item.Date = row.Date;
                    item.Id = row.Id;
                    adapter3.Delete(item.Id, item.Title, item.Date);
                }
            }
        }

        public static void RemoveAll()
        {
            var adapter4 = new HistoryTableAdapter();
            var results = new List<HistoryItem>();
            var rows = adapter4.GetData();

            foreach (var row in rows)
            {
                var item = new HistoryItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Date = row.Date;
                item.Id = row.Id;
                adapter4.Delete(item.Id, item.Title, item.Date);
            }

        }

    }
}
