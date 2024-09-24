namespace SchoolClassManagment.Models.Entities
{
    public class SchoolClass
    {
        // fields: ezeket az adatokat védjük, kivülről csak engedélyezettel érjük el
        private byte _grade;
        private char _gradeLetter;
        private byte _lastGrade;

        // konstruktor
        public SchoolClass()
        {
            _grade = byte.MinValue;
            _gradeLetter = char.MinValue;
        }
        public SchoolClass(byte grade, char gradeLetter)
        {
            _grade = grade;
            _gradeLetter = gradeLetter;
        }

        // property
        public byte Grade { get => _grade; set => _grade = value; }
        public char GradeLetter { get => _gradeLetter; set => _gradeLetter = value; }

        public override string ToString()
        {
            return $"{_grade}.{_gradeLetter}";
        }

    }
}
