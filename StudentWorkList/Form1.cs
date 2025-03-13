using System;
using System.Windows.Forms;

namespace StudentWorkList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void clearData()
        {
            nameTextBox.Clear();
            surnameTextBox.Clear();
            patrTextBox.Clear();
            dofDateTimePicker.Value = DateTime.Now;
            groupComboBox.Text = "";
        }

        private void saveData(string name, string surname, string patr, DateTime dof, string group)
        {
            string studKey = $"{name} {surname} {patr} {group}";

            if (!Student.students.ContainsKey(studKey))
            {
                Student.students.Add(studKey, new Student(name, surname, patr, dof, group));
                studComboBox.Items.Add(studKey);
            }
            else
            {
                MessageBox.Show("Такой объект уже существует 0x00000001", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButtonInp_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void saveButtonInp_Click(object sender, EventArgs e)
        {
            int min = 2;
            bool flag = (nameTextBox.Text.Length > min) && (surnameTextBox.Text.Length > min) && (patrTextBox.Text.Length > min) && (groupComboBox.Text.Length > min);
            if (flag)
            {
                saveData(nameTextBox.Text, surnameTextBox.Text, patrTextBox.Text, dofDateTimePicker.Value, groupComboBox.Text);
                //clearData();
            }
            else
            {
                MessageBox.Show("Неправильный формат", "Error 0x00000002", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButtonOut_Click(object sender, EventArgs e)
        {
            outRichTextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // TODO()
        }

        private void studComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (studComboBox.Text != "")
            {
                outRichTextBox.Text = ((Student)Student.students[studComboBox.Text]).getFormatedStud();
            }
            else
            {
                MessageBox.Show("Вы не выбрали объект", "Error 0x00000003", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
