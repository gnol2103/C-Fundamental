using System;
using System.Collections.Generic;
using System.Linq;
using C_.Enum;
using C_.Untils;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberUntil memberUntil = new MemberUntil();
            var femaleMembers = memberUntil.Members.Where(m => m.Gender == Gender.Female);
            var maleMembers = memberUntil.Members.Where(m => m.Gender == Gender.Male);
            var otherMembers = memberUntil.Members.Where(m => m.Gender == Gender.Other);

            Console.WriteLine("Female list");
            foreach (Member m in femaleMembers)
            {
                Console.WriteLine(m.MemberInfo);
            }

            Console.WriteLine("Male list");
            foreach (Member m in maleMembers)
            {
                Console.WriteLine(m.MemberInfo);
            }

            Console.WriteLine("Other list");
            foreach (Member m in femaleMembers)
            {
                Console.WriteLine(m.MemberInfo);
            }

            Console.WriteLine("Oldest Member:");
            Console.WriteLine(memberUntil.OldestMember(memberUntil.Members));

            Console.WriteLine("List of less than 2000:");
            memberUntil.Members.Where(m => m.DateOfBirth.Year < 2000).Select(x => x.MemberInfo).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("List of greater than 2000:");
            memberUntil.Members.Where(m => m.DateOfBirth.Year > 2000).Select(x => x.MemberInfo).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine("List of 2000:");
            memberUntil.Members.Where(m => m.DateOfBirth.Year == 2000).Select(x => x.MemberInfo).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Ha Noi Member:");
            Console.WriteLine(memberUntil.HNMember(memberUntil.Members));
        }
    }
}