﻿using Microsoft.Xna.Framework;

namespace MonoGame.Additions
{
    public interface ITransform2D
    {
        Vector2 Position { get; }
        Vector2 Scalation { get; }
        float Rotation { get; }
    }
}