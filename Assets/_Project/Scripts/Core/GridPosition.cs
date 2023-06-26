using System;

namespace AlgoSibo.Core
{
    [Serializable]
    public struct GridPosition : IEquatable<GridPosition>
    {
        public int x;
        public int z;

        public GridPosition(int x, int z)
        {
            this.x = x;
            this.z = z;
        }

        public static GridPosition Zero => new GridPosition(0, 0);
        public static GridPosition Up => new GridPosition(0, 1);
        public static GridPosition Down => new GridPosition(0, -1);
        public static GridPosition Left => new GridPosition(-1, 0);
        public static GridPosition Right => new GridPosition(1, 0);

        // ================
        // Override
        // ================
        public override string ToString()
        {
            return $"(x: {x}, z: {z})";
        }

        public static bool operator ==(GridPosition a, GridPosition b)
        {
            return a.x == b.x && a.z == b.z;
        }
        public static bool operator !=(GridPosition a, GridPosition b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return obj is GridPosition position &&
                   x == position.x &&
                   z == position.z;
        }

        public static GridPosition operator +(GridPosition a, GridPosition b)
        {
            return new GridPosition(a.x + b.x, a.z + b.z);
        }

        public static GridPosition operator -(GridPosition a, GridPosition b)
        {
            return new GridPosition(a.x - b.x, a.z - b.z);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(x, z);
        }

        public bool Equals(GridPosition other)
        {
            return this == other;
        }
    }
}