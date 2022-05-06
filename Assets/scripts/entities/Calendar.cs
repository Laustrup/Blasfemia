using tools;
using tools;

/* The Calendar determine the turn of the game, referenced to the specific community's turn.
 * 
 * Other calendars are referred to as B.O.C. (Before Our Calendar).
 *
 * The calendar sections are meant as for example year/month/day or b'aktuns.
 *
 * Some Religions can have curtain rules about each sections.
 */

namespace entities
{
    // Author Laust Eberhardt Bonnesen
    public class Calendar {
        
        private string _title; public string Title { get { return _title;} set { _title = value;} }
        
        private int _indexSection { get; set; } public int IndexSection {get{return _indexSection;}}
        
        private Liszt<CalendarSection> _sections {get;} public Liszt<CalendarSection> Sections { get { return _sections;} }
        
        private LeapValue _leapValue { get; } private bool isLeapValue { get; }
        
        public Calendar(string title, Liszt<CalendarSection> sections) 
        { 
            _title = title;
            _sections = sections;
            
        }

        public void Next() 
        {
            for (int i = _sections.Size; i > 0;i--) 
            {
                if (_sections.Get(i).Value!=_sections.Get(i).AllowedLength) {
                    _sections.Get(i).Increment_Value();
                    break;
                }
            }
        } 
        
        public Liszt<CalendarSection> Add_Section(CalendarSection section) {_sections.Add(section);return _sections;}

        public class CalendarSection 
        {
            
            private string _title {get; set; } public string Title { get { return _title;} set { _title = value;} }

            private int _value {get; set; } public int Value {get{return _value;}set{_value=value;}}
                
            private int _allowedLength { get; } public int AllowedLength {get{return _allowedLength;}}

            
            public CalendarSection(string title, int value, int allowedLength, LeapValue leapValue) 
            {
                _title = title;
                _value = value;
                _allowedLength = allowedLength;
            }

            public int Increment_Value() 
            {
                if (_value!=_allowedLength) {_value++;}
                return _value;
            }
        }

        public class LeapValue
        {
            private int _value { get; } public int Value {get{return _value;}}
            private int _occurance { get; } public int Occurance {get{return _occurance;}}

            public LeapValue(int value, int occurance)
            {
                _value = value;
                _occurance = occurance;
            }
            
        }
    }
}

