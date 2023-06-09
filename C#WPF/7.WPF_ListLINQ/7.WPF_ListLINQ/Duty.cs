﻿
using System;
using System.Collections.ObjectModel;

namespace _7.WPF_ListLINQ
{
    public enum DutyType
    {
        Inner,
        Outside
    }

    public class Duty
    {
        private string _name;       // 직무명
        private DutyType _dutyType; // 직무타입, 내근, 외근

        public Duty(String name, DutyType dutyType)
        {
            _name = name;
            _dutyType = dutyType;
        }
        
        public string DutyName
        { 
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public DutyType DutyType
        {
            get { return _dutyType; }
            set
            {
                _dutyType = value;
            }
        }
    }

    public class Duties : ObservableCollection<Duty>
    {
        public Duties()
        {
            Add(new Duty("SALES", DutyType.Outside));
            Add(new Duty("LOGISTICS", DutyType.Outside));
            Add(new Duty("IT", DutyType.Inner));
            Add(new Duty("MARKETING", DutyType.Inner));
            Add(new Duty("HR", DutyType.Inner));
            Add(new Duty("PROPOTION", DutyType.Outside));
        }
    }
}
