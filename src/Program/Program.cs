using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;


namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider provider = new PictureProvider();
            IPicture picture = provider.GetPicture(@"lando.jpg");

            //pipes y filters
            IFilter filter1 = new FilterGreyscale();
            IFilter filter2 = new FilterNegative();

            IPipe pipe1 = new PipeSerial(filter1, new PipeNull());
            IPipe pipe2 = new PipeSerial(filter2, new PipeNull());

            pipe1.Send(picture);
            IPicture picture1 = pipe2.Send(picture);
            
            provider.SavePicture(picture1, @"lando.jpg");
        }
    }
}
