using System;

namespace StudProject
{
    public static class ExtEnum
    {
        public static int ToInt(this Enum input)
        {
            return input.GetHashCode();
        }

    }
}
