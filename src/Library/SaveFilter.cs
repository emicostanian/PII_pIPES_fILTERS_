using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;

namespace CompAndDel
{
    public class SaveFilter : IFilter
    {
        public string SavePath { get; }
        public PictureProvider Provider { get; }

        public SaveFilter(string savePath)
        {
            SavePath = savePath;
            Provider = new PictureProvider();
        }

        public IPicture Filter(IPicture image)
        {
            Provider.SavePicture(image, SavePath);
            return image;
        }
    }
}