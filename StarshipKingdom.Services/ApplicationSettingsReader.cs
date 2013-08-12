using System.Configuration;

namespace StarshipKingdom.Services
{
    public interface IApplicationSettingsReader
    {
        string Get(string key);

        string GetConnectionString();
    }

    public class ApplicationSettingsReader : IApplicationSettingsReader
    {
        public string Get(string key)
        {
            try
            {
                var value = ConfigurationManager.AppSettings[key];

                return value;
            }
            catch
            {
                return null;
            }
        }

        public string GetConnectionString()
        {
            return @"Data Source=.;Initial Catalog=starshipkingdom;Integrated Security=SSPI;";
            //return ConfigurationManager.ConnectionStrings[0].ToString();
        }
    }
}
