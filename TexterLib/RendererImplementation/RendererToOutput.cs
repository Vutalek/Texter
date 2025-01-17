using TexterLib.Renderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TexterLib.Content;
using TexterLib.Output;

namespace TexterLib.RendererImplementation
{
    public class RendererToOutput : AbstractRenderer
    {
        private IOutput _output;

        public RendererToOutput(IOutput output)
        {
            _output = output;
        }

        public override void Render(AbstractContent content)
        {
            _output.Write(content.Render());
        }
    }
}
