using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05LabExe1
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] lines =
            {
                $"Student No.: {txtStudentNo.Text}",
                $"Full Name: {txtLastName.Text}, {txtFirstName.Text} {txtMI.Text}.",
                $"Program: {cbProgram.Text}",
                $"Gender: {cbGender.Text}",
                $"Age: {txtAge.Text}",
                $"Birthday: {pickerBirthday.Value.ToString("yyyy-MM-dd")}",
                $"Contact No.: {txtContactNo.Text}"
            };
            string fileName = $"{txtStudentNo.Text}.txt";
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), fileName);
            
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
            MessageBox.Show($"Check Documents Folder to see {fileName}", "Registered Successfully");
        }

        private void btnRecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmStudentRecord frmStudentRecord = new FrmStudentRecord();
            frmStudentRecord.ShowDialog();
        }
    }
}
