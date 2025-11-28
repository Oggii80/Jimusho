using DojoCore;


namespace Jimusho2
{
    public partial class StudentManagementForm : Form
    {

        private StudentManager manager; //This simply declares the field for later use.
        public StudentManagementForm()
        {
            InitializeComponent();
            manager = new StudentManager(); //This initializes the field so we now have the object created.

            RefreshStudentList(); //The refreshes the student list when the form is created.
        }

        public void RefreshStudentList()
        {
            lstStudents.Items.Clear(); //Anything previously in the list is now cleared.
            foreach (Student student in manager.GetAllStudents())
            /*This looks at each student object, and uses the GetAllStudents method to retun a list of
             * all students. */
            {
                lstStudents.Items.Add(student); //Each student is then added to the list box.
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student(); //Say that ten times fast - Still, this is kinda' why I named things the way I did.  It was a lot easier to create a class called Student that I could 
                                                //then just be like..."Okay, when I put in the button, I'll just have it be like, "newStudent is a new Student."
            ///Next we take the data from the text boxes to create the actual student record.
            newStudent.FirstName = txtFirstName.Text;
            newStudent.LastName = txtLastName.Text;
            newStudent.BeltRank = txtBelt.Text;
            newStudent.EnrollmentDate = DateTime.Now; //Once the student is added, the enrollment date is automatically stamped to their record.

            //With the data recorded, we can add the student to the manager
            manager.AddStudent(newStudent); //I'm still getting used to the idea that the object is doing all the work behind the curtains, but having to do only one line here is pretty neat.
        
            //Next we can clear out the text boxes to prevent any accidental duplicates and remove ambiguity.
            txtFirstName.Clear();
            txtLastName.Clear();    
            txtBelt.Clear();

            //and finally, we refresh the student list
            RefreshStudentList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null) //we first check to make sure something is actually selected in the list box
            {
                Student selectedStudent = (Student)lstStudents.SelectedItem; //This takes the selected item from the list box,
                                                                             //casts it as a Student the same way one might cast something as an int or string.

                manager.RemoveStudent(selectedStudent.StudentId); //This takes the selected student's ID and hands it off to the RemoveStudent method
                RefreshStudentList(); //Refreshes the student list to reflect the removed record.
            }
            else
            {
                MessageBox.Show("No record selected."); //If no record is selected, just shows a message sayying so. 
                
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshStudentList(); //Pretty straightforward - click the button, execute the RefreshStudentList method.
        }
    }
}
