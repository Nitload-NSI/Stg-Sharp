﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StgSharp.Math
{
    public static partial class GeometryScaler
    {
        internal const float DegToRad = 180 / Scaler.Pi;

        public static Degree ToDegree(float value)
        {
            return new Degree(value);
        }

        public static float Sin(Radius r)
        {
            return MathF.Sin(r._radius);
        }

        public static float Tan(Radius r)
        {
            return MathF.Tan(r._radius);
        }
        public static float Cos(Radius r)
        {
            return MathF.Cos(r._radius);
        }

        public static float Sin(Degree r)
        {
            return MathF.Sin(r._degree);
        }

        public static float Tan(Degree r)
        {
            return MathF.Tan(r._degree);
        }

        public static float Cos(Degree r)
        {
            return MathF.Cos(r._degree);
        }

    }

    public struct Degree
    {
        internal float _degree;

        internal Degree(float dgree) 
        {
            _degree = dgree;
        }

        public Radius ToRadius()
        {
            return new Radius(_degree / GeometryScaler.DegToRad);
        }
    }

    public struct Radius
    {
        internal float _radius;

        public static Radius Zero
        {
            get =>new Radius(0);
        }

        public Radius(float radius) 
        {
            _radius = radius; 
        }

        [Obsolete("Unsafe, you may forget this is radius.",true)]
        public Radius() { }

        public Degree ToDegree()
        {
            return new Degree(_radius * 180 / Scaler.Pi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Radius operator -(Radius r)
        {
            return new Radius(-r._radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Radius operator -(Radius left, Radius Right)
        {
            return new Radius(left._radius - Right._radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Radius operator +(Radius left, Radius Right)
        {
            return new Radius(left._radius + Right._radius);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Radius operator *(Radius left, float right)
        {
            return new Radius(left._radius * right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Radius operator /(Radius left, float right)
        {
            return new Radius(left._radius / right);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator ==(Radius left, Radius right)
        {
            return left._radius == right._radius;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool operator !=(Radius left, Radius right)
        {
            return left._radius != right._radius;
        }

    }
}
