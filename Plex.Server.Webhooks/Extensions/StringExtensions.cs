using System;
using Plex.Server.Webhooks.Events;

namespace Plex.Server.Webhooks.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Get the <see cref="EventType"/>.
        /// </summary>
        /// <param name="enumString">The input string</param>
        /// <returns>The <see cref="EventType"/></returns>
        internal static EventType? GetEventType(this string enumString)
        {
            try
            {
                var result = Enum.Parse<EventType>(enumString.Replace(".", ""), true);
                return result;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
