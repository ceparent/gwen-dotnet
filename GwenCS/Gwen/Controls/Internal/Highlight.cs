using Gwen.Drawing;

namespace Gwen.Controls.Internal
{
    /// <summary>
    /// Drag & drop highlight.
    /// </summary>
    public class Highlight : Control
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Highlight"/> class.
        /// </summary>
        /// <param name="parent">Parent control.</param>
        public Highlight(Control parent) : base(parent)
        {
            
        }

        /// <summary>
        /// Renders the control using specified skin.
        /// </summary>
        /// <param name="skin">Skin to use.</param>
        protected override void Render(Skin skin)
        {
            skin.DrawHighlight(this);
        }
    }
}
