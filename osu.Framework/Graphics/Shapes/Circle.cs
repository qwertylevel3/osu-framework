﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using osu.Framework.Graphics.Colour;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Sprites;

namespace osu.Framework.Graphics.Shapes
{
    public class Circle : CircularContainer
    {
        private readonly Box fill;

        public Circle()
        {
            Masking = true;

            AddInternal(fill = new Box()
            {
                RelativeSizeAxes = Axes.Both,
            });
        }
    }
}
