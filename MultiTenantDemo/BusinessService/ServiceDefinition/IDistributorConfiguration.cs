
using System.Globalization;
using Me.Sample.Web.Model;
namespace Me.Sample.Web.Service.Definition
{
    public interface IDistributorConfiguration
    {
        string GetCSSPath(string distributor);

        string GetScriptPath(string distributor);

        string GetImagePath(string distributor);

        void LoadResourceFile(CultureInfo culture);

        string GetI18NCaption(string captionName, CultureInfo culture);

        string GetI18NMessage(string messageName, CultureInfo culture);

        UIOption GetUIOption(string distributor, enmUIOption option);
    }
}
