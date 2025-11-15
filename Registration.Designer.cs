namespace Kickblast_Judo
{
    partial class Registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.txtAthleteName = new System.Windows.Forms.TextBox();
            this.cmbTrainingPlan = new System.Windows.Forms.ComboBox();
            this.lblCompet_weight_category = new System.Windows.Forms.Label();
            this.lblCompetWeight = new System.Windows.Forms.Label();
            this.lblCurrentWeight = new System.Windows.Forms.Label();
            this.lblTrainingPlan = new System.Windows.Forms.Label();
            this.lblAthletename = new System.Windows.Forms.Label();
            this.txtCurrentWeight = new System.Windows.Forms.TextBox();
            this.cmbWeightCategory = new System.Windows.Forms.ComboBox();
            this.txtNoOfCompet = new System.Windows.Forms.TextBox();
            this.lblNoOfHours = new System.Windows.Forms.Label();
            this.txtNoOfHours = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.athleteIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athleteNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competitionCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privateCoachFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightEvaluateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athleteRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kickblast_JudoDataSet = new Kickblast_Judo.Kickblast_JudoDataSet();
            this.lblOutput = new System.Windows.Forms.Label();
            this.athlete_RegistrationTableAdapter = new Kickblast_Judo.Kickblast_JudoDataSetTableAdapters.Athlete_RegistrationTableAdapter();
            this.lblPrivateFee = new System.Windows.Forms.Label();
            this.txtPrivateCoachFee = new System.Windows.Forms.TextBox();
            this.lblCompetitionCost = new System.Windows.Forms.Label();
            this.txtCompetitionCost = new System.Windows.Forms.TextBox();
            this.lblTrainingCost = new System.Windows.Forms.Label();
            this.txtTrainingCost = new System.Windows.Forms.TextBox();
            this.txtTotalFee = new System.Windows.Forms.TextBox();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.txtWeightEvaluate = new System.Windows.Forms.TextBox();
            this.lblWeightEvaluate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athleteRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickblast_JudoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLogo.BackgroundImage")));
            this.picLogo.Location = new System.Drawing.Point(1, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(118, 94);
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.Location = new System.Drawing.Point(975, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(38, 29);
            this.picClose.TabIndex = 10;
            this.picClose.TabStop = false;
            // 
            // picMaximize
            // 
            this.picMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMaximize.BackgroundImage")));
            this.picMaximize.Location = new System.Drawing.Point(931, 0);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(38, 29);
            this.picMaximize.TabIndex = 11;
            this.picMaximize.TabStop = false;
            // 
            // picMinimize
            // 
            this.picMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picMinimize.BackgroundImage")));
            this.picMinimize.Location = new System.Drawing.Point(887, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(38, 29);
            this.picMinimize.TabIndex = 12;
            this.picMinimize.TabStop = false;
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistration.ForeColor = System.Drawing.Color.Yellow;
            this.lblRegistration.Location = new System.Drawing.Point(181, 39);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(139, 25);
            this.lblRegistration.TabIndex = 13;
            this.lblRegistration.Text = "Registration";
            // 
            // txtAthleteName
            // 
            this.txtAthleteName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtAthleteName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAthleteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAthleteName.Location = new System.Drawing.Point(272, 116);
            this.txtAthleteName.Multiline = true;
            this.txtAthleteName.Name = "txtAthleteName";
            this.txtAthleteName.Size = new System.Drawing.Size(158, 22);
            this.txtAthleteName.TabIndex = 14;
            // 
            // cmbTrainingPlan
            // 
            this.cmbTrainingPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbTrainingPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTrainingPlan.FormattingEnabled = true;
            this.cmbTrainingPlan.Items.AddRange(new object[] {
            "Beginner",
            "Intermediate",
            "Elite"});
            this.cmbTrainingPlan.Location = new System.Drawing.Point(272, 164);
            this.cmbTrainingPlan.Name = "cmbTrainingPlan";
            this.cmbTrainingPlan.Size = new System.Drawing.Size(158, 21);
            this.cmbTrainingPlan.TabIndex = 15;
            this.cmbTrainingPlan.SelectedIndexChanged += new System.EventHandler(this.cmbTrainingPlan_SelectedIndexChanged_1);
            // 
            // lblCompet_weight_category
            // 
            this.lblCompet_weight_category.AutoSize = true;
            this.lblCompet_weight_category.BackColor = System.Drawing.Color.Transparent;
            this.lblCompet_weight_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompet_weight_category.ForeColor = System.Drawing.Color.Yellow;
            this.lblCompet_weight_category.Location = new System.Drawing.Point(98, 312);
            this.lblCompet_weight_category.Name = "lblCompet_weight_category";
            this.lblCompet_weight_category.Size = new System.Drawing.Size(160, 18);
            this.lblCompet_weight_category.TabIndex = 16;
            this.lblCompet_weight_category.Text = "No. of Competitions";
            // 
            // lblCompetWeight
            // 
            this.lblCompetWeight.AutoSize = true;
            this.lblCompetWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblCompetWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetWeight.ForeColor = System.Drawing.Color.Yellow;
            this.lblCompetWeight.Location = new System.Drawing.Point(98, 247);
            this.lblCompetWeight.Name = "lblCompetWeight";
            this.lblCompetWeight.Size = new System.Drawing.Size(133, 36);
            this.lblCompetWeight.TabIndex = 17;
            this.lblCompetWeight.Text = "  Competition \r\nWeight Category";
            // 
            // lblCurrentWeight
            // 
            this.lblCurrentWeight.AutoSize = true;
            this.lblCurrentWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentWeight.ForeColor = System.Drawing.Color.Yellow;
            this.lblCurrentWeight.Location = new System.Drawing.Point(110, 217);
            this.lblCurrentWeight.Name = "lblCurrentWeight";
            this.lblCurrentWeight.Size = new System.Drawing.Size(121, 18);
            this.lblCurrentWeight.TabIndex = 18;
            this.lblCurrentWeight.Text = "Current Weight";
            // 
            // lblTrainingPlan
            // 
            this.lblTrainingPlan.AutoSize = true;
            this.lblTrainingPlan.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainingPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainingPlan.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrainingPlan.Location = new System.Drawing.Point(110, 167);
            this.lblTrainingPlan.Name = "lblTrainingPlan";
            this.lblTrainingPlan.Size = new System.Drawing.Size(106, 18);
            this.lblTrainingPlan.TabIndex = 19;
            this.lblTrainingPlan.Text = "Training Plan";
            // 
            // lblAthletename
            // 
            this.lblAthletename.AutoSize = true;
            this.lblAthletename.BackColor = System.Drawing.Color.Transparent;
            this.lblAthletename.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAthletename.ForeColor = System.Drawing.Color.Yellow;
            this.lblAthletename.Location = new System.Drawing.Point(108, 116);
            this.lblAthletename.Name = "lblAthletename";
            this.lblAthletename.Size = new System.Drawing.Size(108, 18);
            this.lblAthletename.TabIndex = 20;
            this.lblAthletename.Text = "Athlete Name";
            // 
            // txtCurrentWeight
            // 
            this.txtCurrentWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCurrentWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentWeight.Location = new System.Drawing.Point(272, 213);
            this.txtCurrentWeight.Multiline = true;
            this.txtCurrentWeight.Name = "txtCurrentWeight";
            this.txtCurrentWeight.Size = new System.Drawing.Size(158, 22);
            this.txtCurrentWeight.TabIndex = 21;
            // 
            // cmbWeightCategory
            // 
            this.cmbWeightCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbWeightCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbWeightCategory.FormattingEnabled = true;
            this.cmbWeightCategory.Items.AddRange(new object[] {
            "Heavy weight >100",
            "Light- Heavy weight 100",
            "Middle weight 90",
            "Light Middle weight 81",
            "Light weight 73",
            "Fly weight 66"});
            this.cmbWeightCategory.Location = new System.Drawing.Point(272, 262);
            this.cmbWeightCategory.Name = "cmbWeightCategory";
            this.cmbWeightCategory.Size = new System.Drawing.Size(158, 21);
            this.cmbWeightCategory.TabIndex = 22;
            // 
            // txtNoOfCompet
            // 
            this.txtNoOfCompet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNoOfCompet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoOfCompet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfCompet.Location = new System.Drawing.Point(272, 308);
            this.txtNoOfCompet.Multiline = true;
            this.txtNoOfCompet.Name = "txtNoOfCompet";
            this.txtNoOfCompet.Size = new System.Drawing.Size(158, 22);
            this.txtNoOfCompet.TabIndex = 23;
            this.txtNoOfCompet.TextChanged += new System.EventHandler(this.txtNoOfCompet_TextChanged);
            // 
            // lblNoOfHours
            // 
            this.lblNoOfHours.AutoSize = true;
            this.lblNoOfHours.BackColor = System.Drawing.Color.Transparent;
            this.lblNoOfHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOfHours.ForeColor = System.Drawing.Color.Yellow;
            this.lblNoOfHours.Location = new System.Drawing.Point(98, 345);
            this.lblNoOfHours.Name = "lblNoOfHours";
            this.lblNoOfHours.Size = new System.Drawing.Size(112, 36);
            this.lblNoOfHours.TabIndex = 24;
            this.lblNoOfHours.Text = "No. of Private\r\nCoach Hours";
            // 
            // txtNoOfHours
            // 
            this.txtNoOfHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtNoOfHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNoOfHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoOfHours.Location = new System.Drawing.Point(272, 359);
            this.txtNoOfHours.Multiline = true;
            this.txtNoOfHours.Name = "txtNoOfHours";
            this.txtNoOfHours.Size = new System.Drawing.Size(158, 22);
            this.txtNoOfHours.TabIndex = 25;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Location = new System.Drawing.Point(186, 447);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(101, 43);
            this.btnRegister.TabIndex = 26;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(357, 447);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 43);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.athleteIDDataGridViewTextBoxColumn,
            this.athleteNameDataGridViewTextBoxColumn,
            this.trainingCostDataGridViewTextBoxColumn,
            this.competitionCostDataGridViewTextBoxColumn,
            this.privateCoachFeeDataGridViewTextBoxColumn,
            this.totalFeeDataGridViewTextBoxColumn,
            this.weightEvaluateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.athleteRegistrationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(652, 308);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(334, 160);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // athleteIDDataGridViewTextBoxColumn
            // 
            this.athleteIDDataGridViewTextBoxColumn.DataPropertyName = "Athlete_ID";
            this.athleteIDDataGridViewTextBoxColumn.HeaderText = "Athlete_ID";
            this.athleteIDDataGridViewTextBoxColumn.Name = "athleteIDDataGridViewTextBoxColumn";
            this.athleteIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // athleteNameDataGridViewTextBoxColumn
            // 
            this.athleteNameDataGridViewTextBoxColumn.DataPropertyName = "Athlete_Name";
            this.athleteNameDataGridViewTextBoxColumn.HeaderText = "Athlete_Name";
            this.athleteNameDataGridViewTextBoxColumn.Name = "athleteNameDataGridViewTextBoxColumn";
            // 
            // trainingCostDataGridViewTextBoxColumn
            // 
            this.trainingCostDataGridViewTextBoxColumn.DataPropertyName = "Training_Cost";
            this.trainingCostDataGridViewTextBoxColumn.HeaderText = "Training_Cost";
            this.trainingCostDataGridViewTextBoxColumn.Name = "trainingCostDataGridViewTextBoxColumn";
            // 
            // competitionCostDataGridViewTextBoxColumn
            // 
            this.competitionCostDataGridViewTextBoxColumn.DataPropertyName = "Competition_Cost";
            this.competitionCostDataGridViewTextBoxColumn.HeaderText = "Competition_Cost";
            this.competitionCostDataGridViewTextBoxColumn.Name = "competitionCostDataGridViewTextBoxColumn";
            // 
            // privateCoachFeeDataGridViewTextBoxColumn
            // 
            this.privateCoachFeeDataGridViewTextBoxColumn.DataPropertyName = "Private_Coach_Fee";
            this.privateCoachFeeDataGridViewTextBoxColumn.HeaderText = "Private_Coach_Fee";
            this.privateCoachFeeDataGridViewTextBoxColumn.Name = "privateCoachFeeDataGridViewTextBoxColumn";
            // 
            // totalFeeDataGridViewTextBoxColumn
            // 
            this.totalFeeDataGridViewTextBoxColumn.DataPropertyName = "Total_Fee";
            this.totalFeeDataGridViewTextBoxColumn.HeaderText = "Total_Fee";
            this.totalFeeDataGridViewTextBoxColumn.Name = "totalFeeDataGridViewTextBoxColumn";
            // 
            // weightEvaluateDataGridViewTextBoxColumn
            // 
            this.weightEvaluateDataGridViewTextBoxColumn.DataPropertyName = "Weight_Evaluate";
            this.weightEvaluateDataGridViewTextBoxColumn.HeaderText = "Weight_Evaluate";
            this.weightEvaluateDataGridViewTextBoxColumn.Name = "weightEvaluateDataGridViewTextBoxColumn";
            // 
            // athleteRegistrationBindingSource
            // 
            this.athleteRegistrationBindingSource.DataMember = "Athlete_Registration";
            this.athleteRegistrationBindingSource.DataSource = this.kickblast_JudoDataSet;
            // 
            // kickblast_JudoDataSet
            // 
            this.kickblast_JudoDataSet.DataSetName = "Kickblast_JudoDataSet";
            this.kickblast_JudoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.ForeColor = System.Drawing.Color.Yellow;
            this.lblOutput.Location = new System.Drawing.Point(791, 287);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(58, 18);
            this.lblOutput.TabIndex = 29;
            this.lblOutput.Text = "Output";
            // 
            // athlete_RegistrationTableAdapter
            // 
            this.athlete_RegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // lblPrivateFee
            // 
            this.lblPrivateFee.AutoSize = true;
            this.lblPrivateFee.BackColor = System.Drawing.Color.Transparent;
            this.lblPrivateFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrivateFee.ForeColor = System.Drawing.Color.Yellow;
            this.lblPrivateFee.Location = new System.Drawing.Point(675, 167);
            this.lblPrivateFee.Name = "lblPrivateFee";
            this.lblPrivateFee.Size = new System.Drawing.Size(147, 18);
            this.lblPrivateFee.TabIndex = 30;
            this.lblPrivateFee.Text = "Private Coach Fee\r\n";
            // 
            // txtPrivateCoachFee
            // 
            this.txtPrivateCoachFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtPrivateCoachFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrivateCoachFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrivateCoachFee.Location = new System.Drawing.Point(855, 163);
            this.txtPrivateCoachFee.Multiline = true;
            this.txtPrivateCoachFee.Name = "txtPrivateCoachFee";
            this.txtPrivateCoachFee.Size = new System.Drawing.Size(158, 22);
            this.txtPrivateCoachFee.TabIndex = 31;
            this.txtPrivateCoachFee.TextChanged += new System.EventHandler(this.txtPrivateCoachFee_TextChanged);
            // 
            // lblCompetitionCost
            // 
            this.lblCompetitionCost.AutoSize = true;
            this.lblCompetitionCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCompetitionCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompetitionCost.ForeColor = System.Drawing.Color.Yellow;
            this.lblCompetitionCost.Location = new System.Drawing.Point(675, 120);
            this.lblCompetitionCost.Name = "lblCompetitionCost";
            this.lblCompetitionCost.Size = new System.Drawing.Size(140, 18);
            this.lblCompetitionCost.TabIndex = 32;
            this.lblCompetitionCost.Text = "Competition Cost";
            // 
            // txtCompetitionCost
            // 
            this.txtCompetitionCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtCompetitionCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCompetitionCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitionCost.Location = new System.Drawing.Point(855, 120);
            this.txtCompetitionCost.Multiline = true;
            this.txtCompetitionCost.Name = "txtCompetitionCost";
            this.txtCompetitionCost.Size = new System.Drawing.Size(158, 22);
            this.txtCompetitionCost.TabIndex = 33;
            this.txtCompetitionCost.TextChanged += new System.EventHandler(this.txtCompetitionCost_TextChanged);
            // 
            // lblTrainingCost
            // 
            this.lblTrainingCost.AutoSize = true;
            this.lblTrainingCost.BackColor = System.Drawing.Color.Transparent;
            this.lblTrainingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrainingCost.ForeColor = System.Drawing.Color.Yellow;
            this.lblTrainingCost.Location = new System.Drawing.Point(675, 72);
            this.lblTrainingCost.Name = "lblTrainingCost";
            this.lblTrainingCost.Size = new System.Drawing.Size(109, 18);
            this.lblTrainingCost.TabIndex = 34;
            this.lblTrainingCost.Text = "Training Cost";
            // 
            // txtTrainingCost
            // 
            this.txtTrainingCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTrainingCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrainingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainingCost.Location = new System.Drawing.Point(855, 72);
            this.txtTrainingCost.Multiline = true;
            this.txtTrainingCost.Name = "txtTrainingCost";
            this.txtTrainingCost.Size = new System.Drawing.Size(158, 22);
            this.txtTrainingCost.TabIndex = 35;
            this.txtTrainingCost.TextChanged += new System.EventHandler(this.txtTrainingCost_TextChanged);
            // 
            // txtTotalFee
            // 
            this.txtTotalFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtTotalFee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalFee.Location = new System.Drawing.Point(855, 228);
            this.txtTotalFee.Multiline = true;
            this.txtTotalFee.Name = "txtTotalFee";
            this.txtTotalFee.Size = new System.Drawing.Size(158, 27);
            this.txtTotalFee.TabIndex = 36;
            this.txtTotalFee.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFee.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotalFee.Location = new System.Drawing.Point(675, 228);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(79, 18);
            this.lblTotalFee.TabIndex = 37;
            this.lblTotalFee.Text = "Total Fee";
            // 
            // txtWeightEvaluate
            // 
            this.txtWeightEvaluate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtWeightEvaluate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeightEvaluate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeightEvaluate.Location = new System.Drawing.Point(272, 406);
            this.txtWeightEvaluate.Multiline = true;
            this.txtWeightEvaluate.Name = "txtWeightEvaluate";
            this.txtWeightEvaluate.Size = new System.Drawing.Size(158, 22);
            this.txtWeightEvaluate.TabIndex = 38;
            this.txtWeightEvaluate.TextChanged += new System.EventHandler(this.txtWeightEvalaute_TextChanged);
            // 
            // lblWeightEvaluate
            // 
            this.lblWeightEvaluate.AutoSize = true;
            this.lblWeightEvaluate.BackColor = System.Drawing.Color.Transparent;
            this.lblWeightEvaluate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeightEvaluate.ForeColor = System.Drawing.Color.Yellow;
            this.lblWeightEvaluate.Location = new System.Drawing.Point(102, 410);
            this.lblWeightEvaluate.Name = "lblWeightEvaluate";
            this.lblWeightEvaluate.Size = new System.Drawing.Size(129, 18);
            this.lblWeightEvaluate.TabIndex = 39;
            this.lblWeightEvaluate.Text = "Weight Evaluate";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1030, 563);
            this.Controls.Add(this.lblWeightEvaluate);
            this.Controls.Add(this.txtWeightEvaluate);
            this.Controls.Add(this.lblTotalFee);
            this.Controls.Add(this.txtTotalFee);
            this.Controls.Add(this.txtTrainingCost);
            this.Controls.Add(this.lblTrainingCost);
            this.Controls.Add(this.txtCompetitionCost);
            this.Controls.Add(this.lblCompetitionCost);
            this.Controls.Add(this.txtPrivateCoachFee);
            this.Controls.Add(this.lblPrivateFee);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtNoOfHours);
            this.Controls.Add(this.lblNoOfHours);
            this.Controls.Add(this.txtNoOfCompet);
            this.Controls.Add(this.cmbWeightCategory);
            this.Controls.Add(this.txtCurrentWeight);
            this.Controls.Add(this.lblAthletename);
            this.Controls.Add(this.lblTrainingPlan);
            this.Controls.Add(this.lblCurrentWeight);
            this.Controls.Add(this.lblCompetWeight);
            this.Controls.Add(this.lblCompet_weight_category);
            this.Controls.Add(this.cmbTrainingPlan);
            this.Controls.Add(this.txtAthleteName);
            this.Controls.Add(this.lblRegistration);
            this.Controls.Add(this.picMinimize);
            this.Controls.Add(this.picMaximize);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.picLogo);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athleteRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kickblast_JudoDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMaximize;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.TextBox txtAthleteName;
        private System.Windows.Forms.ComboBox cmbTrainingPlan;
        private System.Windows.Forms.Label lblCompet_weight_category;
        private System.Windows.Forms.Label lblCompetWeight;
        private System.Windows.Forms.Label lblCurrentWeight;
        private System.Windows.Forms.Label lblTrainingPlan;
        private System.Windows.Forms.Label lblAthletename;
        private System.Windows.Forms.TextBox txtCurrentWeight;
        private System.Windows.Forms.ComboBox cmbWeightCategory;
        private System.Windows.Forms.TextBox txtNoOfCompet;
        private System.Windows.Forms.Label lblNoOfHours;
        private System.Windows.Forms.TextBox txtNoOfHours;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblOutput;
        private Kickblast_JudoDataSet kickblast_JudoDataSet;
        private System.Windows.Forms.BindingSource athleteRegistrationBindingSource;
        private Kickblast_JudoDataSetTableAdapters.Athlete_RegistrationTableAdapter athlete_RegistrationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn competitionCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privateCoachFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightEvaluateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblPrivateFee;
        private System.Windows.Forms.TextBox txtPrivateCoachFee;
        private System.Windows.Forms.Label lblCompetitionCost;
        private System.Windows.Forms.TextBox txtCompetitionCost;
        private System.Windows.Forms.Label lblTrainingCost;
        private System.Windows.Forms.TextBox txtTrainingCost;
        private System.Windows.Forms.TextBox txtTotalFee;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.TextBox txtWeightEvaluate;
        private System.Windows.Forms.Label lblWeightEvaluate;
    }
}