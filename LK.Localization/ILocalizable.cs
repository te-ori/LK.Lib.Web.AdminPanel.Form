using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK.Localization
{
    public interface ILocalizable
    {
        Dictionary<string, string> LangValuePairs { get; set; }

        string GetValue();
        string GetValue(string language);

        string SetValue(string language);
        string SetValue(string language, string value);

    }
}
