using TexterLib.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TexterLib.Renderer
{
    public abstract class AbstractRenderer
    {
        private bool is_alive;

        public AbstractRenderer()
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

        public abstract void Render(AbstractContent content);
    }
}
