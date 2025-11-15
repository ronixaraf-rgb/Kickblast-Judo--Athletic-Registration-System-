using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kickblast_Judo
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            
        }
        SqlConnection con=new SqlConnection(@"Data Source=DESKTOP-PG0OULQ\SQLEXPRESS;Initial Catalog=Kickblast_Judo;Integrated Security=True");
        
        private void Registration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kickblast_JudoDataSet.Athlete_Registration' table. You can move, or remove it, as needed.
            this.athlete_RegistrationTableAdapter.Fill(this.kickblast_JudoDataSet.Athlete_Registration);

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                //taking data from the GUI
                string AthleteName = txtAthleteName.Text;
                string TrainingPlan = cmbTrainingPlan.Text;
                double CurrentWeight = double.Parse(txtCurrentWeight.Text);
                string Compet_WeightCategory = cmbWeightCategory.Text;
                int noOfCompetition = int.Parse(txtNoOfCompet.Text);
                int noOfHours = int.Parse(txtNoOfHours.Text);
                double TrainingCost = double.Parse(txtTrainingCost.Text);
                double CompetitionCost=double.Parse(txtCompetitionCost.Text);
                double Private_Coach_Fee=double.Parse(txtPrivateCoachFee.Text);
                double totalfee=double.Parse(txtTotalFee.Text);
                double Weight_Compet;
                double WeightEvaluate = double.Parse(txtWeightEvaluate.Text);
                
                //Set default selected item
                //cmbTrainingPlan.SelectedIndex = 0;
                //Attach Event Handler
                //cmbTrainingPlan.SelectedIndexChanged += cmbTrainingPlan.SelectedIndexChanged;
                if(Compet_WeightCategory== "Heavy weight >100Kg")
                {
                    Weight_Compet = 150;
                }
                else if (Compet_WeightCategory == "Light Heavy weight=100Kg")
                {
                    Weight_Compet = 100;
                }
                else if (Compet_WeightCategory == "Middle weight=90Kg")
                {
                    Weight_Compet = 90;
                }
                else if (Compet_WeightCategory == "Light Middle weight=81Kg")
                {
                    Weight_Compet = 81;
                }
                else if (Compet_WeightCategory == "Light weight=73Kg")
                {
                    Weight_Compet = 73;
                }
                else if (Compet_WeightCategory == "Fly weight=66Kg")
                {
                    Weight_Compet = 66;
                }
                else
                {
                    Weight_Compet = 0;
                }
                WeightEvaluate = Weight_Compet - CurrentWeight;
                //sql query
                string query_insert = "INSERT INTO Athlete_Registration VALUES ('"+AthleteName+"','"+TrainingCost+"','"+CompetitionCost+"','"+Private_Coach_Fee+"','"+totalfee+"','"+WeightEvaluate+"')";

                //sql command
                SqlCommand cmd=new SqlCommand(query_insert,con);
                //opening  the connection
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully","Alert",MessageBoxButtons.OK,MessageBoxIcon.Information);


            }
            catch (Exception ex) {
                MessageBox.Show("Error while Registering"+ex);
            }
            finally
            {
                //closing the connection
                con.Close();
            }
        }
        
private void cmbTrainingPlan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           if (cmbTrainingPlan.SelectedItem.ToString() == "Beginner") { 
                      cmbWeightCategory.Enabled=false;
                      txtNoOfCompet.Enabled=false;
            }
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void txtNoOfCompet_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txtAthleteName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTrainingCost.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCompetitionCost.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrivateCoachFee.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTotalFee.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtWeightEvaluate.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAthleteName.Text = "";
            cmbTrainingPlan.Text = "";
            txtNoOfCompet.Text = "";
            txtNoOfHours.Text = "";
            txtCurrentWeight.Text="";
            cmbWeightCategory.Text = "";
            txtWeightEvaluate.Text = "";
            txtTrainingCost.Text = "";
            txtCompetitionCost.Text = "";
            txtPrivateCoachFee.Text = "";
            txtTotalFee.Text = "";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double TrainingCost = double.Parse(txtTrainingCost.Text);
            double CompetitionCost = double.Parse(txtCompetitionCost.Text);
            double Private_Coach_Fee = double.Parse(txtPrivateCoachFee.Text);
            double totalfee = double.Parse(txtTotalFee.Text);
            totalfee = TrainingCost + CompetitionCost + Private_Coach_Fee;
        }

        private void txtTrainingCost_TextChanged(object sender, EventArgs e)
        {
            double TrainingCost =double.Parse( txtTrainingCost.Text);
            string TrainingPlan = cmbTrainingPlan.Text;
            if (TrainingPlan == "Beginner")
            {
                TrainingCost = 1000;

            }
            else if (TrainingPlan == "Intermediate")
            {
                TrainingCost = 1200;
            }
            else if (TrainingPlan== "Elite")
            {
                TrainingCost = 1400;
            }
            else
            {
                TrainingCost = 0;
            }


        }

        private void txtCompetitionCost_TextChanged(object sender, EventArgs e)
        {
            int noOfCompetition = int.Parse(txtNoOfCompet.Text);
            double CompetitionCost = double.Parse(txtCompetitionCost.Text);
            CompetitionCost = noOfCompetition * 220;
        }

        private void txtPrivateCoachFee_TextChanged(object sender, EventArgs e)
        {
            int noOfHours = int.Parse(txtNoOfHours.Text);
            double Private_Coach_Fee = double.Parse(txtPrivateCoachFee.Text);
            Private_Coach_Fee = noOfHours * 90.5;
        }

        private void txtWeightEvalaute_TextChanged(object sender, EventArgs e)
        {
            double CurrentWeight = double.Parse(txtCurrentWeight.Text);
            string Compet_WeightCategory = cmbWeightCategory.Text;
            double WeightEvaluate=double.Parse(txtWeightEvaluate.Text);
            double Weight_Compet;
            if (Compet_WeightCategory == "Heavy weight >100Kg")
            {
                Weight_Compet = 150;
            }
            else if (Compet_WeightCategory == "Light Heavy weight=100Kg")
            {
                Weight_Compet = 100;
            }
            else if (Compet_WeightCategory == "Middle weight=90Kg")
            {
                Weight_Compet = 90;
            }
            else if (Compet_WeightCategory == "Light Middle weight=81Kg")
            {
                Weight_Compet = 81;
            }
            else if (Compet_WeightCategory == "Light weight=73Kg")
            {
                Weight_Compet = 73;
            }
            else if (Compet_WeightCategory == "Fly weight=66Kg")
            {
                Weight_Compet = 66;
            }
            else
            {
                Weight_Compet = 0;
            }
            WeightEvaluate = Weight_Compet - CurrentWeight;
        }
    }
}
