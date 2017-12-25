using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MvvmLight.Practice.Utility.ValidationRule
{
    public class EmailRule : System.Windows.Controls.ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Regex emailReg = new Regex("^\\s*([A-Za-z0-9_-]+(\\.\\w+)*@(\\w+\\.)+\\w{2,5})\\s*$");

            if (!String.IsNullOrEmpty(value.ToString()))
            {
                if (!emailReg.IsMatch(value.ToString()))
                {
                    return new ValidationResult(false, "邮箱地址不准确！");
                }
            }
            return new ValidationResult(true, null);
        }
    }
}
