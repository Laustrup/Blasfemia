using System.Collections.Generic;

namespace entities;

public class Calendar {

    private string _title; public string Title { get { return _title;} set { _title = value;} }
    
    private int _indexSection { get; set; } public int IndexSection {get{return _indexSection;}}
    
    private List<CalendarSection> _sections {get;} public List<CalendarSection> Sections { get { return _sections;} }
    
    private LeapValue _leapValue { get; } private bool isLeapValue { get; }
    
    public Calendar(string title, List<CalendarSection> sections) { _title = title; _sections = sections; }

    public void Next() {
        for (int i = _sections.Count; i > 0;i--) {
            if (_sections[i].Value!=_sections[i].AllowedLength) {
                _sections[i].Increment_Value();
                break;
            }
        }
    } 
    
    public List<CalendarSection> Add_Section(CalendarSection section) {_sections.Add(section);return _sections;}

    public class CalendarSection {
        
        private string _title {get; set; } public string Title { get { return _title;} set { _title = value;} }

        private int _value {get; set; } public int Value {get{return _value;}set{_value=value;}}
            
        private int _allowedLength { get; } public int AllowedLength {get{return _allowedLength;}}

        
        public CalendarSection(string title, int value, int allowedLength, LeapValue leapValue) {
            _title = title;
            _value = value;
            _allowedLength = allowedLength;
        }

        public int Increment_Value() {
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
