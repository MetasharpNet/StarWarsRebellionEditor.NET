namespace SwRebellionEditor
{
    public class ArraySizeAttribute : Attribute
    {
        public int Id;

        public ArraySizeAttribute(int id = 0)
        {
            Id = id;
        }
    }
}
