using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            //close the program.
            this.Close();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //empty
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            //show about
            About box = new About();
            box.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //appear update button, and check list
            btnUpdate.Visible = true;
            CheckList.Visible = true;

            //display status bar
            lblStatus.Text = "Choose category from list";
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                //display name of class
                lblName.Text = txtName.Text;
                lblName.Visible = true;
                txtName.Visible = false;
                btnNameEdit.Visible = true;
                btnName.Visible = false;
            }
            else
            {
                MessageBox.Show("Please Type the name of class (Ex. CptS 321 or \"Object-Oriented Software Princ\")");
            }
        }

        private void btnNameEdit_Click(object sender, EventArgs e)
        {
            //change name of class
            lblName.Visible = false;
            txtName.Visible = true;
            btnNameEdit.Visible = false;
            btnName.Visible = true;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            //when press enter button while type name of class
            if (e.KeyCode == Keys.Enter)
            {
                lblName.Text = txtName.Text;
                lblName.Visible = true;
                txtName.Visible = false;
                btnNameEdit.Visible = true;
                btnName.Visible = false;
            }
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            
        }

        private void menuLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //display warning message
            DialogResult result = MessageBox.Show("If you click yes, you will lost all data.", "Make sure go back.", MessageBoxButtons.YesNo);
            
            //remove all data and go back to checklist
            if (result == DialogResult.Yes)
            {
                DataSheet.Columns.Clear();

                CheckList.Visible = true;
                btnUpdate.Visible = true;
                menuData.Visible = false;
                layResult.Visible = false;
                lblAttedence.Visible = false;
                txtAttedence.Visible = false;
                lblInclass.Visible = false;
                txtInclass.Visible = false;
                lblAssignment.Visible = false;
                txtAssignment.Visible = false;
                lblMidterm.Visible = false;
                txtMidterm.Visible = false;
                lblFinal.Visible = false;
                txtFinal.Visible = false;
                lblOther.Visible = false;
                txtOther.Visible = false;
                txtA.Text = "";
                txtB.Text = "";
                txtC.Text = "";
                txtAttedence.Text = "";
                txtInclass.Text = "";
                txtAssignment.Text = "";
                txtMidterm.Text = "";
                txtFinal.Text = "";
                txtOther.Text = "";
                lblStatus.Text = "Choose category from list";

                foreach (int i in CheckList.CheckedIndices)
                {
                    CheckList.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
        }

        private void CheckList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //empty
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //check the list
            int count = 0;

            for (int i = 0; i < CheckList.Items.Count; i++)
            {
                if (CheckList.GetItemChecked(i))
                {
                    count++;
                }
            }

            //display datasheets, labels, and textbox depend on what user choose.
            if (count > 0)
            {
                CheckList.Visible = false;
                btnUpdate.Visible = false;
                menuData.Visible = true;
                layResult.Visible = true;

                for (int i = 0; i < CheckList.Items.Count; i++)
                {
                    if (CheckList.GetItemChecked(i))
                    {
                        string item = (string)CheckList.Items[i];

                        DataSheet.Columns.Add(item, item);

                        switch (item)
                        {
                            case "Attendence":
                                lblAttedence.Visible = true;
                                txtAttedence.Visible = true;
                                break;
                            case "In-class works":
                                lblInclass.Visible = true;
                                txtInclass.Visible = true;
                                break;
                            case "Assignments":
                                lblAssignment.Visible = true;
                                txtAssignment.Visible = true;
                                break;
                            case "Midterm":
                                lblMidterm.Visible = true;
                                txtMidterm.Visible = true;
                                break;
                            case "Final":
                                lblFinal.Visible = true;
                                txtFinal.Visible = true;
                                break;
                            case "Others":
                                lblOther.Visible = true;
                                txtOther.Visible = true;
                                break;
                        }
                    }
                }

                for (int i = 0; i < 15; i++)
                {
                    int temp = i + 1;
                    DataSheet.Rows.Add();
                    DataSheet.Rows[i].HeaderCell.Value = temp.ToString();
                }

                lblStatus.Text = "Fill up all of \"Require Percent\", and \"Percent of Category\" ";
            }
            else
            {
                MessageBox.Show("Please check at least one category.", "No checked category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void menuHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please read and status bar at the bottom. \r\n" + lblStatus.Text);
        }
    }
}
