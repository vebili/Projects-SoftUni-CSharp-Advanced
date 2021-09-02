using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    class DateModifier
    {
        private DateTime date1;
        private DateTime date2;

        public DateTime Date1
        {
            get => this.date1;
            set => this.date1 = value;
        }
        public DateTime Date2
        {
            get => this.date2;
            set => this.date2 = value;
        }

        public int GetDaysDifference()
        {
            int difference = Math.Abs((this.date1 - this.date2).Days);

            return difference;
        }
    }
}
