using System;
using CompAndDel.Pipes;
using CompAndDel.Filters;
using Ucu.Poo.Twitter;
using Ucu.Poo.Cognitive;
using System.Drawing;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            // //PARTE1
            
            //PictureProvider provider = new PictureProvider();
            //IPicture picture = provider.GetPicture(@"luke.jpg");

            // //pipes y filters
            // IFilter filter1 = new FilterGreyscale();
            // IFilter filter2 = new FilterNegative();

            // IPipe pipe1 = new PipeSerial(filter1, new PipeNull());
            // IPipe pipe2 = new PipeSerial(filter2, pipe1);

            // pipe1.Send(picture);
            // IPicture picture1 = pipe2.Send(picture);
            
            
            // provider.SavePicture(picture1, @"editada3.jpg");

            // //PARTE2

            // PictureProvider provider = new PictureProvider();
            // IPicture picture = provider.GetPicture(@"luke.jpg");

            // //pipes y filters
            // IFilter filter1 = new FilterGreyscale();
            // IFilter filter2 = new FilterNegative();

            // IPipe pipe1 = new PipeSerial(filter1, new PipeNull());
            // IPipe pipe2 = new PipeSerial(filter2, new PipeNull());

            // pipe1.Send(picture);
            // IPicture picture1 = pipe1.Send(picture);

            // pipe2.Send(picture);
            // IPicture picture2 = pipe2.Send(picture);
            
            
            // provider.SavePicture(picture1, @"editada1.jpg");
            // provider.SavePicture(picture2, @"editada2.jpg");

            // //PARTE3

            //var twitter = new TwitterImage();
            //Console.WriteLine(twitter.PublishToTwitter("EMI", @"editada.jpg"));
            
            // //PARTE 4 

            {
                CognitiveFace cog = new CognitiveFace(true, Color.GreenYellow); //no reconoce la cara porque no esta a color
                cog.Recognize(@"lando.jpg");
                FoundFace(cog);
            }

            static void FoundFace(CognitiveFace cog)
            {
                if (cog.FaceFound)
                {
                    Console.WriteLine("Face Found!");
                    if (cog.GlassesFound)
                    {
                        Console.WriteLine("Has glasses 🤓");
                    }
                    else
                    {
                        Console.WriteLine("No glasses");
                    }
                }
                else
                    Console.WriteLine("No Face Found");
                }
            }
        }
    }

