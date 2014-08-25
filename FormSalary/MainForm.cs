using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            //Create Initial Values
            _bindingSource.Add(new Personnel());
            _bindingSource.Add(new Personnel());

            _bindingSource.Add(new Personnel());
            _bindingSource.Add(new Personnel());

            _bindingSource.Add(new Personnel());
            _bindingSource.Add(new Personnel());

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
        }


    }
}
