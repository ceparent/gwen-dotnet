﻿using System;
using System.Drawing;
using Gwen.Skin.Texturing;
using Single = Gwen.Skin.Texturing.Single;

namespace Gwen.Skin
{
    public struct SkinTextures
    {
        public Bordered StatusBar;
        public Bordered Selection;
        public Bordered Shadow;
        public Bordered Tooltip;

        public struct _Panel
        {
            public Bordered Normal;
            public Bordered Bright;
            public Bordered Dark;
            public Bordered Highlight;
        }

        public struct _Window
        {
            public Bordered Normal;
            public Bordered Inactive;
            public Single Close;
            public Single Close_Hover;
            public Single Close_Down;
            public Single Close_Disabled;
        }

        public struct _CheckBox
        {
            public struct _Active
            {
                public Single Normal;
                public Single Checked;
            }
            public struct _Disabled
            {
                public Single Normal;
                public Single Checked;
            }

            public _Active Active;
            public _Disabled Disabled;
        }

        public struct _RadioButton
        {
            public struct _Active
            {
                public Single Normal;
                public Single Checked;
            }
            public struct _Disabled
            {
                public Single Normal;
                public Single Checked;
            }

            public _Active Active;
            public _Disabled Disabled;
        }

        public struct _TextBox
        {
            public Bordered Normal;
            public Bordered Focus;
            public Bordered Disabled;
        }

        public struct _Tree
        {
            public Bordered Background;
            public Single Minus;
            public Single Plus;
        }

        public struct _ProgressBar
        {
            public Bordered Back;
            public Bordered Front;
        }

        public struct _Scroller
        {
            public Bordered TrackV;
            public Bordered TrackH;
            public Bordered ButtonV_Normal;
            public Bordered ButtonV_Hover;
            public Bordered ButtonV_Down;
            public Bordered ButtonV_Disabled;
            public Bordered ButtonH_Normal;
            public Bordered ButtonH_Hover;
            public Bordered ButtonH_Down;
            public Bordered ButtonH_Disabled;

            public struct _Button
            {
                public Bordered[] Normal;
                public Bordered[] Hover;
                public Bordered[] Down;
                public Bordered[] Disabled;
            }

            public _Button Button;
        }

        public struct _Menu
        {
            public Single RightArrow;
            public Single Check;

            public Bordered Strip;
            public Bordered Background;
            public Bordered BackgroundWithMargin;
            public Bordered Hover;
        }

        public struct _Input
        {
            public struct _Button
            {
                public Bordered Normal;
                public Bordered Hovered;
                public Bordered Disabled;
                public Bordered Pressed;
            }

            public struct _ComboBox
            {
                public Bordered Normal;
                public Bordered Hover;
                public Bordered Down;
                public Bordered Disabled;

                public struct _Button
                {
                    public Single Normal;
                    public Single Hover;
                    public Single Down;
                    public Single Disabled;
                }

                public _Button Button;
            }

            public struct _Slider
            {
                public struct _H
                {
                    public Single Normal;
                    public Single Hover;
                    public Single Down;
                    public Single Disabled;
                }

                public struct _V
                {
                    public Single Normal;
                    public Single Hover;
                    public Single Down;
                    public Single Disabled;
                }

                public _H H;
                public _V V;
            }

            public struct _ListBox
            {
                public Bordered Background;
                public Bordered Hovered;
                public Bordered EvenLine;
                public Bordered OddLine;
                public Bordered EvenLineSelected;
                public Bordered OddLineSelected;
            }

            public struct _UpDown
            {
                public struct _Up
                {
                    public Single Normal;
                    public Single Hover;
                    public Single Down;
                    public Single Disabled;
                }

                public struct _Down
                {
                    public Single Normal;
                    public Single Hover;
                    public Single Down;
                    public Single Disabled;
                }

                public _Up Up;
                public _Down Down;
            }

            public _Button Button;
            public _ComboBox ComboBox;
            public _Slider Slider;
            public _ListBox ListBox;
            public _UpDown UpDown;
        }

        public struct _Tab
        {
            public struct _Bottom
            {
                public Bordered Inactive;
                public Bordered Active;
            }

            public struct _Top
            {
                public Bordered Inactive;
                public Bordered Active;
            }

            public struct _Left
            {
                public Bordered Inactive;
                public Bordered Active;
            }

            public struct _Right
            {
                public Bordered Inactive;
                public Bordered Active;
            }

            public _Bottom Bottom;
            public _Top Top;
            public _Left Left;
            public _Right Right;

            public Bordered Control;
            public Bordered HeaderBar;
        }

        public _Panel Panel;
        public _Window Window;
        public _CheckBox CheckBox;
        public _RadioButton RadioButton;
        public _TextBox TextBox;
        public _Tree Tree;
        public _ProgressBar ProgressBar;
        public _Scroller Scroller;
        public _Menu Menu;
        public _Input Input;
        public _Tab Tab;
    }

    public class TexturedBase : Skin.Base
    {
        protected SkinTextures Textures;

        protected Texture m_Texture;

        public TexturedBase(Renderer.Base renderer, String TextureName)
            : base(renderer)
        {
            m_DefaultFont.FaceName = "Microsoft Sans Serif";
            m_DefaultFont.Size = 11;

            m_Texture = new Texture(Renderer);
            m_Texture.Load(TextureName);

            Colors.Window.TitleActive   = Renderer.PixelColour(m_Texture, 4 + 8 * 0, 508, Color.Red);
            Colors.Window.TitleInactive = Renderer.PixelColour(m_Texture, 4 + 8 * 1, 508, Color.Yellow);

            Colors.Button.Normal   = Renderer.PixelColour(m_Texture, 4 + 8 * 2, 508, Color.Yellow);
            Colors.Button.Hover    = Renderer.PixelColour(m_Texture, 4 + 8 * 3, 508, Color.Yellow);
            Colors.Button.Down     = Renderer.PixelColour(m_Texture, 4 + 8 * 2, 500, Color.Yellow);
            Colors.Button.Disabled = Renderer.PixelColour(m_Texture, 4 + 8 * 3, 500, Color.Yellow);

            Colors.Tab.Active.Normal     = Renderer.PixelColour(m_Texture, 4 + 8 * 4, 508, Color.Yellow);
            Colors.Tab.Active.Hover      = Renderer.PixelColour(m_Texture, 4 + 8 * 5, 508, Color.Yellow);
            Colors.Tab.Active.Down       = Renderer.PixelColour(m_Texture, 4 + 8 * 4, 500, Color.Yellow);
            Colors.Tab.Active.Disabled   = Renderer.PixelColour(m_Texture, 4 + 8 * 5, 500, Color.Yellow);
            Colors.Tab.Inactive.Normal   = Renderer.PixelColour(m_Texture, 4 + 8 * 6, 508, Color.Yellow);
            Colors.Tab.Inactive.Hover    = Renderer.PixelColour(m_Texture, 4 + 8 * 7, 508, Color.Yellow);
            Colors.Tab.Inactive.Down     = Renderer.PixelColour(m_Texture, 4 + 8 * 6, 500, Color.Yellow);
            Colors.Tab.Inactive.Disabled = Renderer.PixelColour(m_Texture, 4 + 8 * 7, 500, Color.Yellow);

            Colors.Label.Default   = Renderer.PixelColour(m_Texture, 4 + 8 * 8, 508, Color.Yellow);
            Colors.Label.Bright    = Renderer.PixelColour(m_Texture, 4 + 8 * 9, 508, Color.Yellow);
            Colors.Label.Dark      = Renderer.PixelColour(m_Texture, 4 + 8 * 8, 500, Color.Yellow);
            Colors.Label.Highlight = Renderer.PixelColour(m_Texture, 4 + 8 * 9, 500, Color.Yellow);

            Colors.Tree.Lines    = Renderer.PixelColour(m_Texture, 4 + 8 * 10, 508, Color.Yellow);
            Colors.Tree.Normal   = Renderer.PixelColour(m_Texture, 4 + 8 * 11, 508, Color.Yellow);
            Colors.Tree.Hover    = Renderer.PixelColour(m_Texture, 4 + 8 * 10, 500, Color.Yellow);
            Colors.Tree.Selected = Renderer.PixelColour(m_Texture, 4 + 8 * 11, 500, Color.Yellow);
        
            Colors.Properties.Line_Normal     = Renderer.PixelColour(m_Texture, 4 + 8 * 12, 508, Color.Yellow);
            Colors.Properties.Line_Selected   = Renderer.PixelColour(m_Texture, 4 + 8 * 13, 508, Color.Yellow);
            Colors.Properties.Line_Hover      = Renderer.PixelColour(m_Texture, 4 + 8 * 12, 500, Color.Yellow);
            Colors.Properties.Title           = Renderer.PixelColour(m_Texture, 4 + 8 * 13, 500, Color.Yellow);
            Colors.Properties.Column_Normal   = Renderer.PixelColour(m_Texture, 4 + 8 * 14, 508, Color.Yellow);
            Colors.Properties.Column_Selected = Renderer.PixelColour(m_Texture, 4 + 8 * 15, 508, Color.Yellow);
            Colors.Properties.Column_Hover    = Renderer.PixelColour(m_Texture, 4 + 8 * 14, 500, Color.Yellow);
            Colors.Properties.Border          = Renderer.PixelColour(m_Texture, 4 + 8 * 15, 500, Color.Yellow);
            Colors.Properties.Label_Normal    = Renderer.PixelColour(m_Texture, 4 + 8 * 16, 508, Color.Yellow);
            Colors.Properties.Label_Selected  = Renderer.PixelColour(m_Texture, 4 + 8 * 17, 508, Color.Yellow);
            Colors.Properties.Label_Hover     = Renderer.PixelColour(m_Texture, 4 + 8 * 16, 500, Color.Yellow);

            Colors.ModalBackground = Renderer.PixelColour(m_Texture, 4 + 8 * 18, 508, Color.Yellow);
            Colors.TooltipText     = Renderer.PixelColour(m_Texture, 4 + 8 * 19, 508, Color.Yellow);

            Textures.Shadow  = new Bordered(m_Texture, 448, 0, 31, 31, new Margin(8, 8, 8, 8));
            Textures.Tooltip = new Bordered(m_Texture, 128, 320, 127, 31, new Margin(8, 8, 8, 8));

            Textures.Panel.Normal    = new Bordered(m_Texture, 256, 0, 63, 63, new Margin(16, 16, 16, 16));
            Textures.Panel.Bright    = new Bordered(m_Texture, 256 + 64, 0, 63, 63, new Margin(16, 16, 16, 16));
            Textures.Panel.Dark      = new Bordered(m_Texture, 256, 64, 63, 63, new Margin(16, 16, 16, 16));
            Textures.Panel.Highlight = new Bordered(m_Texture, 256 + 64, 64, 63, 63, new Margin(16, 16, 16, 16));

            Textures.Window.Normal   = new Bordered(m_Texture, 0, 0, 127, 127, new Margin(8, 32, 8, 8));
            Textures.Window.Inactive = new Bordered(m_Texture, 128, 0, 127, 127, new Margin(8, 32, 8, 8));

            Textures.CheckBox.Active.Checked  = new Single(m_Texture, 448, 32, 15, 15);
            Textures.CheckBox.Active.Normal   = new Single(m_Texture, 464, 32, 15, 15);
            Textures.CheckBox.Disabled.Normal = new Single(m_Texture, 448, 48, 15, 15);
            Textures.CheckBox.Disabled.Normal = new Single(m_Texture, 464, 48, 15, 15);

            Textures.RadioButton.Active.Checked  = new Single(m_Texture, 448, 64, 15, 15);
            Textures.RadioButton.Active.Normal   = new Single(m_Texture, 464, 64, 15, 15);
            Textures.RadioButton.Disabled.Normal = new Single(m_Texture, 448, 80, 15, 15);
            Textures.RadioButton.Disabled.Normal = new Single(m_Texture, 464, 80, 15, 15);

            Textures.TextBox.Normal   = new Bordered(m_Texture, 0, 150, 127, 21, new Margin(4, 4, 4, 4));
            Textures.TextBox.Focus    = new Bordered(m_Texture, 0, 172, 127, 21, new Margin(4, 4, 4, 4));
            Textures.TextBox.Disabled = new Bordered(m_Texture, 0, 193, 127, 21, new Margin(4, 4, 4, 4));

            Textures.Menu.Strip                = new Bordered(m_Texture, 0, 128, 127, 21, new Margin(1, 1, 1, 1));
            Textures.Menu.BackgroundWithMargin = new Bordered(m_Texture, 128, 128, 127, 63, new Margin(24, 8, 8, 8));
            Textures.Menu.Background           = new Bordered(m_Texture, 128, 192, 127, 63, new Margin(8, 8, 8, 8));
            Textures.Menu.Hover                = new Bordered(m_Texture, 128, 256, 127, 31, new Margin(8, 8, 8, 8));
            Textures.Menu.RightArrow           = new Single(m_Texture, 464, 112, 15, 15);
            Textures.Menu.Check                = new Single(m_Texture, 448, 112, 15, 15);

            Textures.Tab.Control         = new Bordered(m_Texture, 0, 256, 127, 127, new Margin(8, 8, 8, 8));
            Textures.Tab.Bottom.Active   = new Bordered(m_Texture, 0, 416, 63, 31, new Margin(8, 8, 8, 8));
            Textures.Tab.Bottom.Inactive = new Bordered(m_Texture, 0 + 128, 416, 63, 31, new Margin(8, 8, 8, 8));
            Textures.Tab.Top.Active      = new Bordered(m_Texture, 0, 384, 63, 31, new Margin(8, 8, 8, 8));
            Textures.Tab.Top.Inactive    = new Bordered(m_Texture, 0 + 128, 384, 63, 31, new Margin(8, 8, 8, 8));
            Textures.Tab.Left.Active     = new Bordered(m_Texture, 64, 384, 31, 63, new Margin(8, 8, 8, 8));
            Textures.Tab.Left.Inactive   = new Bordered(m_Texture, 64 + 128, 384, 31, 63, new Margin(8, 8, 8, 8));
            Textures.Tab.Right.Active    = new Bordered(m_Texture, 96, 384, 31, 63, new Margin(8, 8, 8, 8));
            Textures.Tab.Right.Inactive  = new Bordered(m_Texture, 96 + 128, 384, 31, 63, new Margin(8, 8, 8, 8));
            Textures.Tab.HeaderBar       = new Bordered(m_Texture, 128, 352, 127, 31, new Margin(4, 4, 4, 4));

            Textures.Window.Close       = new Single(m_Texture, 0, 224, 24, 24);
            Textures.Window.Close_Hover = new Single(m_Texture, 32, 224, 24, 24);
            Textures.Window.Close_Hover = new Single(m_Texture, 64, 224, 24, 24);
            Textures.Window.Close_Hover = new Single(m_Texture, 96, 224, 24, 24);

            Textures.Scroller.TrackV           = new Bordered(m_Texture, 384, 208, 15, 127, new Margin(4, 4, 4, 4));
            Textures.Scroller.ButtonV_Normal   = new Bordered(m_Texture, 384 + 16, 208, 15, 127, new Margin(4, 4, 4, 4));
            Textures.Scroller.ButtonV_Hover    = new Bordered(m_Texture, 384 + 32, 208, 15, 127, new Margin(4, 4, 4, 4));
            Textures.Scroller.ButtonV_Down     = new Bordered(m_Texture, 384 + 48, 208, 15, 127, new Margin(4, 4, 4, 4));
            Textures.Scroller.ButtonV_Disabled = new Bordered(m_Texture, 384 + 64, 208, 15, 127, new Margin(4, 4, 4, 4));

            Textures.Scroller.TrackH           = new Bordered(m_Texture, 384, 128, 127, 15, new Margin(4, 4, 4, 4));
            Textures.Scroller.ButtonH_Normal   = new Bordered(m_Texture, 384, 128 + 16, 127, 15, new Margin(4, 4, 4, 4));
            Textures.Scroller.ButtonH_Hover    = new Bordered(m_Texture, 384, 128 + 32, 127, 15, new Margin(4, 4, 4, 4));
            Textures.Scroller.ButtonH_Down     = new Bordered(m_Texture, 384, 128 + 48, 127, 15, new Margin(4, 4, 4, 4));
            Textures.Scroller.ButtonH_Disabled = new Bordered(m_Texture, 384, 128 + 64, 127, 15, new Margin(4, 4, 4, 4));

            Textures.Scroller.Button.Normal   = new Bordered[4];
            Textures.Scroller.Button.Disabled = new Bordered[4];
            Textures.Scroller.Button.Hover    = new Bordered[4];
            Textures.Scroller.Button.Down     = new Bordered[4];

            Textures.Tree.Background = new Bordered(m_Texture, 256, 128, 127, 127, new Margin(16, 16, 16, 16));
            Textures.Tree.Plus = new Single(m_Texture, 448, 96, 15, 15);
            Textures.Tree.Minus = new Single(m_Texture, 464, 96, 15, 15);


            Textures.Input.Button.Normal = new Bordered(m_Texture, 480, 0, 31, 31, new Margin(8, 8, 8, 8));
            Textures.Input.Button.Hovered = new Bordered(m_Texture, 480, 32, 31, 31, new Margin(8, 8, 8, 8));
            Textures.Input.Button.Disabled = new Bordered(m_Texture, 480, 64, 31, 31, new Margin(8, 8, 8, 8));
            Textures.Input.Button.Pressed = new Bordered(m_Texture, 480, 96, 31, 31, new Margin(8, 8, 8, 8));

            for (int i = 0; i < 4; i++)
            {
                Textures.Scroller.Button.Normal[i] = new Bordered(m_Texture, 464 + 0, 208 + i*16, 15, 15,
                                                                  new Margin(2, 2, 2, 2));
                Textures.Scroller.Button.Hover[i] = new Bordered(m_Texture, 480, 208 + i*16, 15, 15,
                                                                 new Margin(2, 2, 2, 2));
                Textures.Scroller.Button.Down[i] = new Bordered(m_Texture, 464, 272 + i*16, 15, 15,
                                                                new Margin(2, 2, 2, 2));
                Textures.Scroller.Button.Disabled[i] = new Bordered(m_Texture, 480 + 48, 272 + i*16, 15, 15,
                                                                    new Margin(2, 2, 2, 2));
            }

            Textures.Input.ListBox.Background       = new Bordered(m_Texture, 256, 256, 63, 127, new Margin(8, 8, 8, 8));
            Textures.Input.ListBox.Hovered          = new Bordered(m_Texture, 320, 320, 31, 31, new Margin(8, 8, 8, 8));
            Textures.Input.ListBox.EvenLine         = new Bordered(m_Texture, 352, 256, 31, 31, new Margin(8, 8, 8, 8));
            Textures.Input.ListBox.OddLine          = new Bordered(m_Texture, 352, 288, 31, 31, new Margin(8, 8, 8, 8));
            Textures.Input.ListBox.EvenLineSelected = new Bordered(m_Texture, 320, 270, 31, 31, new Margin(8, 8, 8, 8));
            Textures.Input.ListBox.OddLineSelected  = new Bordered(m_Texture, 320, 288, 31, 31, new Margin(8, 8, 8, 8));

            Textures.Input.ComboBox.Normal          = new Bordered(m_Texture, 384, 336, 127, 31, new Margin(8, 8, 32, 8));
            Textures.Input.ComboBox.Hover           = new Bordered(m_Texture, 384, 336 + 32, 127, 31, new Margin(8, 8, 32, 8));
            Textures.Input.ComboBox.Down            = new Bordered(m_Texture, 384, 336 + 64, 127, 31, new Margin(8, 8, 32, 8));
            Textures.Input.ComboBox.Disabled        = new Bordered(m_Texture, 384, 336 + 96, 127, 31, new Margin(8, 8, 32, 8));
            Textures.Input.ComboBox.Button.Normal   = new Single(m_Texture, 496, 272, 15, 15);
            Textures.Input.ComboBox.Button.Hover    = new Single(m_Texture, 496, 272 + 16, 15, 15);
            Textures.Input.ComboBox.Button.Down     = new Single(m_Texture, 496, 272 + 32, 15, 15);
            Textures.Input.ComboBox.Button.Disabled = new Single(m_Texture, 496, 272 + 48, 15, 15);

            Textures.Input.UpDown.Up.Normal     = new Single(m_Texture, 384, 112, 7, 7);
            Textures.Input.UpDown.Up.Hover      = new Single(m_Texture, 384 + 8, 112, 7, 7);
            Textures.Input.UpDown.Up.Down       = new Single(m_Texture, 384 + 16, 112, 7, 7);
            Textures.Input.UpDown.Up.Disabled   = new Single(m_Texture, 384 + 24, 112, 7, 7);
            Textures.Input.UpDown.Down.Normal   = new Single(m_Texture, 384, 120, 7, 7);
            Textures.Input.UpDown.Down.Hover    = new Single(m_Texture, 384 + 8, 120, 7, 7);
            Textures.Input.UpDown.Down.Down     = new Single(m_Texture, 384 + 16, 120, 7, 7);
            Textures.Input.UpDown.Down.Disabled = new Single(m_Texture, 384 + 24, 120, 7, 7);

            Textures.ProgressBar.Back  = new Bordered(m_Texture, 384, 0, 31, 31, new Margin(8, 8, 8, 8));
            Textures.ProgressBar.Front = new Bordered(m_Texture, 384 + 32, 0, 31, 31, new Margin(8, 8, 8, 8));

            Textures.Input.Slider.H.Normal   = new Single(m_Texture, 416, 32, 15, 15);
            Textures.Input.Slider.H.Hover    = new Single(m_Texture, 416, 32 + 16, 15, 15);
            Textures.Input.Slider.H.Down     = new Single(m_Texture, 416, 32 + 32, 15, 15);
            Textures.Input.Slider.H.Disabled = new Single(m_Texture, 416, 32 + 48, 15, 15);

            Textures.Input.Slider.V.Normal   = new Single(m_Texture, 416 + 16, 32, 15, 15);
            Textures.Input.Slider.V.Hover    = new Single(m_Texture, 416 + 16, 32 + 16, 15, 15);
            Textures.Input.Slider.V.Down     = new Single(m_Texture, 416 + 16, 32 + 32, 15, 15);
            Textures.Input.Slider.V.Disabled = new Single(m_Texture, 416 + 16, 32 + 48, 15, 15);

            Textures.StatusBar = new Bordered(m_Texture, 128, 288, 127, 31, new Margin(8, 8, 8, 8));

            Textures.Selection = new Bordered(m_Texture, 384, 32, 31, 31, new Margin(4, 4, 4, 4));
        }

        public override void DrawButton(Controls.Base control, bool bDepressed, bool bHovered, bool disabled)
        {
            if (disabled)
            {
                Textures.Input.Button.Disabled.Draw(Renderer, control.RenderBounds);
                return;
            }
            if (bDepressed)
            {
                Textures.Input.Button.Pressed.Draw(Renderer, control.RenderBounds);
                return;
            }
            if (bHovered)
            {
                Textures.Input.Button.Hovered.Draw(Renderer, control.RenderBounds);
                return;
            }
            Textures.Input.Button.Normal.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawMenuRightArrow(Controls.Base control)
        {
            Textures.Menu.RightArrow.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawMenuItem(Controls.Base control, bool bSubmenuOpen, bool bChecked)
        {
            if (bSubmenuOpen || control.IsHovered)
                Textures.Menu.Hover.Draw(Renderer, control.RenderBounds);

            if (bChecked)
                Textures.Menu.Check.Draw(Renderer, new Rectangle(control.RenderBounds.X + 4, control.RenderBounds.Y + 3, 15, 15));
        }

        public override void DrawMenuStrip(Controls.Base control)
        {
            Textures.Menu.Strip.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawMenu(Controls.Base control, bool bPaddingDisabled)
        {
            if (!bPaddingDisabled)
            {
                Textures.Menu.BackgroundWithMargin.Draw(Renderer, control.RenderBounds);
                return;
            }

            Textures.Menu.Background.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawShadow(Controls.Base control)
        {
            Rectangle r = control.RenderBounds;
            r.X -= 4;
            r.Y -= 4;
            r.Width += 10;
            r.Height += 10;
            Textures.Shadow.Draw(Renderer, r);
        }

        public override void DrawRadioButton(Controls.Base control, bool bSelected, bool bDepressed)
        {
            if (bSelected)
            {
                if (control.IsDisabled)
                    Textures.RadioButton.Disabled.Checked.Draw(Renderer, control.RenderBounds);
                else
                    Textures.RadioButton.Active.Checked.Draw(Renderer, control.RenderBounds);
            }
            else
            {
                if (control.IsDisabled)
                    Textures.RadioButton.Disabled.Normal.Draw(Renderer, control.RenderBounds);
                else
                    Textures.RadioButton.Active.Normal.Draw(Renderer, control.RenderBounds);
            }
        }

        public override void DrawCheckBox(Controls.Base control, bool bSelected, bool bDepressed)
        {
            if (bSelected)
            {
                if (control.IsDisabled)
                    Textures.CheckBox.Disabled.Checked.Draw(Renderer, control.RenderBounds);
                else
                    Textures.CheckBox.Active.Checked.Draw(Renderer, control.RenderBounds);
            }
            else
            {
                if (control.IsDisabled)
                    Textures.CheckBox.Disabled.Normal.Draw(Renderer, control.RenderBounds);
                else
                    Textures.CheckBox.Active.Normal.Draw(Renderer, control.RenderBounds);
            }
        }

        public override void DrawGroupBox(Controls.Base control, int textStart, int textHeight, int textWidth)
        {
            Rectangle rect = control.RenderBounds;

            rect.Y += Global.Trunc(textHeight * 0.5f);
            rect.Height -= Global.Trunc(textHeight * 0.5f);

            Color m_colDarker = Color.FromArgb(50, 0, 50, 60);
            Color m_colLighter = Color.FromArgb(150, 255, 255, 255);

            Renderer.DrawColor = m_colLighter;

            Renderer.DrawFilledRect(new Rectangle(rect.X + 1, rect.Y + 1, textStart - 3, 1));
            Renderer.DrawFilledRect(new Rectangle(rect.X + 1 + textStart + textWidth, rect.Y + 1, rect.Width - textStart + textWidth - 2, 1));
            Renderer.DrawFilledRect(new Rectangle(rect.X + 1, (rect.Y + rect.Height) - 1, rect.X + rect.Width - 2, 1));

            Renderer.DrawFilledRect(new Rectangle(rect.X + 1, rect.Y + 1, 1, rect.Height));
            Renderer.DrawFilledRect(new Rectangle((rect.X + rect.Width) - 2, rect.Y + 1, 1, rect.Height - 1));

            Renderer.DrawColor = m_colDarker;

            Renderer.DrawFilledRect(new Rectangle(rect.X + 1, rect.Y, textStart - 3, 1));
            Renderer.DrawFilledRect(new Rectangle(rect.X + 1 + textStart + textWidth, rect.Y, rect.Width - textStart - textWidth - 2, 1));
            Renderer.DrawFilledRect(new Rectangle(rect.X + 1, (rect.Y + rect.Height) - 1, rect.X + rect.Width - 2, 1));

            Renderer.DrawFilledRect(new Rectangle(rect.X, rect.Y + 1, 1, rect.Height - 1));
            Renderer.DrawFilledRect(new Rectangle((rect.X + rect.Width) - 1, rect.Y + 1, 1, rect.Height - 1));
        }

        public override void DrawTextBox(Controls.Base control)
        {
            if (control.IsDisabled)
            {
                Textures.TextBox.Disabled.Draw(Renderer, control.RenderBounds);
                return;
            }

            if (control.HasFocus)
                Textures.TextBox.Focus.Draw(Renderer, control.RenderBounds);
            else
                Textures.TextBox.Normal.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawTabButton(Controls.Base control, bool bActive, Pos dir)
        {
            if (bActive)
            {
                DrawActiveTabButton(control, dir);
                return;
            }

            if (dir == Pos.Top)
            {
                Textures.Tab.Top.Inactive.Draw(Renderer, control.RenderBounds);
                return;
            }
            if (dir == Pos.Left)
            {
                Textures.Tab.Left.Inactive.Draw(Renderer, control.RenderBounds);
                return;
            }
            if (dir == Pos.Bottom)
            {
                Textures.Tab.Bottom.Inactive.Draw(Renderer, control.RenderBounds);
                return;
            }
            if (dir == Pos.Right)
            {
                Textures.Tab.Right.Inactive.Draw(Renderer, control.RenderBounds);
                return;
            }
        }

        private void DrawActiveTabButton(Controls.Base control, Pos dir)
        {
            Renderer.EndClip();
            if (dir == Pos.Top)
            {
                Textures.Tab.Top.Active.Draw(Renderer, control.RenderBounds.Add(new Rectangle(0, 0, 0, 8)));
                return;
            }
            if (dir == Pos.Left)
            {
                Textures.Tab.Left.Active.Draw(Renderer, control.RenderBounds.Add(new Rectangle(0, 0, 8, 0)));
                return;
            }
            if (dir == Pos.Bottom)
            {
                Textures.Tab.Bottom.Active.Draw(Renderer, control.RenderBounds.Add(new Rectangle(0, -8, 0, 8)));
                return;
            }
            if (dir == Pos.Right)
            {
                Textures.Tab.Right.Active.Draw(Renderer, control.RenderBounds.Add(new Rectangle(-8, 0, 8, 0)));
                return;
            }
        }

        public override void DrawTabControl(Controls.Base control)
        {
            Textures.Tab.Control.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawTabTitleBar(Controls.Base control)
        {
            Textures.Tab.HeaderBar.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawWindow(Controls.Base control, int topHeight, bool inFocus)
        {
            if (inFocus) 
               Textures.Window.Normal.Draw(Renderer, control.RenderBounds);
            else 
                Textures.Window.Inactive.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawHighlight(Controls.Base control)
        {
            Rectangle rect = control.RenderBounds;
            Renderer.DrawColor = Color.FromArgb(255, 255, 100, 255);
            Renderer.DrawFilledRect(rect);
        }

        public override void DrawScrollBar(Controls.Base control, bool isHorizontal, bool bDepressed)
        {
            if (isHorizontal)
                Textures.Scroller.TrackH.Draw(Renderer, control.RenderBounds);
            else
                Textures.Scroller.TrackV.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawScrollBarBar(Controls.Base control, bool bDepressed, bool isHovered, bool isHorizontal)
        {
            if (!isHorizontal)
            {
                if (control.IsDisabled)
                {
                    Textures.Scroller.ButtonV_Disabled.Draw(Renderer, control.RenderBounds);
                    return;
                }

                if (bDepressed)
                {
                    Textures.Scroller.ButtonV_Down.Draw(Renderer, control.RenderBounds);
                    return;
                }

                if (isHovered)
                {
                    Textures.Scroller.ButtonV_Hover.Draw(Renderer, control.RenderBounds);
                    return;
                }

                Textures.Scroller.ButtonV_Normal.Draw(Renderer, control.RenderBounds);
                return;
            }

            if (control.IsDisabled)
            {
                Textures.Scroller.ButtonH_Disabled.Draw(Renderer, control.RenderBounds);
                return;
            }

            if (bDepressed)
            {
                Textures.Scroller.ButtonH_Down.Draw(Renderer, control.RenderBounds);
                return;
            }

            if (isHovered)
            {
                Textures.Scroller.ButtonH_Hover.Draw(Renderer, control.RenderBounds);
                return;
            }

            Textures.Scroller.ButtonH_Normal.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawProgressBar(Controls.Base control, bool isHorizontal, float progress)
        {
            Rectangle rect = control.RenderBounds;
            Color FillColour = Color.FromArgb(255, 0, 211, 40);

            if (isHorizontal)
            {
                Textures.ProgressBar.Back.Draw(Renderer, rect);
                rect.Width = (int)(rect.Width*progress);
                Textures.ProgressBar.Front.Draw(Renderer, rect);
            }
            else
            {
                Textures.ProgressBar.Back.Draw(Renderer, rect);
                rect.Y = (int)(rect.Height*(1-progress));
                rect.Width = (int)(rect.Width * progress);
                Textures.ProgressBar.Front.Draw(Renderer, rect);
            }
        }

        public override void DrawListBox(Controls.Base control)
        {
            Textures.Input.ListBox.Background.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawListBoxLine(Controls.Base control, bool bSelected, bool even)
        {
            Rectangle rect = control.RenderBounds;

            if (bSelected)
            {
                if (even)
                {
                    Textures.Input.ListBox.EvenLineSelected.Draw(Renderer, control.RenderBounds);
                    return;
                }
                Textures.Input.ListBox.OddLineSelected.Draw(Renderer, control.RenderBounds);
                return;
            }
            
            if (control.IsHovered)
            {
                Textures.Input.ListBox.Hovered.Draw(Renderer, control.RenderBounds);
                return;
            }

            if (even)
            {
                Textures.Input.ListBox.EvenLine.Draw(Renderer, control.RenderBounds);
                return;
            }

            Textures.Input.ListBox.OddLine.Draw(Renderer, control.RenderBounds);
        }

        public void DrawSliderNotchesH(Rectangle rect, int numNotches, float dist)
        {
            if (numNotches == 0) return;

            float iSpacing = rect.Width / (float)numNotches;
            for (int i = 0; i < numNotches + 1; i++)
                Renderer.DrawFilledRect(Global.FloatRect(rect.X + iSpacing * i, rect.Y + dist - 2, 1, 5));
        }

        public void DrawSliderNotchesV(Rectangle rect, int numNotches, float dist)
        {
            if (numNotches == 0) return;

            float iSpacing = rect.Height / (float)numNotches;
            for (int i = 0; i < numNotches + 1; i++)
                Renderer.DrawFilledRect(Global.FloatRect(rect.X + dist - 2, rect.Y + iSpacing * i, 5, 1));
        }

        public override void DrawSlider(Controls.Base control, bool bIsHorizontal, int numNotches, int barSize)
        {
            Rectangle rect = control.RenderBounds;
            Renderer.DrawColor = Color.FromArgb(100, 0, 0, 0);

            if (bIsHorizontal)
            {
                rect.X += (int) (barSize*0.5);
                rect.Width -= barSize;
                rect.Y += (int)(rect.Height * 0.5 - 1);
                rect.Height = 1;
                DrawSliderNotchesH(rect, numNotches, barSize*0.5f);
                Renderer.DrawFilledRect(rect);
                return;
            }

            rect.Y += (int)(barSize * 0.5);
            rect.Height -= barSize;
            rect.X += (int)(rect.Width * 0.5 - 1);
            rect.Width = 1;
            DrawSliderNotchesV(rect, numNotches, barSize * 0.4f);
            Renderer.DrawFilledRect(rect);
        }

        public override void DrawComboBox(Controls.Base control, bool down, bool open)
        {
            if (control.IsDisabled)
            {
                Textures.Input.ComboBox.Disabled.Draw(Renderer, control.RenderBounds);
                return;
            }

            if (down || open)
            {
                Textures.Input.ComboBox.Down.Draw(Renderer, control.RenderBounds);
                return;
            }

            if (control.IsHovered)
            {
                Textures.Input.ComboBox.Down.Draw(Renderer, control.RenderBounds);
                return;
            }

            Textures.Input.ComboBox.Normal.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawKeyboardHighlight(Controls.Base control, Rectangle r, int iOffset)
        {
            Rectangle rect = r;

            rect.X += iOffset;
            rect.Y += iOffset;
            rect.Width -= iOffset * 2;
            rect.Height -= iOffset * 2;

            //draw the top and bottom
            bool skip = true;
            for (int i = 0; i < rect.Width * 0.5; i++)
            {
                m_Render.DrawColor = Color.Black;
                if (!skip)
                {
                    Renderer.DrawPixel(rect.X + (i * 2), rect.Y);
                    Renderer.DrawPixel(rect.X + (i * 2), rect.Y + rect.Height - 1);
                }
                else
                    skip = !skip;
            }
            skip = false;
            for (int i = 0; i < rect.Height * 0.5; i++)
            {
                Renderer.DrawColor = Color.Black;
                if (!skip)
                {
                    Renderer.DrawPixel(rect.X, rect.Y + i * 2);
                    Renderer.DrawPixel(rect.X + rect.Width - 1, rect.Y + i * 2);
                }
                else
                    skip = !skip;
            }
        }

        public override void DrawToolTip(Controls.Base control)
        {
            Textures.Tooltip.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawScrollButton(Controls.Base control, Pos iDirection, bool bDepressed, bool hovered, bool disabled)
        {
            int i = 0;
            if (iDirection == Pos.Top) i = 1;
            if (iDirection == Pos.Right) i = 2;
            if (iDirection == Pos.Bottom) i = 3;

            if (disabled)
            {
                Textures.Scroller.Button.Disabled[i].Draw(Renderer, control.RenderBounds);
                return;
            }

            if (bDepressed)
            {
                Textures.Scroller.Button.Down[i].Draw(Renderer, control.RenderBounds);
                return;
            }

            if (hovered)
            {
                Textures.Scroller.Button.Hover[i].Draw(Renderer, control.RenderBounds);
                return;
            }

            Textures.Scroller.Button.Normal[i].Draw(Renderer, control.RenderBounds);
        }

        public override void DrawComboBoxArrow(Controls.Base control, bool hovered, bool down, bool open, bool disabled)
        {
            if (disabled)
            {
                Textures.Input.ComboBox.Button.Disabled.Draw(Renderer, control.RenderBounds);
                return;
            }

            if (down || open)
            {
                Textures.Input.ComboBox.Button.Down.Draw(Renderer, control.RenderBounds);
                return;
            }

            if (hovered)
            {
                Textures.Input.ComboBox.Button.Hover.Draw(Renderer, control.RenderBounds);
                return;
            }

            Textures.Input.ComboBox.Button.Normal.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawNumericUpDownButton(Controls.Base control, bool bDepressed, bool bUp)
        {
            if (bUp)
            {
                if (control.IsDisabled)
                {
                    Textures.Input.UpDown.Up.Disabled.DrawCenter(Renderer, control.RenderBounds);
                    return;
                }

                if (bDepressed)
                {
                    Textures.Input.UpDown.Up.Down.DrawCenter(Renderer, control.RenderBounds);
                    return;
                }

                if (control.IsHovered)
                {
                    Textures.Input.UpDown.Up.Hover.DrawCenter(Renderer, control.RenderBounds);
                    return;
                }

                Textures.Input.UpDown.Up.Normal.DrawCenter(Renderer, control.RenderBounds);
                return;
            }

            if (control.IsDisabled)
            {
                Textures.Input.UpDown.Down.Disabled.DrawCenter(Renderer, control.RenderBounds);
                return;
            }

            if (bDepressed)
            {
                Textures.Input.UpDown.Down.Down.DrawCenter(Renderer, control.RenderBounds);
                return;
            }

            if (control.IsHovered)
            {
                Textures.Input.UpDown.Down.Hover.DrawCenter(Renderer, control.RenderBounds);
                return;
            }

            Textures.Input.UpDown.Down.Normal.DrawCenter(Renderer, control.RenderBounds);
        }

        public override void DrawStatusBar(Controls.Base control)
        {
            Textures.StatusBar.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawTreeButton(Controls.Base control, bool bOpen)
        {
            Rectangle rect = control.RenderBounds;

            if (bOpen)
                Textures.Tree.Minus.Draw(Renderer, rect);
            else
                Textures.Tree.Plus.Draw(Renderer, rect);
        }

        public override void DrawTreeControl(Controls.Base control)
        {
            Textures.Tree.Background.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawTreeNode(Controls.Base ctrl, bool bOpen, bool bSelected, int iLabelHeight, int iLabelWidth, int iHalfWay, int iLastBranch, bool bIsRoot)
        {
            if (bSelected)
            {
                Textures.Selection.Draw(Renderer, new Rectangle(17, 0, iLabelWidth + 2, iLabelHeight - 1));
            }

            base.DrawTreeNode(ctrl, bOpen, bSelected, iLabelHeight, iLabelWidth, iHalfWay, iLastBranch, bIsRoot);
        }

        public override void DrawColorDisplay(Controls.Base control, Color color)
        {
            Rectangle rect = control.RenderBounds;

            if (color.A != 255)
            {
                Renderer.DrawColor = Color.FromArgb(255, 255, 255, 255);
                Renderer.DrawFilledRect(rect);

                Renderer.DrawColor = Color.FromArgb(128, 128, 128, 128);

                Renderer.DrawFilledRect(Global.FloatRect(0, 0, rect.Width * 0.5f, rect.Height * 0.5f));
                Renderer.DrawFilledRect(Global.FloatRect(rect.Width * 0.5f, rect.Height * 0.5f, rect.Width * 0.5f, rect.Height * 0.5f));
            }

            Renderer.DrawColor = color;
            Renderer.DrawFilledRect(rect);

            Renderer.DrawColor = Color.Black;
            Renderer.DrawLinedRect(rect);
        }

        public override void DrawModalControl(Controls.Base control)
        {
            if (control.ShouldDrawBackground)
            {
                Rectangle rect = control.RenderBounds;
                Renderer.DrawColor = Colors.ModalBackground;
                Renderer.DrawFilledRect(rect);
            }
        }

        public override void DrawMenuDivider(Controls.Base control)
        {
            Rectangle rect = control.RenderBounds;
            Renderer.DrawColor = Color.FromArgb(100, 0, 0, 0);
            Renderer.DrawFilledRect(rect);
        }

        public override void DrawWindowCloseButton(Controls.Base control, bool depressed, bool hovered, bool disabled)
        {

            if (disabled)
            {
                Textures.Window.Close_Disabled.Draw(Renderer, control.RenderBounds);
                return;
            }

            if (depressed)
            {
                Textures.Window.Close_Down.Draw(Renderer, control.RenderBounds);
                return;
            }

            if (hovered)
            {
                Textures.Window.Close_Hover.Draw(Renderer, control.RenderBounds);
                return;
            }

            Textures.Window.Close.Draw(Renderer, control.RenderBounds);
        }

        public override void DrawSliderButton(Controls.Base control, bool depressed, bool horizontal)
        {
            if (!horizontal)
            {
                if (control.IsDisabled)
                {
                    Textures.Input.Slider.V.Disabled.DrawCenter(Renderer, control.RenderBounds);
                    return;
                }
                
                if (depressed)
                {
                    Textures.Input.Slider.V.Down.DrawCenter(Renderer, control.RenderBounds);
                    return;
                }
                
                if (control.IsHovered)
                {
                    Textures.Input.Slider.V.Hover.DrawCenter(Renderer, control.RenderBounds);
                    return;
                }

                Textures.Input.Slider.V.Normal.DrawCenter(Renderer, control.RenderBounds);
                return;
            }

            if (control.IsDisabled)
            {
                Textures.Input.Slider.H.Disabled.DrawCenter(Renderer, control.RenderBounds);
                return;
            }

            if (depressed)
            {
                Textures.Input.Slider.H.Down.DrawCenter(Renderer, control.RenderBounds);
                return;
            }

            if (control.IsHovered)
            {
                Textures.Input.Slider.H.Hover.DrawCenter(Renderer, control.RenderBounds);
                return;
            }

            Textures.Input.Slider.H.Normal.DrawCenter(Renderer, control.RenderBounds);
        }
    }
}
