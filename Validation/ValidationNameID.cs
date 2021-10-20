using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;


namespace Prj_PracticeMidterm.Validation
{
    public class ValidationNameID
    {
        public static bool IsValidId(string id)
        {
            if (!Regex.IsMatch(id, @"^[0-9]*$"))
            {
                return false;
            }

            return true;
        }

    }
}