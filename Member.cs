using System;
using System.Collections.Generic;

namespace BaiTap
{
    public class Member
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime DoB { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age
        {
            get
            {
                return DateTime.Now.Year - DoB.Year;
            }
        }
        public bool isGraduated { get; set; }
        public string Gender { get; set; }
    }
}
