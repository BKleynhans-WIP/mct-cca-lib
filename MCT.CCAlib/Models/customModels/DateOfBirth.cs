using MCT.CCAlib.Interfaces.customModels;

namespace MCT.CCAlib.Models.customModels
{
    public class DateOfBirth : IDateOfBirth
    {
        private short day;
        private short month;
        private short year;
        private string dateOfBirth;

        public short Day
        {
            get { return day; }
            set
            {
                day = value;
                SetDateOfBirth();
            }
        }

        public short Month
        {
            get { return month; }
            set
            {
                month = value;
                SetDateOfBirth();
            }
        }

        public short Year
        {
            get { return year; }
            set
            {
                year = value;
                SetDateOfBirth();
            }
        }

        public string DateOfBirthString { get { return dateOfBirth; } }

        private void SetDateOfBirth()
        {
            dateOfBirth = $"{Month.ToString()}/{Day.ToString()}/{Year.ToString()}";
        }
    }
}
