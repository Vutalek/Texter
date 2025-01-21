namespace TexterLib.Content
{
    public abstract class Content
    {
        private int _width;
        public int Width
        {
            get { return _width; }
        }
        public virtual void Align(int width)
        {
            _width = width;
        }
        public abstract string Render();
    }
}
