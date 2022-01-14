using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> memberList = new List<Member>();
            List<String> fullNameList = new List<String>();
            List<Member> maleMemberList = new List<Member>();
            List<Member> greaterThan2000MemberList = new List<Member>();
            List<Member> lessThan2000MemberList = new List<Member>();
            List<Member> bornIn2000MemberList = new List<Member>();
            List<Member> bornInHaNoiMemberList = new List<Member>();
            memberList.Add(new Member("Pham", "Long", "Male", "0944531628", "Nam Dinh", "2000/03/21", true));
            memberList.Add(new Member("Tran", "Hung", "Male", "0944531628", "Nam Dinh", "2002/03/21", false));
            memberList.Add(new Member("Vu", "Long", "Male", "0944531628", "Ninh Binh", "1999/03/21", true));
            memberList.Add(new Member("Pham", "Hong", "Female", "0944531628", "Ha Noi", "2004/03/21", false));
            memberList.Add(new Member("Vu", "Lan", "Female", "0944531628", "Nam Dinh", "2001/03/21", false));
            memberList.Add(new Member("Tran", "Hang", "Female", "0944531628", "DakLak", "1999/03/21", false));

            int ageMax = 0;

            foreach (Member m in memberList)
            {
                fullNameList.Add(m.FullName);

                if (m.Gender == "Male")
                {
                    maleMemberList.Add(m);
                };

                switch (m.DateOfBirth.Year)
                {

                    case < 2000:

                        lessThan2000MemberList.Add(m);

                        break;

                    case > 2000:

                        greaterThan2000MemberList.Add(m);

                        break;

                    default:

                        bornIn2000MemberList.Add(m);

                        break;
                }

                if (ageMax < m.Age)
                {
                    ageMax = m.Age;
                }
            }

            Console.WriteLine("Member List:");
            foreach (Member m in memberList)
            {
                Console.WriteLine(m.ShowMember);
            }
            Console.WriteLine();

            Console.WriteLine("FullName List:");
            foreach (String m in fullNameList)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            Console.WriteLine("The Oldest:");
            foreach (Member m in memberList)
            {
                if (m.Age == ageMax)
                {
                    Console.WriteLine(m.ShowMember);
                    break;
                }
            }
            Console.WriteLine();

            Console.WriteLine("Male Member List:");
            foreach (Member m in maleMemberList)
            {
                Console.WriteLine(m.ShowMember);
            }
            Console.WriteLine();

            Console.WriteLine("Less Than 2000 Member List:");
            foreach (Member m in lessThan2000MemberList)
            {
                Console.WriteLine(m.ShowMember);
            }
            Console.WriteLine();

            Console.WriteLine("2000 Member List:");
            foreach (Member m in bornIn2000MemberList)
            {
                Console.WriteLine(m.ShowMember);
            }
            Console.WriteLine();

            Console.WriteLine("Greater Than 2000 Member List:");
            foreach (Member m in greaterThan2000MemberList)
            {
                Console.WriteLine(m.ShowMember);
            }
            Console.WriteLine();

            Console.WriteLine("First person was born in Ha Noi:");
            int i = 0;
            while (memberList[i].BirthPlace != "Ha Noi")
            {
                if (i >= memberList.Count() - 1)
                {
                    i = -1;
                }
                else
                {
                    i++;
                }
            }
            if (i == -1)
            {
                Console.WriteLine("No person who was born in Ha Noi");
            }
            else
            {
                Console.WriteLine(memberList[i].ShowMember);
            }
        }
    }
}