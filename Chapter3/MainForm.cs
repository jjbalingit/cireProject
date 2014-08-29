using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace Chapter3
{
    public partial class MainForm : Form
    {
        private BindingSource myBindingSource = new BindingSource();
        public MainForm()
        {
            InitializeComponent();

            PnpPersonnelDataGridView.DataSource = myBindingSource;
        }

        private void AddPersonnelButton_Click(object sender, EventArgs e)
        {
            Personnel newPersonnel = new Personnel();
            newPersonnel.FirstName = FirstNameTextBox.Text;
            newPersonnel.LastName = LastNameTextBox.Text;
            newPersonnel.Position = PositionListBox.SelectedItem.ToString();
            newPersonnel.HireDate = HireDatePicker.Value;
           

            myBindingSource.Add(newPersonnel);
            pnpPersonnel.Add(newPersonnel);

            PnpPersonnelDataGridView.Columns[6].Visible = false;
            PnpPersonnelDataGridView.Columns[7].Visible = false;
            PnpPersonnelDataGridView.Columns[8].Visible = false;
            PnpPersonnelDataGridView.Columns[9].Visible = false;
            PnpPersonnelDataGridView.Columns[10].Visible = false;
            PnpPersonnelDataGridView.Columns[11].Visible = false;
            PnpPersonnelDataGridView.Columns[12].Visible = false;
            PnpPersonnelDataGridView.Columns[13].Visible = false;
            PnpPersonnelDataGridView.Columns[14].Visible = false;

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FirstNameText_Click(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = "";
        }

        private void LastNameTextBox_Click(object sender, EventArgs e)
        {
            LastNameTextBox.Text = "";
        }
        List<Personnel> pnpPersonnel = new List <Personnel>();
        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            string myData = File.ReadAllText(@"C:\Users\Public\pnpPersonnel.json");
            var newPnpPersonnel = JsonConvert.DeserializeObject<List<Personnel>>(myData);

            foreach (var personnel in newPnpPersonnel)
	        {
		        pnpPersonnel.Add(personnel);
                myBindingSource.Add(personnel);
	        }
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var myData = JsonConvert.SerializeObject(pnpPersonnel);
            File.WriteAllText(@"C:\Users\Public\pnpPersonnel.json",myData);

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
