using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    class Program
    {
        static List<Member> members = new List<Member>
        {
            new Member
            {
                FName = "A",
                LName = "Nguyen Van",
                Gender = "Male",
                DoB = new DateTime(2000,11,11),
                PhoneNumber = "0123456789",
                BirthPlace = "Ha Noi",
                isGraduated = false
            },
            new Member
            {
                FName = "B",
                LName = "Nguyen Van",
                Gender = "Male",
                DoB = new DateTime(1999,10,5),
                PhoneNumber = "0123456789",
                BirthPlace = "HCM",
                isGraduated = false
            },
            new Member
            {
                FName = "C",
                LName = "Nguyen Thi",
                Gender = "Female",
                DoB = new DateTime(2001,8,8),
                PhoneNumber = "0123456789",
                BirthPlace = "Ha Noi",
                isGraduated = false
            },
            new Member
            {
                FName = "D",
                LName = "Nguyen Van",
                Gender = "Male",
                DoB = new DateTime(2000,7,7),
                PhoneNumber = "0123456789",
                BirthPlace = "Hai Phong",
                isGraduated = false
            },
            new Member
            {
                FName = "E",
                LName = "Nguyen Thi",
                Gender = "Female",
                DoB = new DateTime(1997,4,3),
                PhoneNumber = "0123456789",
                BirthPlace = "Ha Noi",
                isGraduated = false
            }
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Cau 1:");
            var maleMember = GenderMember();
            PrintData(maleMember);

            Console.WriteLine("Cau 2:");
            var oldest = OldestMember();
            PrintData(new List<Member> {oldest});

            Console.WriteLine("Cau 3:");
            var fullNames = FullName();
            foreach(var fullName in fullNames)
            {
                Console.WriteLine(fullName);
            }

            Console.WriteLine("Cau 4:");
            Console.WriteLine("Sinh truoc 2000:");
            var before2000 = Before2000();
            PrintData(before2000);
            Console.WriteLine("Sinh nam 2000:");
            var in2000 = In2000();
            PrintData(in2000);
            Console.WriteLine("Sinh sau 2000:");
            var after2000 = After2000();
            PrintData(after2000);
            
            Console.WriteLine("Cau 5:");
            var placeOfBirth = PlaceOfBirth();
            PrintData(placeOfBirth);
        }
        static void PrintData(List<Member> data)
        {
            foreach (var item in data)
            {
                Console.WriteLine($"{item.LName} {item.FName} - {item.DoB.ToString("dd/MM/yyyy")} - [{item.Age}] ");
            }
        }
        static List<Member> GenderMember()
        {
            var result = new List<Member>();
            foreach (var member in members)
            {
                if(member.Gender == "Male")
                {
                    result.Add(member);               
                }
            }
            return result;
        }
        static Member OldestMember()
        {
            var maxAge = members[0].Age;
            var maxAgeIndex = 0;
            for (var i = 1; i < members.Count; i++)
            {
                var member = members[i];
                if(member.Age > maxAge)
                {
                    maxAge = member.Age;
                    maxAgeIndex = i;
                }
            }
            return members[maxAgeIndex];
        }

        static List<string> FullName()
        {
            var result = new List<string>();
            foreach (var member in members)
            {
                result.Add($"{member.LName} {member.FName}");
            }
            return result;
        }

        static List<Member> Before2000()
        {
            var result = new List<Member>();
            foreach (var member in members)
            {
                var birthYear = member.DoB.Year;
                if( birthYear < 2000)
                {
                    result.Add(member);               
                }
            }
            return result;
        }
        static List<Member> In2000()
        {
            var result = new List<Member>();
            foreach (var member in members)
            {
                var birthYear = member.DoB.Year;
                if( birthYear == 2000)
                {
                    result.Add(member);               
                }
            }
            return result;
        }
        static List<Member> After2000()
        {
            var result = new List<Member>();
            foreach (var member in members)
            {
                var birthYear = member.DoB.Year;
                if( birthYear > 2000)
                {
                    result.Add(member);               
                }
            }
            return result;
        }

        static List<Member> PlaceOfBirth()
        {
            var result = new List<Member>();
            foreach (var member in members)
            {
                if(member.BirthPlace == "Ha Noi")
                {
                    result.Add(member);
                }
            }
            return result;
        }
    }
}
