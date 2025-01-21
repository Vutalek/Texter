using TexterLib.Output;

namespace TexterLib.RendererImplementation
{
    public class RendererToOutput : Renderer.Renderer
    {
        private IOutput _output;

        public RendererToOutput(IOutput output)
        {
            _output = output;
        }

        public override void Render(Content.Content content)
        {
            _output.Write(content.Render());
        }
    }
}
