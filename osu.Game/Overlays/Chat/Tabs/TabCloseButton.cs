﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Framework.Graphics;
using osu.Framework.Input.Events;
using osu.Game.Graphics;
using osu.Game.Graphics.Containers;
using OpenTK;
using OpenTK.Graphics;

namespace osu.Game.Overlays.Chat.Tabs
{
    public class TabCloseButton : OsuClickableContainer
    {
        private readonly SpriteIcon icon;

        public TabCloseButton()
        {
            Size = new Vector2(20);

            Child = icon = new SpriteIcon
            {
                Anchor = Anchor.Centre,
                Origin = Anchor.Centre,
                Scale = new Vector2(0.75f),
                Icon = FontAwesome.fa_close,
                RelativeSizeAxes = Axes.Both,
            };
        }

        protected override bool OnMouseDown(MouseDownEvent e)
        {
            icon.ScaleTo(0.5f, 1000, Easing.OutQuint);
            return base.OnMouseDown(e);
        }

        protected override bool OnMouseUp(MouseUpEvent e)
        {
            icon.ScaleTo(0.75f, 1000, Easing.OutElastic);
            return base.OnMouseUp(e);
        }

        protected override bool OnHover(HoverEvent e)
        {
            icon.FadeColour(Color4.Red, 200, Easing.OutQuint);
            return base.OnHover(e);
        }

        protected override void OnHoverLost(HoverLostEvent e)
        {
            icon.FadeColour(Color4.White, 200, Easing.OutQuint);
            base.OnHoverLost(e);
        }
    }
}
