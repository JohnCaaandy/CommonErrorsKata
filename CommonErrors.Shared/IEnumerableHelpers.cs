using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonErrors.Shared
{
    public static class EnumerableHelpers
    {
        /// <summary>
        /// Gets a random element out of the collection
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <returns></returns>
        public static T GetRandom<T>(this IEnumerable<T> collection)
        {
            var enumerable = collection as T[] ?? collection.ToArray();
            if (!enumerable.Any()) return default(T);
            var rand = new Random(DateTime.Now.Millisecond);
            var index = rand.Next(enumerable.Count());
            return enumerable.ToArray()[index];
        }
    }
}
