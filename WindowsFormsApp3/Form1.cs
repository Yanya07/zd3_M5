using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Добавление задачи из текстового поля в список
            string task = taskTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(task))
            {
                taskListBox.Items.Add(task);
                taskTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите задачу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Удаление выбранной задачи из списка
            if (taskListBox.SelectedItem != null)
            {
                taskListBox.Items.Remove(taskListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите задачу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            // Отметка задачи как выполненной
            if (taskListBox.SelectedItem != null)
            {
                string completedTask = taskListBox.SelectedItem.ToString();
                taskListBox.Items[taskListBox.SelectedIndex] = completedTask + " (Выполнено)";
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите задачу для отметки как выполненную.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}