using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebBrowser.Data.BookmarkDataSetTableAdapters;

namespace WebBrowser.Logic
{
    public class BookmarkManager
    {
        public static void AddItem(BookmarkItem item)
        {
            var adapter = new BookmarksTableAdapter();
            adapter.Insert(item.URL, item.Title);
        }
        public static List<BookmarkItem> GetItems()
        {
            var adapter = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Id = row.Id;

                results.Add(item);
            }

            return results;
        }

        public static BookmarkItem getItemWithURL(String URL)
        {
            var adapter = new BookmarksTableAdapter();
            var rows = adapter.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                if (URL.ToLower().Equals(item.URL.ToLower()))
                {
                    return item;
                }
            }

            return null;
        }

        public static void RemoveItem(String URL)
        {
            var adapter3 = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter3.GetData();

            foreach (var row in rows)
            {
                if (URL.ToLower().Contains(row.URL.ToLower()))
                {
                    var item = new BookmarkItem();
                    item.URL = row.URL;
                    item.Title = row.Title;
                    item.Id = row.Id;
                    adapter3.Delete(item.Id, item.Title);
                }
            }
        }

        public static void RemoveAll()
        {
            var adapter4 = new BookmarksTableAdapter();
            var results = new List<BookmarkItem>();
            var rows = adapter4.GetData();

            foreach (var row in rows)
            {
                var item = new BookmarkItem();
                item.URL = row.URL;
                item.Title = row.Title;
                item.Id = row.Id;
                adapter4.Delete(item.Id, item.Title);
            }

        }
    }
}
