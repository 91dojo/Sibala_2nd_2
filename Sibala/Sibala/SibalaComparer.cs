﻿using System.Collections.Generic;

namespace Sibala
{
    public class SibalaComparer : Comparer<SibalaGame>
    {
        public override int Compare(SibalaGame x, SibalaGame y)
        {
            if (IsSameType(x, y))
            {
                if (x.Type == SibalaType.NormalPoint && x.Points == y.Points)
                {
                    return x.MaxPoint - y.MaxPoint;
                }

                if (x.Type == SibalaType.NormalPoint)
                {
                    return x.Points - y.Points;
                }

                if (x.Type == SibalaType.OneColor)
                {
                    List<int> diceOrder = new List<int>() { 2, 3, 5, 6, 4, 1 };
                    return diceOrder.IndexOf(x.Points) - diceOrder.IndexOf(y.Points);
                }
            }

            return x.Type - y.Type;
        }

        private static bool IsSameType(SibalaGame x, SibalaGame y)
        {
            return x.Type == y.Type;
        }
    }
}