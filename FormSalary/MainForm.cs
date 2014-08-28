using Newtonsoft.Json;
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

namespace FormSalary
{
    public partial class MainForm : Form
    {
        private readonly BindingSource _bindingSource = new BindingSource();
   
        public MainForm()
        {

            InitializeComponent();

            PnpPersonnelGridView.DataSource = _bindingSource;
        }

        private void AddPersonnelButton_Click(object sender, EventArgs e)
        {
            Personnel newPersonnel = new Personnel();
            newPersonnel.FirstName = FirstNameTextBox.Text;
            newPersonnel.LastName = LastNameTextBox.Text;
            newPersonnel.HireDate = HireDateTimePicker.Value;
            newPersonnel.Position = PositionListBox.SelectedItem.ToString();

            _bindingSource.Add(newPersonnel);
            pnpPersonnel.Add(newPersonnel);
        }

        private void FirstNameTextBox_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";
        }

        private void LastNameTextBox_Click(object sender, EventArgs e)
        {
            LastNameTextBox.Text = "";
        }

        List<Personnel> pnpPersonnel = new List<Personnel>();
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var myData = JsonConvert.SerializeObject(pnpPersonnel);
            File.WriteAllText(@"C:\Users\Public\New Folder\myData.json", myData);
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            var myData = File.ReadAllText(@"C:\Users\Public\New Folder\myData.json");
            List<Personnel> newPnpPersonnel = JsonConvert.DeserializeObject<List<Personnel>>(myData);

            foreach (var personnel in newPnpPersonnel)
            {
                pnpPersonnel.Add(personnel);
                _bindingSource.Add(personnel);
            }

        }


    }
}
