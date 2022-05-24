using System.Collections.Generic;
using System.Linq;

namespace CoinStatsAPI
{
    public class Request
    {
        public string BaseUrl;
        public string EndPoint;
        public List<Property> Properties = new List<Property>();
        public string FinalUrl
        {
            get
            {
                var finalUrl = $"{BaseUrl}{EndPoint}";

                if(Properties.Any())
                    for (int i = 0; i < Properties.Count; i++)
                    {
                        var property = Properties[i];
                
                        if(i == 0)
                            finalUrl = finalUrl.AppendProperty(property, true);
                        else 
                            finalUrl += finalUrl.AppendProperty(property);
                    }
                
                return finalUrl;
            }
        }

        public Request(string baseUrl, string endpoint)
        {
            BaseUrl = baseUrl;
            EndPoint = endpoint;
        }

        public void AddProperty(Property property)
        {
            Properties.Add(property);
        }

        public void AddProperty(string propertyName, object value)
        {
            var property = new Property()
            {
                Name = propertyName,
                Value = value
            };
            
            AddProperty(property);
        }
    }
}