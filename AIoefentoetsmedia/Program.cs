using System;
using System.Collections.Generic;

namespace AIoefentoetsmedia
{
    public class Program
    {
        public static void Main()
        {
            MediaFactory factory = new MediaFactory();
            LibraryManagement library = new LibraryManagement();

            IMediaItem book1 = factory.CreateMedia("Book", "The Great Gatsby", "F. Scott Fitzgerald", 123456789);
            IMediaItem magazine1 = factory.CreateMedia("Magazine", "National Geographic", "Various Authors", 202);

            library.AddMedia(book1);
            library.AddMedia(magazine1);

            library.DisplayAllMedia();
        }
    }

    public interface IMediaItem
    {
        string Title { get; set; }
        string Author { get; set; }
        void DisplayInfo();
    }

    public class Book : IMediaItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Book - Title: {Title}, Author: {Author}, ISBN: {ISBN}");
        }
    }

    public class Magazine : IMediaItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int IssueNo { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Magazine - Title: {Title}, Author: {Author}, Issue No: {IssueNo}");
        }
    }

    public class MediaFactory
    {
        public IMediaItem CreateMedia(string type, string title, string author, int identifier)
        {
            if (type == "Book")
            {
                return new Book { Title = title, Author = author, ISBN = identifier };
            }
            else if (type == "Magazine")
            {
                return new Magazine { Title = title, Author = author, IssueNo = identifier };
            }
            else
            {
                throw new ArgumentException("Invalid media type");
            }
        }
    }

    public class LibraryManagement
    {
        private List<IMediaItem> mediaItems = new List<IMediaItem>();

        public IReadOnlyList<IMediaItem> MediaItems => mediaItems;

        public void AddMedia(IMediaItem media)
        {
            mediaItems.Add(media);
        }

        public void DisplayAllMedia()
        {
            foreach (var media in mediaItems)
            {
                media.DisplayInfo();
            }
        }
    }


}
