using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LK.Lib.Web.AdminPanel.Form.Attributes;
using LK.Lib.Web.AdminPanel.Form.HtmlGenerator.Inputs;

namespace LK.Lib.Web.AdminPanel.Form.HtmlGenerator
{
    public class HtmlGenerator: IHtmlGenerator
    {
        private Dictionary<InputType, IInput> inputList;

        public HtmlGenerator()
        {
            inputList = new Dictionary<InputType, IInput>();

            inputList.Add(InputType.TextBox, new TextBox());
            inputList.Add(InputType.DropDown, new Dropdown());
        }

        public string GenerateHtml(InputType inputType, string label, string name, string value = null,
            List<string> options = null)
        {
            string result = inputList[inputType].GenerateHtml(label, name, value, options);

            return result;
        }
    }
}
