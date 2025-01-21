namespace TexterLib.ContentImplementation
{
    public class Br : Content.Content
    {
        public Br(int width = 10) 
        {
            Width = width;
        }

        public override string Render()
        {
            return "\r\n";
        }
    }
}
