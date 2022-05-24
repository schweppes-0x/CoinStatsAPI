namespace CoinStatsAPI
{
    public static class PropertyExtensions
    {
        public static string AppendProperty(this string url, Property property, bool first = false)
        {
            return first ? $"{url}?{property.Name}={property.Value}" : $"&{property.Name}={property.Value}";
        }
    }
}