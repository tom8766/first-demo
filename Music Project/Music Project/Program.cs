using MusicObjects.models;
using System;

namespace MusicObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Dorset Orchestra");

            //Guitar myGuitar = new();

            //Console.WriteLine(myGuitar.Play());

            Orchestra orchestra = new();
            orchestra.Play();
        }
    }
}