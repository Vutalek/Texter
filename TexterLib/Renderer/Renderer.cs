namespace TexterLib.Renderer
{
    public abstract class Renderer
    {
        private bool is_alive;

        public Renderer()
        {
            is_alive = true;
        }

        public bool IsAlive()
        {
            return is_alive;
        }

        public void Kill()
        {
            is_alive = false;
        }

        public void Resurrect()
        {
            is_alive = true;
        }

        public abstract void Render(Content.Content content);
    }
}
