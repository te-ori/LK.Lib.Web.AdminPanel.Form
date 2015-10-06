using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK.Localization.String
{
    public class LocalizableStr: ILocalizable
    {
        public Dictionary<string, string> LangValuePairs { get; set; }

        public string GetValue() => GetValue(GetCurrentThreadLanguage());

        private bool CheckIsValueExist(string language)
        {
            if (LangValuePairs == null || !LangValuePairs.Any())
            {
                throw new ArgumentNullException("Language value container is null");
            }

            if (!LangValuePairs.ContainsKey(language))
            {
                throw new ArgumentNullException(string.Format("There is not value for {0}", language));
            }

            return true;
        }

        public string GetValue(string language)
        {
            if (!CheckIsValueExist(language))
            {
                return "";
            }

            string value = LangValuePairs[language];

            return value;
        }

        public string SetValue(string value) => SetValue(GetCurrentThreadLanguage(), value);

        public string SetValue(string language, string value)
        {
            if (LangValuePairs == null)
            {
                throw new ArgumentNullException("KeyValue container is not initialized.");
            }
            LangValuePairs[language] = value;

            return value;
        }

        private string GetCurrentThreadLanguage()
        {
            string langCode = System.Threading.Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;

            return langCode;
        }
    }

}
