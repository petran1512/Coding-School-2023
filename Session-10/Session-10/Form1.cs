using UniversityClasses;
namespace Session_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grvStudents.AutoGenerateColumns = false;

            List<Students> students = new List<Students>(); 
            //{
            //    new Students()
            //{
            //    Name = "Peter",
            //    Surname = "Raisis",
            //    University = "Unifercity of Athens",
            //    Undergraduate = true,
            //    Age = 22,
            //    Gender = Students.GenderEnum.Male,

            //},
            //    new Students()
            //{
            //    Name = "John",
            //    Surname = "Raisis",
            //    University = "Unifercity of Athens",
            //    Undergraduate = false,
            //    Age = 16,
            //    Gender = Students.GenderEnum.Male,
            //}
            //};

            Students student1 = new Students()
            {
                Name = "Peter",
                Surname = "Raisis",
                University = "Unifercity of Athens",
                Undergraduate = true,
                Age = 22,
                Gender = Students.GenderEnum.Male,

            };
            students.Add(student1);

            Students student2 = new Students()
            {
                Name = "John",
                Surname = "Raisis",
                University = "Unifercity of Athens",
                Undergraduate = false,
                Age = 16,
                Gender = Students.GenderEnum.Male,

            };
            students.Add(student2);

            grvStudents.DataSource= students;

            DataGridViewComboBoxColumn colGender = grvStudents.Columns["colGender"] as DataGridViewComboBoxColumn;
            colGender.Items.Add(Students.GenderEnum.Male);
            colGender.Items.Add(Students.GenderEnum.Female);
            colGender.Items.Add(Students.GenderEnum.Other);

            //Array values = Enum.GetValues(typeof(Students.GenderEnum));
            //foreach(var val in values)
            //{
            //    colGender.Items.Add(val);
            //}


        }
       
        
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

