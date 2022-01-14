using System;
namespace C_
{
    internal class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public int Age { get { return DateTime.Now.Year - this.DateOfBirth.Year; } }
        public DateTime DateOfBirth { get; set; }
        public bool IsGraduated { get; set; }
        public Member(string fN, string lN, string g, string pN, string bP, string dOB, bool iG)
        {
            this.FirstName = fN;
            this.LastName = lN;
            this.Gender = g;
            this.PhoneNumber = pN;
            this.BirthPlace = bP;
            this.DateOfBirth = Convert.ToDateTime(dOB);
            DateTime dateTimeNow = DateTime.Today;
            this.IsGraduated = iG;
        }
        public string ShowMember
        {
            get
            {
                string member = string.Concat("FirstName: ",this.FirstName, " |LastName: ",this.LastName, " |Gender: ",this.Gender, " |DateOfBirth: ",this.DateOfBirth, " |PhoneNumber: ",this.PhoneNumber, " |BirthPlace: ",this.BirthPlace, " |Age: ",this.Age, " |IsGraduated: ",this.IsGraduated);
                return member;
            }
        }
        public string FullName
        {
            get
            {
                string fullName = string.Concat(this.FirstName, " ", this.LastName);
                return fullName;
            }
        }
    }
}