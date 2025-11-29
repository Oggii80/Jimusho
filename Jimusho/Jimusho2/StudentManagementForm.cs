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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Confirm the user wants to clear the form and start a new one
            DialogResult result = MessageBox.Show("This will clear all current students.  Continue?", "New Roster",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //I thought the icon would be a neat little touch

            if (result == DialogResult.Yes)
            {
                manager = new StudentManager(); // create a whole new empty list

                RefreshStudentList(); //Gotta' make sure the display doesn't reflect old information.

                MessageBox.Show("New roster successfully created.");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "CSV Files|*.csv|Text Files|*.txt|All Files|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                manager = new StudentManager(); //create a new instance for the new data

                using (StreamReader reader = new StreamReader(openDialog.FileName)) //
                {
                    string line; //This will take the save file and break it down into lines
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(','); //this splits the line at each comma (see the save method below to see an example of why, but essentially it's because a saved file from this program separates each field with a comma).

                        //Now we just take those parts and make a new student record from it
                        Student s = new Student();
                        s.FirstName = parts[1];
                        s.LastName = parts[2];
                        s.BeltRank = parts[3];
                        s.EnrollmentDate = DateTime.Parse(parts[4]);
                        /* While this does starts reading at index 1, it isn't really necessary to read the StudentId number
                         simply because it's automatically assigned in the AddStudent method.  I decided to keep it in the save file
                        in case a user might want to export the data to something else.*/

                        //and lastly, run the AddStudent method from the manager
                        manager.AddStudent(s);
                    }
                }
                RefreshStudentList(); //a bit redundant maybe, but updates the display with the loaded student file
                MessageBox.Show("Load Successful");
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV Files|*.csv|Text Files|*.txt|All Files|*.*";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveDialog.FileName)) //I've not messed with the StreamWriter thing before, so this line is a bit experimental, but it doesn't seem too complicated
                {
                    foreach (Student s in manager.GetAllStudents())
                    {
                        writer.WriteLine($"{s.StudentId}, {s.FirstName}, {s.LastName}, {s.BeltRank}, {s.EnrollmentDate}"); //Takes each of the fields for each student and saves it as a text file.
                    }
                }
                MessageBox.Show("Save Successful"); //displays a confirmation message

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Pretty self-explanatory ><
        }
    }
}
