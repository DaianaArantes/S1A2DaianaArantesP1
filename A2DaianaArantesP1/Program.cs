/*
 * Program ID: S1A2DaianaArantesP1 - Assignment 1 Part 1 
 * 
 * Programming Concepts - 1 Semester
 * 
 * Purpose: Create a C# Console Application project to compute
 * the tuition fee a student should pay.
 * 
 * Revised History
 * 
 * Written Oct 2017 by Daiana Arantes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2DaianaArantesP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarating
            string studentType;
            int studentAge;
            double tuition;
            string monthRegistered;
            string semesterRegistered;
            double internationalStudentFee;
            double feeForSemester;

            //Initialize
            tuition = 0;
            monthRegistered = null;
            semesterRegistered = null;
            internationalStudentFee = 100;
            feeForSemester = 0;

            // Validate if user is a Canadian Citizen or International student
            do
            {
                Console.WriteLine("Are you a Canadian Citizen or an International Student? ");
                studentType = Console.ReadLine();
                Console.WriteLine();

                if (studentType == "International student")
                {
                    studentType = "International Student";
                }
                else if (studentType == "internationalstudent")
                {
                    studentType = "International Student";
                }
                else if (studentType == "international student")
                {
                    studentType = "International Student";
                }
                else if (studentType == "International Student")
                {
                    studentType = "International Student";
                }
                else if (studentType == "Canadian citizen")
                {
                    studentType = "Canadian Citizen";
                }
                else if (studentType == "Canadian Citizen")
                {
                    studentType = "Canadian Citizen";
                }
                else if (studentType == "canadian citizen")
                {
                    studentType = "Canadian Citizen";
                }
                else if (studentType == "canadiancitizen")
                {
                    studentType = "Canadian Citizen";
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input, please type Canadian" +
                    " Citizen or an International student: ");
                    Console.WriteLine();
                }

            } while (studentType != "Canadian Citizen" &&
            studentType != "International Student");

            Console.WriteLine("What is your age?");
            Console.WriteLine();

            do
            {
                //Try.Parse to validate if the input is valid
                if (!int.TryParse(Console.ReadLine(), out studentAge))
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid option, please enter a valid age!");
                    Console.WriteLine();
                }
                //Validate if the age is between 0 and 150 before while
                else if (studentAge <= 0 || studentAge > 150)
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid option, please enter a valid age!");
                    Console.WriteLine();
                }
                //Validate if the age is between 0 and 150
            } while (studentAge <= 0 || studentAge > 150);

            //If the student is an international student, they 
            //must pay an extra $100 before tax is applied
            if (studentType == "International Student")
            {
                tuition = tuition + internationalStudentFee;
            }

            //If the student's age is 18 or below, they must pay $300 + 13% HST
            if (studentAge <= 18)
            {
                tuition = (tuition + 300) * 1.13;
            }
            //If the student is aged 19 to 49, they must pay $500 + 13% HST 
            else if (studentAge >= 19 && studentAge <= 49)
            {
                tuition = (tuition + 500) * 1.13;
            }
            //If the student is aged 50 or above, they must pay $400 + 13% HST
            else
            {
                tuition = (tuition + 400) * 1.13;
            }
            Console.WriteLine();
            Console.WriteLine("Which month you registered? ");
            monthRegistered = Console.ReadLine();
            Console.WriteLine();

            //Validate month inputed
            switch (monthRegistered)
            {
                case "Jan":
                case "jan":
                case "January":
                case "january":
                    monthRegistered = "Jan.";
                    semesterRegistered = "Winter";
                    feeForSemester += (220 * 1.13);
                    break;
                case "Feb":
                case "feb":
                case "February":
                case "fabruary":
                    monthRegistered = "Feb.";
                    semesterRegistered = "Winter";
                    feeForSemester += (220 * 1.13);
                    break;
                case "Mar":
                case "mar":
                case "March":
                case "march":
                    monthRegistered = "Mar.";
                    semesterRegistered = "Winter";
                    feeForSemester += (220 * 1.13);
                    break;
                case "Apr":
                case "apr":
                case "April":
                case "april":
                    monthRegistered = "Apr.";
                    semesterRegistered = "Winter";
                    feeForSemester += (220 * 1.13);
                    break;
                case "may":
                case "May":
                    monthRegistered = "May";
                    semesterRegistered = "Summer";
                    feeForSemester += (150 * 1.13);
                    break;
                case "Jun":
                case "jun":
                case "June":
                case "june":
                    monthRegistered = "Jun.";
                    semesterRegistered = "Summer";
                    feeForSemester += (150 * 1.13);
                    break;
                case "Jul":
                case "jul":
                case "July":
                case "july":
                    monthRegistered = "Jul.";
                    semesterRegistered = "Summer";
                    feeForSemester += (150 * 1.13);
                    break;
                case "Aug":
                case "aug":
                case "August":
                case "august":
                    monthRegistered = "Aug.";
                    semesterRegistered = "Summer";
                    feeForSemester += (150 * 1.13);
                    break;
                case "Sept":
                case "sept":
                case "September":
                case "september":
                    monthRegistered = "Sept.";
                    semesterRegistered = "Fall";
                    feeForSemester += (250 * 1.13);
                    break;
                case "Oct":
                case "oct":
                case "October":
                case "october":
                    monthRegistered = "Oct.";
                    semesterRegistered = "Fall";
                    feeForSemester += (250 * 1.13);
                    break;
                case "Nov":
                case "nov":
                case "November":
                case "november":
                    monthRegistered = "Nov.";
                    semesterRegistered = "Fall";
                    feeForSemester += (250 * 1.13);
                    break;
                case "Dec":
                case "dec":
                case "December":
                case "december":
                    monthRegistered = "Dec.";
                    semesterRegistered = "Fall";
                    feeForSemester += (250 * 1.13);
                    break;
                default:
                    Console.WriteLine("Invalid month, please insert a " +
                        "valid month such as Jan or Feb");
                    break;
            }

            //Print student information
            Console.WriteLine();
            Console.WriteLine("The Student's age: " + studentAge);
            Console.WriteLine(studentType);
            Console.WriteLine("Registration Semester: " + semesterRegistered);
            Console.WriteLine();
            Console.WriteLine("Base Tuition: $" + ((tuition / 1.13) -
                internationalStudentFee));

            if (studentType == "International Student")
            {
                Console.WriteLine("International Student fee: $" + internationalStudentFee);
            }

            Console.WriteLine("Registration Fee for semester: $" + (feeForSemester / 1.13));
            Console.WriteLine("HST: $" + ((tuition + feeForSemester) -
                ((tuition + feeForSemester) / 1.13)));
            Console.WriteLine();
            Console.WriteLine("Final Total: $" + (tuition + feeForSemester));
        }
    }
}
