using StudentManagementSystem.Forms;
using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace StudentManagementSystem.Services
{
    internal class StudentService
    {
        public List<Student> students = new List<Student>();
        public void AddStudent()
        {
            Random random = new Random();
            string filePath = @"C:\Users\Abdulaziz\Desktop\git_projelerim\StudentManagementSystem\StudentManagementSystem\Data\StudentData.txt";
            int maxID = 0;
            
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "ID | NAME | SURNAME | AGE | SEX | DEPARTMENT | AVERAGE" + Environment.NewLine);
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(" | ");

                    if (parts.Length >= 7)
                    {
                        if (int.TryParse(parts[0], out int currentID))
                        {
                            if (currentID > maxID)
                            {
                                maxID = currentID;
                            }
                        }
                    }
                }
            }

            for (int i = 1; i <= 100; i++)
            {
                Student student = new Student();

                maxID++;
                student.ID = maxID;

                student.Name = FakeData.NameData.GetFirstName().ToUpper();
                student.SurName = FakeData.NameData.GetSurname().ToUpper();
                student.Age = FakeData.NumberData.GetNumber(18, 24).ToString();

                bool sex = FakeData.BooleanData.GetBoolean();
                if (sex)
                {
                    student.Sex = "Male";
                    student.Department = random.Next(2) == 0 ? "Software Engineer" : "Computer Engineer";
                }
                else
                {
                    student.Sex = "Female";
                    student.Department = random.Next(2) == 0 ? "Software Engineer" : "Medical";
                }
                student.Average = Math.Truncate((25.0 + random.NextDouble() * 75.0) * 1000) / 1000;

                students.Add(student);
            }

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (Student student in students)
                {
                    writer.Write($"{student.ID} | {student.Name} | {student.SurName} | {student.Age} | {student.Sex} | {student.Department} | {student.Average}{Environment.NewLine}");
                }
            }
        }
           
        public void AddStudentManuel(StudentAddForm studentAddForm)
        {
            string filePath = @"C:\Users\Abdulaziz\Desktop\git_projelerim\StudentManagementSystem\StudentManagementSystem\Data\StudentData.txt";
            Student student1 = new Student();

            if (!string.IsNullOrEmpty(studentAddForm.text_studentadd_name.Text) &&
              !string.IsNullOrEmpty(studentAddForm.text_studentadd_surname.Text) &&
              studentAddForm.comboBox_studentadd_sex.SelectedItem != null &&
              !string.IsNullOrEmpty(studentAddForm.text_studentadd_age.Text) &&
              !string.IsNullOrEmpty(studentAddForm.text_studentadd_department.Text) &&
              !string.IsNullOrEmpty(studentAddForm.text_studentadd_average.Text))
            {
                student1.Name = studentAddForm.text_studentadd_name.Text.Trim().ToUpper();
                student1.SurName = studentAddForm.text_studentadd_surname.Text.Trim().ToUpper();
                student1.Age = studentAddForm.text_studentadd_age.Text;
                student1.Sex = studentAddForm.comboBox_studentadd_sex.SelectedItem.ToString().ToUpper().Trim();
                student1.Department = studentAddForm.text_studentadd_department.Text.Trim().ToUpper();

                if (double.TryParse(studentAddForm.text_studentadd_average.Text, out double Average))
                {
                    if (0.0 <= Average && Average <= 100.0)
                    {
                        student1.Average = Average;
                    }
                    else
                    {
                        MessageBox.Show("Please enter average between 0 to 100");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid average. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                int maxID = 0;
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;

                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(" | ");
                            if (parts.Length >= 7)
                            {
                                int CurrentID = 0;
                                if (int.TryParse(parts[0], out CurrentID))
                                {
                                    CurrentID = int.Parse(parts[0]);
                                    if (CurrentID > maxID)
                                    {
                                        maxID = CurrentID;
                                    }
                                }
                            }
                        }
                    }
                }
                student1.ID = (maxID + 1);
                students.Add(student1);

                // Save data
                if (!File.Exists(filePath))
                {
                    File.WriteAllText(filePath, $"ID | NAME | SURNAME | AGE | SEX | DEPARTMENT | AVERAGE{Environment.NewLine}");
                }

                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    foreach (Student student in students)
                    {
                        writer.Write($"{student1.ID} | {student1.Name} | {student1.SurName} | {student1.Age} | {student1.Sex} | {student1.Department} | {student1.Average} {Environment.NewLine}");
                    }
                }
                MessageBox.Show("Student registration completed ", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please fill in all fields! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void DeleteStudent(StudentDeleteForm studentDeleteForm)
        {
            List<string> lines = new List<string>();
            string filePath = @"C:\Users\Abdulaziz\Desktop\git_projelerim\StudentManagementSystem\StudentManagementSystem\Data\StudentData.txt";
            bool isAuthenticated = false;
            if (!string.IsNullOrEmpty(studentDeleteForm.text_deletestudent_id.Text) &&
                !string.IsNullOrEmpty(studentDeleteForm.text_deletestudent_name.Text) &&
                !string.IsNullOrEmpty(studentDeleteForm.text_deletestudent_surname.Text))
            {
                if (File.Exists(filePath))
                {
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(" | ");
                            if (parts.Length >= 7)
                            {
                                string id = parts[0];
                                string name = parts[1];
                                string surname = parts[2];

                                if (studentDeleteForm.text_deletestudent_id.Text.ToUpper() == id.Trim().ToUpper() && studentDeleteForm.text_deletestudent_name.Text.Trim().ToUpper() == name.Trim().ToUpper() && studentDeleteForm.text_deletestudent_surname.Text.ToUpper() == surname.Trim().ToUpper())
                                {
                                    isAuthenticated = true;
                                }
                                else
                                {
                                    lines.Add(line);
                                }
                            }
                            else
                            {
                                lines.Add(line);
                            }
                        }
                    }
                    if (isAuthenticated)
                    {
                        File.WriteAllLines(filePath, lines);
                        MessageBox.Show("Student deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No Student Data Found ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all field! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void UpdateStudent(StudentUpdateForm studentUpdateForm)
        {
            List<string> lines = new List<string>();
            string filePath = @"C:\Users\Abdulaziz\Desktop\git_projelerim\StudentManagementSystem\StudentManagementSystem\Data\StudentData.txt";
            bool isAuthenticated = false;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(" | ");
                    if (parts.Length >= 7)
                    {
                        string id = parts[0];
                        string name = parts[1];
                        string surname = parts[2];
                        string age = parts[3];
                        string sex = parts[4];
                        string department = parts[5];
                        string average = parts[6];
                        if (studentUpdateForm.text_studentupdate_id.Text == id)
                        {
                            studentUpdateForm.text_studentupdate_oname.Text = name.ToString();
                            studentUpdateForm.text_studentupdate_osurname.Text = surname.ToString();
                            studentUpdateForm.text_studentupdate_oage.Text = age.ToString();
                            studentUpdateForm.text_studentupdate_osex.Text = sex.ToString();
                            studentUpdateForm.text_studentupdate_odepartment.Text = department.ToString();
                            studentUpdateForm.text_studentupdate_oaverage.Text = average.ToString();
                            isAuthenticated = true;
                            if (isAuthenticated)
                            {
                                if (string.IsNullOrEmpty(studentUpdateForm.text_studentupdate_nname.Text) ||
                                    string.IsNullOrEmpty(studentUpdateForm.text_studentupdate_nsurname.Text) ||
                                    string.IsNullOrEmpty(studentUpdateForm.text_studentupdate_nage.Text) ||
                                    string.IsNullOrEmpty(studentUpdateForm.combobox_studentupdate_nsex.Text) ||
                                    string.IsNullOrEmpty(studentUpdateForm.text_studentupdate_ndepartment.Text) ||
                                    string.IsNullOrEmpty(studentUpdateForm.text_studentupdate_naverage.Text))
                                {
                                    MessageBox.Show("Please fill in all fields! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }

                                id = parts[0].ToString();
                                name = studentUpdateForm.text_studentupdate_nname.Text.ToUpper().Trim();
                                surname = studentUpdateForm.text_studentupdate_nsurname.Text.ToUpper().Trim();
                                age = studentUpdateForm.text_studentupdate_nage.Text.ToUpper().Trim();
                                sex = studentUpdateForm.combobox_studentupdate_nsex.Text.ToUpper().Trim();
                                department = studentUpdateForm.text_studentupdate_ndepartment.Text.ToUpper().Trim();
                                average = studentUpdateForm.text_studentupdate_naverage.Text.ToUpper().Trim();

                                string updatedLine =
                                $"{id} | {name} | {surname} | {age} | {sex} | {department} | {average}";

                                lines.Add(updatedLine);
                            }
                        }
                        else
                        {
                            lines.Add(line);
                        }
                    }
                    else
                    {
                        lines.Add(line);
                    }
                }
            }
            if (isAuthenticated)
            {
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Student Update Successully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Student Data Found ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        public void FindStudent(StudentUpdateForm studentUpdateForm)
        {
            List<string> lines = new List<string>();
            string filePath = @"C:\Users\Abdulaziz\Desktop\git_projelerim\StudentManagementSystem\StudentManagementSystem\Data\StudentData.txt";
            bool isAuthenticated = false;
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(" | ");
                    if (parts.Length >= 7)
                    {
                        string id = parts[0];
                        string name = parts[1];
                        string surname = parts[2];
                        string age = parts[3];
                        string sex = parts[4];
                        string department = parts[5];
                        string average = parts[6];
                        if (studentUpdateForm.text_studentupdate_id.Text == id)
                        {
                            studentUpdateForm.text_studentupdate_oname.Text = name.ToString();
                            studentUpdateForm.text_studentupdate_osurname.Text = surname.ToString();
                            studentUpdateForm.text_studentupdate_oage.Text = age.ToString();
                            studentUpdateForm.text_studentupdate_osex.Text = sex.ToString();
                            studentUpdateForm.text_studentupdate_odepartment.Text = department.ToString();
                            studentUpdateForm.text_studentupdate_oaverage.Text = average.ToString();
                            isAuthenticated = true;
                        }
                    }
                }
            }
            if (isAuthenticated)
            {
                return;
            }

            else
            {
                MessageBox.Show("No Student Data Found ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DeleteAll()
        {
            string filePath = @"C:\Users\Abdulaziz\Desktop\git_projelerim\StudentManagementSystem\StudentManagementSystem\Data\StudentData.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Students data file is was not found! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string header = "ID | NAME | SURNAME | AGE | SEX | DEPARTMENT | AVERAGE";
            File.WriteAllText(filePath, header + Environment.NewLine);

            MessageBox.Show("All students data has been deleted successfully! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<Student> GetAllStudents()
        {
            List<Student> students = new List<Student>();

            string filePath = @"C:\Users\Abdulaziz\Desktop\git_projelerim\StudentManagementSystem\StudentManagementSystem\Data\StudentData.txt";
            if (!File.Exists(filePath))
            {
                return students;
            }
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                reader.ReadLine();

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(" | ");
                    if (parts.Length >= 7)
                    {
                        Student student = new Student();
                        student.ID = int.Parse(parts[0].Trim());
                        student.Name = parts[1].Trim();
                        student.SurName = parts[2].Trim();
                        student.Age = parts[3].Trim();
                        student.Sex = parts[4].Trim();
                        student.Department = parts[5].Trim();
                        student.Average = double.Parse(parts[6].Trim());
                        students.Add(student);

                    }
                }
            }
            return students;
        }


        public void StudentSearch(StudentSearchForm studentSearchForm)
        {

            string filePath = @"C:\Users\Abdulaziz\Desktop\git_projelerim\StudentManagementSystem\StudentManagementSystem\Data\StudentData.txt";

            using (StreamReader reader = new StreamReader(filePath))
            {
                bool isAuthenticate = false;
                string line;
                reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(" | ");
                    if (parts.Length >= 7)
                    {
                        string id = parts[0];
                        string name = parts[1];
                        string surname = parts[2];
                        string age = parts[3];
                        string sex = parts[4];
                        string department = parts[5];
                        string average = parts[6];
                        if (studentSearchForm.text_studentsearch_id.Text == id)
                        {
                            studentSearchForm.text_studentsearch_name.Text = name.ToString();
                            studentSearchForm.text_studentsearch_surname.Text = surname.ToString();
                            studentSearchForm.text_studentsearch_age.Text = age.ToString();
                            studentSearchForm.text_studentsearch_sex.Text = sex.ToString();
                            studentSearchForm.text_studentsearch_department.Text = department.ToString();
                            studentSearchForm.text_studentsearch_average.Text = average.ToString();
                            isAuthenticate = true;
                        }
                    }
                }
                if (isAuthenticate)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("No student found! ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }






    }
}
