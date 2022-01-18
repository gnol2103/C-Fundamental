using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_.Enum;

namespace C_.Untils
{
    public class MemberUntil
    {
        public List<Member> Members;
        public MemberUntil() {
            Members=InitMembers();
         }
        private List<Member> InitMembers()
        {
            List<Member> memberList = new List<Member>();
            memberList.Add(new Member("Pham", "Long", Gender.Male, "0944531628", "Nam Dinh", "2000/03/21", true));
            memberList.Add(new Member("Tran", "Hung", Gender.Female, "0944531628", "Nam Dinh", "2002/03/21", false));
            memberList.Add(new Member("Vu", "Long", Gender.Male, "0944531628", "Ninh Binh", "1999/03/21", true));
            memberList.Add(new Member("Pham", "Hong", Gender.Other, "0944531628", "Ha Noi", "2004/03/21", false));
            memberList.Add(new Member("Vu", "Lan", Gender.Male, "0944531628", "Nam Dinh", "2001/03/21", false));
            memberList.Add(new Member("Tran", "Hang", Gender.Male, "0944531628", "DakLak", "1999/03/21", false));
            return memberList;
        }

        public string OldestMember(List<Member> members){
            int maxAge= members.Max(m=>m.Age);
            return members.Where(m => m.Age==maxAge).FirstOrDefault().MemberInfo;
        }
        public string HNMember(List<Member> members){
            try{
                return members.Find(m=>m.BirthPlace=="Ha Noi").MemberInfo;
            }
            catch{
                return "There is no member whose birthplace is 'Ha Noi'";
            }
        }
    }
}