namespace GradeBookApp
{
    public class GradeBook
    {
        private string _name; // common practive to denote private var with _ in front

        public GradeBook(string name) // constructor
        {
            _name = name;
        }

        public string Name
        {
            // getter
            get { return _name; }
            // setter
            set { _name = value; }
        }
    }
}