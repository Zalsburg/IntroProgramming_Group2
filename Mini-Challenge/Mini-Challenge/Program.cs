using System;
using System.Collections.Generic;

namespace Mini_Challenge {
    class Program {
        static void Main(string[] args) {

            List<Student> Students = new List<Student>();
            List<Teacher> Teachers = new List<Teacher>();
            List<Admin> Admins = new List<Admin>();

            string input = "";
            while (input != "5") {
                Console.WriteLine("Welcome-");
                Console.WriteLine("1. Create Student");
                Console.WriteLine("2. Create Teacher");
                Console.WriteLine("3. Create Admin");
                Console.WriteLine("4. View People");
                Console.WriteLine("5. Exit");
                Console.WriteLine();
                Console.Write("Selection: ");

                input = Console.ReadLine();

                try {
                    int select = int.Parse(input);
                    if (select > 5 || select < 1) {
                        throw new OutOfBoundsException("Please input valid option");
                    }
                }
                catch (OutOfBoundsException e) {
                    Console.WriteLine("Error: " + e.Message);
                }
                catch (FormatException e) {
                    Console.WriteLine("Error: " + e.Message);
                }
                finally {
                    Console.WriteLine();
                }

                if (input == "1") {
                    Console.WriteLine("Create Student-");
                    Console.Write("Enter First Name: ");
                    string FName = Console.ReadLine();
                    Console.Write("Enter Surname: ");
                    string SName = Console.ReadLine();

                    int YearOfBirth = 0;
                    while (YearOfBirth == 0 || YearOfBirth < 1900 || YearOfBirth > 2018) {
                        try {
                            Console.Write("Enter Year of Birth: ");
                            YearOfBirth = int.Parse(Console.ReadLine());

                            if(YearOfBirth < 1900 || YearOfBirth > 2018) {
                                throw new WeirdAgeException("Please enter a valid year");
                            }
                        }
                        catch (FormatException e) {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        catch(WeirdAgeException e) {
                            Console.WriteLine("Error: " + e.Message);
                        }
                    }

                    int Id = 0;
                    while (Id <= 0) {
                        try {
                            Console.Write("Enter Id: ");
                            Id = int.Parse(Console.ReadLine());
                            if(Id <= 0) {
                                throw new NegativeNoException("Please enter a valid number");
                            }
                        }
                        catch(FormatException e) {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        catch(NegativeNoException e) {
                            Console.WriteLine("Error: " + e.Message);
                        }
                    }

                    Student newStudent = new Student(FName, SName, YearOfBirth, Id);
                    Students.Add(newStudent);
                    Console.WriteLine();
                    Console.WriteLine("Student Created");
                    Console.WriteLine();
                }
                else if (input == "2") {
                    Console.WriteLine("Create Teacher-");
                    Console.Write("Enter First Name: ");
                    string FName = Console.ReadLine();
                    Console.Write("Enter Surname: ");
                    string SName = Console.ReadLine();

                    int YearOfBirth = 0;
                    while (YearOfBirth == 0 || YearOfBirth < 1900 || YearOfBirth > 2018) {
                        try {
                            Console.Write("Enter Year of Birth: ");
                            YearOfBirth = int.Parse(Console.ReadLine());

                            if (YearOfBirth < 1900 || YearOfBirth > 2018) {
                                throw new WeirdAgeException("Please enter a valid year");
                            }
                        }
                        catch (FormatException e) {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        catch (WeirdAgeException e) {
                            Console.WriteLine("Error: " + e.Message);
                        }
                    }

                    Console.Write("Enter Username: ");
                    string Username = Console.ReadLine();
                    Console.Write("Enter Expertise: ");
                    string Expertise = Console.ReadLine();

                    Teacher newTeacher = new Teacher(FName, SName, YearOfBirth, Username, Expertise);
                    Teachers.Add(newTeacher);
                    Console.WriteLine();
                    Console.WriteLine("Teacher Created");
                    Console.WriteLine();
                    
                }
                else if(input == "3") {
                    Console.WriteLine("Create Admin-");
                    Console.Write("Enter First Name: ");
                    string FName = Console.ReadLine();
                    Console.Write("Enter Surname: ");
                    string SName = Console.ReadLine();

                    int YearOfBirth = 0;
                    while (YearOfBirth == 0 || YearOfBirth < 1900 || YearOfBirth > 2018) {
                        try {
                            Console.Write("Enter Year of Birth: ");
                            YearOfBirth = int.Parse(Console.ReadLine());

                            if (YearOfBirth < 1900 || YearOfBirth > 2018) {
                                throw new WeirdAgeException("Please enter a valid year");
                            }
                        }
                        catch (FormatException e) {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        catch (WeirdAgeException e) {
                            Console.WriteLine("Error: " + e.Message);
                        }
                    }

                    Console.Write("Enter Username: ");
                    string Username = Console.ReadLine();

                    int OfficeNo = 0;
                    while (OfficeNo <= 0) {
                        try {
                            Console.Write("Enter Office Number: ");
                            OfficeNo = int.Parse(Console.ReadLine());

                            if(OfficeNo <= 0) {
                                throw new NegativeNoException("Please enter a valid number");
                            }
                        }
                        catch(FormatException e) {
                            Console.WriteLine("Error: " + e.Message);
                        }
                        catch(NegativeNoException e) {
                            Console.WriteLine("Error: " + e.Message);
                        }
                    }

                    Admin newAdmin = new Admin(FName, SName, YearOfBirth, Username, OfficeNo);
                    Admins.Add(newAdmin);
                    Console.WriteLine();
                    Console.WriteLine("Admin Created");
                    Console.WriteLine();
                }
            }
        }
    }

    public class NegativeNoException : Exception {
        public NegativeNoException(string message) : base(message) {
        }
    }

    public class OutOfBoundsException : Exception {
        public OutOfBoundsException(string message) : base(message) {
        }
    }

    public class WeirdAgeException : Exception {
        public WeirdAgeException(string message) : base(message) {
        }
    }

    public class Person {
        public string FName;
        public string SName;
        public int YearOfBirth;

        public Person(string f, string s, int dob) {
            FName = f;
            SName = s;
            YearOfBirth = dob;
        }

        public string GetName() {
            return $"First Name: {FName}, Last Name: {SName}";
        }

        public int GetAge() {
            Console.Write("Age: ");
            return 2019 - YearOfBirth;
        }
    }

    public class Student : Person {
        public int Id;

        public Student(string f, string s, int dob, int id) : base(f, s, dob) {
            Id = id;
        }

        public string GetInfo() {
            return $"Name: {FName}, Last Name: {SName}, Year of Birth: {YearOfBirth}, Id: {Id}";
        }
    }

    public class Staff : Person {
        public string Username;

        public Staff(string f, string s, int dob, string user) : base(f, s, dob) {
            Username = user;
        }

        public string GetInfo() {
            return $"Name: {FName}, Last Name: {SName}, Year of Birth: {YearOfBirth}, Username: {Username}";
        }
    }

    public class Teacher : Staff {
        public string Expertise;

        public Teacher(string f, string s, int dob, string user, string expert) : base(f, s, dob, user) {
            Expertise = expert;
        }

        public new string GetInfo() {
            return $"Name: {FName}, Last Name: {SName}, Year of Birth: {YearOfBirth}, Username: {Username}, Expertise: {Expertise}";
        }
    }

    public class Admin : Staff {
        public int OfficeNo;

        public Admin(string f, string s, int dob, string user, int offno) : base(f, s, dob, user) {
            OfficeNo = offno;
        }

        public new string GetInfo() {
            return $"Name: {FName}, Last Name: {SName}, Year of Birth: {YearOfBirth}, Username: {Username}, Office Number: {OfficeNo}"; 
        }
    }
}
