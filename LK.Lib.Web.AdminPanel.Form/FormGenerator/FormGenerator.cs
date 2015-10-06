using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LK.Lib.Web.AdminPanel.Form.Attributes;

namespace LK.Lib.Web.AdminPanel.Form.FormGenerator
{
    public class FormGenerator
    {
        public string GenerateForm()
        {
            StringBuilder formBuilder = new StringBuilder();

            var classInfo = this.GetType();

            foreach (var propertyInfo in classInfo.GetProperties())
            {
                foreach (var attr in propertyInfo.GetCustomAttributes(true))
                {
                    var formGeneratorAttr = attr as IAdminFormAttribute;

                    if (formGeneratorAttr == null)
                    {
                        continue;
                    }

                    var val = propertyInfo.GetValue(this, null) ?? "";

                    formBuilder.AppendLine( formGeneratorAttr.GenerateHtml(propertyInfo.Name, val.ToString()));
                }
            }

            return formBuilder.ToString();
        }
    }
}
