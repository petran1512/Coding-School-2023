//using Populate;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using UniversityClasses;
namespace Session_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

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

            grvStudents.AutoGenerateColumns = false;
            grvGrades.AutoGenerateColumns = false;
            grvCourses.AutoGenerateColumns = false;
            grvSchedules.AutoGenerateColumns = false;

            //STUDENTS
            List<Students> students = new List<Students>();

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
                Surname = "Kekis",
                University = "Unifercity of Athens",
                Undergraduate = false,
                Age = 30,
                Gender = Students.GenderEnum.Male,

            };
            students.Add(student2);

            grvStudents.DataSource= students;

            //DataGridViewComboBoxColumn colGender = grvStudents.Columns["colGender"] as DataGridViewComboBoxColumn;
            //colGender.Items.Add(Students.GenderEnum.Male);
            //colGender.Items.Add(Students.GenderEnum.Female);
            //colGender.Items.Add(Students.GenderEnum.Other);

            Array values = Enum.GetValues(typeof(Students.GenderEnum));
            foreach (var val in values)
            {
                colGender.Items.Add(val);
            }


            //GRADES
            List<Grades> grades = new List<Grades>();

            Grades grades1 = new Grades()
            {
                Grade = 80,
            };
            grades.Add(grades1);

            Grades grades2 = new Grades()
            {
                Grade = 90,
            };
            grades.Add(grades2);

            grvGrades.DataSource = grades;



            //COURSES
            List<Courses> courses   = new List<Courses>();

            Courses course1 = new Courses()
            {
                Code = "3240",
                Subject = "Maths",

            };
            courses.Add(course1);

            Courses course2 = new Courses()
            {
                Code = "3240",
                Subject = "Science",

            };
            courses.Add(course2);

            grvCourses.DataSource = courses;


            //SCHEDULES
            List<Schedules> schedules = new List<Schedules>();

            Schedules schedule1 = new Schedules()
            {
                Callendar = "15/01/2023",

            };
            schedules.Add(schedule1);

            Schedules schedule2 = new Schedules()
            {
                Callendar = "20/01/2023"

            };
            schedules.Add(schedule2);

            grvSchedules.DataSource = schedules;

        }




        public void grvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     

        }

        public void grvGrades_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grvSchedules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Load Done!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Serializer serializer = new Serializer();
            //serializer.SerializerToFile(students, ".json");

            MessageBox.Show("Save Done!");
        }
    }
}

