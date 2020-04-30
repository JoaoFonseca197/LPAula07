// Fully documented version of this exercise available at
// http://starboundsoftware.com/books/c-sharp/try-it-out/designing-and-building-classes
namespace CollorBallsWithProperties
{
    class Color
    {
        // Instance variables
        public byte Red{ get; set;}
        public byte Green{ get; set;}
        public byte Blue{ get; set;}
        public byte Alpha{ get; set;}

        public byte GetGrayscale => (byte)((Red + Green + Blue)/3);

        // Constructors
        public Color(byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }



        // Additional getter method - the difference in this one is that it
        // returns a value which is not directly part of the object state
        // Setters

    }

}

