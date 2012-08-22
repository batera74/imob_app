using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace imob_app.business
{
    public static class ExtensionMethods
    {
        public static MySql.Data.Types.MySqlDateTime ToMySqlDateTime(this DateTime date)
        {
            MySql.Data.Types.MySqlDateTime data = new MySql.Data.Types.MySqlDateTime();
            data.Day = date.Day;
            data.Month = date.Month;
            data.Year = date.Year;
            data.Hour = date.Hour;
            data.Minute = date.Minute;
            data.Second = date.Second;
            data.Millisecond = date.Millisecond;

            return data;
        }
    }
}
