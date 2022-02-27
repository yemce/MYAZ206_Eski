namespace ValueAndReferanceTypes
{
    public struct ValueType
    {

        public ValueType(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class ReferenceType
    {
        public ReferenceType(int x,int y)
        {
            X = x;
            Y = y;
            
        }

        public int X { get; set; }

        public  int Y { get; set; }
    }

}