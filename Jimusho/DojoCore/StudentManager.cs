using System;
using System.Collections.Generic;
using System.Text;

namespace DojoCore
{
    /* Overall we have three different variables all some variation of student
     * To break them down for clarity:
     * Student - is a class (Student.cs) - that's the actual object itself that holds the info
     * student - in an instance of Student.  If Student is the blueprint, student is the thing created from it
     * students - is the list of all "student" objects created.
     * Note: There is no Students. Case sensitivity is quite a useful tool here as it allows
     * me to use the same word with different variations.  I definitely had to learn the difference 
     * casing formats so I use the right version for the right context */
    
    public class StudentManager
    {
        //Fields for the StudentManager class        
        private List<Student> students;
        private int nextStudentId;

        /*This doesn't really need any special properties, since it's the manager, 
         * so we can move right into the constructor */

        public StudentManager()
        {
            students = new List<Student>();
            nextStudentId = 1; // Student IDs start at 1 and will be incremented
        }

        /*The following methods will allow us to add, or remove students, view the full roster, or a single record
         */
        
        public int AddStudent(Student student) 
        {
            student.StudentId = nextStudentId; //to read this - it's basically modifying an instance of the student object built from the Student blueprint. 
                                               //then it's '.' and going to the StudentID property of the object and giving it the value held in this class by the studentID variable.
            nextStudentId++; //We've got a student added, so the newStudentId gets incremented and ready for the next student.
            students.Add(student); //adds the student to the list of students
            return student.StudentId; //returns the newly added student's ID number.
        }

        public List<Student> GetAllStudents()
        {
            return students; //This method is pretty straightforward - the list itself is created in the constructor, then records are added to or deleted from it.
                             //is takes all of that and returns the list.
        }

        public Student GetStudent(int id)
        {
            foreach (Student student in students)
            /*This goes through the roster of students one-by-one, so you could read it as:
             * for each instance within the student class (it's formatted: Class, instance, in, list)
             * and checks to see if the studentID matches. */
            {
                if (student.StudentId == id)

                {
                    return student; //easy peasy - all of the info for that student is held in the Student class
                }                   //all we needed to look at was that ID number.

            }            
           
           //I almost messed this part up.  In the "for each" loop, if you put the message box as an "else," you'll basically get either a match or kicked out as null on the first record only.
          return null; //returns a null value to prevent errors if the student isn't found.
                             
        }

        public bool RemoveStudent(int id)
        {
            Student studentToRemove = GetStudent(id); //just like the datatypes we're used to (e.g. int, string, bool, etc), 
                                                      //we can create a variable with the Student datatype.  This way, I only have to 
                                                      //call GetStudent once instead of two or three times.
            if (studentToRemove != null) //Checks to make sure the student is still in the system
            {
                students.Remove(studentToRemove); //removes the student from the list
                return true; //Gives us a confirmation that the student was removed.  Had to really fight my instincts to not put a UI item here!
            }
            else
            {
                return false; //returns false it there was no student record already
            }
        }
    }
}
