using System;
using System.Collections.Generic;
using System.Text;

namespace DojoCore
{
    public class Student //this is originally set up as a private class, but we need to change it to public so it can be used by the main program
    {
        /* The private fields here are going to be store student information.  These are going to be set to private so
         * that the class itself utilizes them and cannot be changed outside of the class
         * since these don't require any starting information, we simply declare them without worrying 
         about putting in any sort of = "x, y, z." */

        private int studentId;
        private string firstName;
        private string lastName;
        private string beltRank;
        private DateTime enrollmentDate;

        /*With the private fields established, we can next start establishing properties for each of these fields*/

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        } /*While I realize that I've used simple {get; set;} properties before, I'm doing it this way
           * just to get a better intuition of exaclty what's going on with the whole get; set; thing. 
           * this is purely for my own benefit, and since I am actually working with my outside of school
           * sensei to come up with an idea for a working dojo management system, I want to make 100% sure
           * that I know exactly what's going on with no ambiguity in order to create a working system beyond 
           * this proof of concept */

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string BeltRank
        {
            get { return beltRank; }
            set { beltRank = value; }
        }

        public DateTime EnrollmentDate
        {
            get { return enrollmentDate; }
            set { enrollmentDate = value; }
        }

        /* Next up is the Constructor.  This will take the fields we've already established, and use it to create 
         * a Student object with all the necessary information.  This matches the class itself.  While I'm used to seeing
         * words like, "void" thrown around, this does not have have a return type, because it IS the return type.
         * I've seen this enough times by now, but I think having a separate class from the main program
         * brings it a bit more to the forefront of my thought process on how to create this thing. */

        public Student()
        {
            //This is the constructor that will hold all of the initial values for the student object
            studentId = 0;
            firstName = string.Empty; //I know, I could just use "", but I didn't want an empty string, I wanted to have it contain absolutely nothing.
            lastName = string.Empty;
            beltRank = string.Empty;
            enrollmentDate = DateTime.Now; //There are several options, but it made the most sense to time-stamp the enrollment date with the creation of the record for some level of automation.

        }

        /* this will provide an override for an output list-box*/
        public override string ToString()
        {
            return $"{firstName} {lastName} - {beltRank} Belt"; 
        }




    }
}
