namespace TexterLib.Content
{
    public abstract class Content
    {
        private int _width;
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }
        public abstract string Render();
    }
}
