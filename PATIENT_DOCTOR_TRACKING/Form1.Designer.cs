using System.Windows.Forms;

namespace PATIENT_DOCTOR_TRACKING
{
    partial class PDT
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PDTTABS = new System.Windows.Forms.TabControl();
            this.tabPagePM = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPatientCount = new System.Windows.Forms.Label();
            this.btnClearPatient = new System.Windows.Forms.Button();
            this.btnPD = new System.Windows.Forms.Button();
            this.btnPU = new System.Windows.Forms.Button();
            this.btnPA = new System.Windows.Forms.Button();
            this.dtpPBD = new System.Windows.Forms.DateTimePicker();
            this.tbPLN = new System.Windows.Forms.TextBox();
            this.tbPFN = new System.Windows.Forms.TextBox();
            this.lblPBD = new System.Windows.Forms.Label();
            this.lblPD = new System.Windows.Forms.Label();
            this.lblPPN = new System.Windows.Forms.Label();
            this.lblPLN = new System.Windows.Forms.Label();
            this.lblPFN = new System.Windows.Forms.Label();
            this.lblPI = new System.Windows.Forms.Label();
            this.tabPageDM = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDoctors = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDBD = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDoctorCount = new System.Windows.Forms.Label();
            this.btnClearDoctor = new System.Windows.Forms.Button();
            this.btnDD = new System.Windows.Forms.Button();
            this.btnDU = new System.Windows.Forms.Button();
            this.btnDA = new System.Windows.Forms.Button();
            this.lblDAD = new System.Windows.Forms.Label();
            this.lblDI = new System.Windows.Forms.Label();
            this.tabPageAM = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvAssignments = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblAssignmentCount = new System.Windows.Forms.Label();
            this.labelAssignmentTime = new System.Windows.Forms.Label();
            this.lblAssignmentDate = new System.Windows.Forms.Label();
            this.lblADoctor = new System.Windows.Forms.Label();
            this.lblAPatient = new System.Windows.Forms.Label();
            this.btnClearAssignment = new System.Windows.Forms.Button();
            this.btnAD = new System.Windows.Forms.Button();
            this.btnAU = new System.Windows.Forms.Button();
            this.btnAA = new System.Windows.Forms.Button();
            this.dtpAAT = new System.Windows.Forms.DateTimePicker();
            this.dtpAAD = new System.Windows.Forms.DateTimePicker();
            this.cbAD = new System.Windows.Forms.ComboBox();
            this.cbAP = new System.Windows.Forms.ComboBox();
            this.lblAI = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbPPN = new System.Windows.Forms.TextBox();
            this.tbDPN = new System.Windows.Forms.TextBox();
            this.PDTTABS.SuspendLayout();
            this.tabPagePM.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPageDM.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPageAM.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).BeginInit();
            this.panel6.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // PDTTABS
            // 
            this.PDTTABS.Controls.Add(this.tabPagePM);
            this.PDTTABS.Controls.Add(this.tabPageDM);
            this.PDTTABS.Controls.Add(this.tabPageAM);
            this.PDTTABS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PDTTABS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PDTTABS.Location = new System.Drawing.Point(0, 40);
            this.PDTTABS.Name = "PDTTABS";
            this.PDTTABS.SelectedIndex = 0;
            this.PDTTABS.Size = new System.Drawing.Size(800, 460);
            this.PDTTABS.TabIndex = 0;
            // 
            // tabPagePM
            // 
            this.tabPagePM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPagePM.Controls.Add(this.panel1);
            this.tabPagePM.Controls.Add(this.panel2);
            this.tabPagePM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePM.Location = new System.Drawing.Point(4, 30);
            this.tabPagePM.Name = "tabPagePM";
            this.tabPagePM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePM.Size = new System.Drawing.Size(792, 426);
            this.tabPagePM.TabIndex = 0;
            this.tabPagePM.Text = "Patient Management";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvPatients);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(303, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15);
            this.panel1.Size = new System.Drawing.Size(486, 420);
            this.panel1.TabIndex = 1;
            // 
            // dgvPatients
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.dgvPatients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPatients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatients.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPatients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatients.ColumnHeadersHeight = 40;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPatients.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPatients.EnableHeadersVisualStyles = false;
            this.dgvPatients.Location = new System.Drawing.Point(18, 11);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPatients.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPatients.RowTemplate.Height = 30;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(450, 400);
            this.dgvPatients.TabIndex = 4;
            this.dgvPatients.SelectionChanged += new System.EventHandler(this.dgvPatients_SelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblPatientCount);
            this.panel2.Controls.Add(this.btnClearPatient);
            this.panel2.Controls.Add(this.btnPD);
            this.panel2.Controls.Add(this.btnPU);
            this.panel2.Controls.Add(this.btnPA);
            this.panel2.Controls.Add(this.dtpPBD);
            this.panel2.Controls.Add(this.tbPLN);
            this.panel2.Controls.Add(this.tbPPN);
            this.panel2.Controls.Add(this.tbPFN);
            this.panel2.Controls.Add(this.lblPBD);
            this.panel2.Controls.Add(this.lblPD);
            this.panel2.Controls.Add(this.lblPPN);
            this.panel2.Controls.Add(this.lblPLN);
            this.panel2.Controls.Add(this.lblPFN);
            this.panel2.Controls.Add(this.lblPI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 420);
            this.panel2.TabIndex = 0;
            // 
            // lblPatientCount
            // 
            this.lblPatientCount.AutoSize = true;
            this.lblPatientCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientCount.ForeColor = System.Drawing.Color.Gray;
            this.lblPatientCount.Location = new System.Drawing.Point(20, 394);
            this.lblPatientCount.Name = "lblPatientCount";
            this.lblPatientCount.Size = new System.Drawing.Size(90, 15);
            this.lblPatientCount.TabIndex = 5;
            this.lblPatientCount.Text = "Total Patients: 0";
            // 
            // btnClearPatient
            // 
            this.btnClearPatient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClearPatient.FlatAppearance.BorderSize = 0;
            this.btnClearPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPatient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPatient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearPatient.Location = new System.Drawing.Point(20, 345);
            this.btnClearPatient.Name = "btnClearPatient";
            this.btnClearPatient.Size = new System.Drawing.Size(259, 35);
            this.btnClearPatient.TabIndex = 4;
            this.btnClearPatient.Text = "Clear Fields";
            this.btnClearPatient.UseVisualStyleBackColor = false;
            this.btnClearPatient.Click += new System.EventHandler(this.btnClearPatient_Click);
            // 
            // btnPD
            // 
            this.btnPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btnPD.FlatAppearance.BorderSize = 0;
            this.btnPD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPD.ForeColor = System.Drawing.Color.White;
            this.btnPD.Location = new System.Drawing.Point(20, 300);
            this.btnPD.Name = "btnPD";
            this.btnPD.Size = new System.Drawing.Size(259, 35);
            this.btnPD.TabIndex = 3;
            this.btnPD.Text = "DELETE";
            this.btnPD.UseVisualStyleBackColor = false;
            this.btnPD.Click += new System.EventHandler(this.btnPD_Click);
            // 
            // btnPU
            // 
            this.btnPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnPU.FlatAppearance.BorderSize = 0;
            this.btnPU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPU.ForeColor = System.Drawing.Color.White;
            this.btnPU.Location = new System.Drawing.Point(20, 255);
            this.btnPU.Name = "btnPU";
            this.btnPU.Size = new System.Drawing.Size(259, 35);
            this.btnPU.TabIndex = 3;
            this.btnPU.Text = "UPDATE";
            this.btnPU.UseVisualStyleBackColor = false;
            this.btnPU.Click += new System.EventHandler(this.btnPU_Click);
            // 
            // btnPA
            // 
            this.btnPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnPA.FlatAppearance.BorderSize = 0;
            this.btnPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPA.ForeColor = System.Drawing.Color.White;
            this.btnPA.Location = new System.Drawing.Point(20, 210);
            this.btnPA.Name = "btnPA";
            this.btnPA.Size = new System.Drawing.Size(259, 35);
            this.btnPA.TabIndex = 3;
            this.btnPA.Text = "ADD";
            this.btnPA.UseVisualStyleBackColor = false;
            this.btnPA.Click += new System.EventHandler(this.btnPA_Click);
            // 
            // dtpPBD
            // 
            this.dtpPBD.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPBD.Location = new System.Drawing.Point(80, 135);
            this.dtpPBD.Name = "dtpPBD";
            this.dtpPBD.Size = new System.Drawing.Size(80, 22);
            this.dtpPBD.TabIndex = 2;
            // 
            // tbPLN
            // 
            this.tbPLN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPLN.Location = new System.Drawing.Point(80, 105);
            this.tbPLN.Name = "tbPLN";
            this.tbPLN.Size = new System.Drawing.Size(200, 22);
            this.tbPLN.TabIndex = 1;
            // 
            // tbPFN
            // 
            this.tbPFN.BackColor = System.Drawing.Color.White;
            this.tbPFN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPFN.Location = new System.Drawing.Point(80, 75);
            this.tbPFN.Name = "tbPFN";
            this.tbPFN.Size = new System.Drawing.Size(200, 22);
            this.tbPFN.TabIndex = 1;
            // 
            // lblPBD
            // 
            this.lblPBD.AutoSize = true;
            this.lblPBD.Location = new System.Drawing.Point(390, 40);
            this.lblPBD.Name = "lblPBD";
            this.lblPBD.Size = new System.Drawing.Size(71, 17);
            this.lblPBD.TabIndex = 0;
            this.lblPBD.Text = "Birth Date";
            // 
            // lblPD
            // 
            this.lblPD.AutoSize = true;
            this.lblPD.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPD.Location = new System.Drawing.Point(15, 140);
            this.lblPD.Name = "lblPD";
            this.lblPD.Size = new System.Drawing.Size(59, 13);
            this.lblPD.TabIndex = 0;
            this.lblPD.Text = "Birth Date";
            // 
            // lblPPN
            // 
            this.lblPPN.AutoSize = true;
            this.lblPPN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPPN.Location = new System.Drawing.Point(15, 170);
            this.lblPPN.Name = "lblPPN";
            this.lblPPN.Size = new System.Drawing.Size(87, 13);
            this.lblPPN.TabIndex = 0;
            this.lblPPN.Text = "Phone Number";
            // 
            // lblPLN
            // 
            this.lblPLN.AutoSize = true;
            this.lblPLN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPLN.Location = new System.Drawing.Point(15, 110);
            this.lblPLN.Name = "lblPLN";
            this.lblPLN.Size = new System.Drawing.Size(62, 13);
            this.lblPLN.TabIndex = 0;
            this.lblPLN.Text = "Last Name";
            // 
            // lblPFN
            // 
            this.lblPFN.AutoSize = true;
            this.lblPFN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPFN.Location = new System.Drawing.Point(15, 80);
            this.lblPFN.Name = "lblPFN";
            this.lblPFN.Size = new System.Drawing.Size(63, 13);
            this.lblPFN.TabIndex = 0;
            this.lblPFN.Text = "First Name";
            // 
            // lblPI
            // 
            this.lblPI.AutoSize = true;
            this.lblPI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.lblPI.Location = new System.Drawing.Point(20, 12);
            this.lblPI.Name = "lblPI";
            this.lblPI.Size = new System.Drawing.Size(161, 20);
            this.lblPI.TabIndex = 0;
            this.lblPI.Text = "PATIENT DATA FORM";
            // 
            // tabPageDM
            // 
            this.tabPageDM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageDM.Controls.Add(this.panel3);
            this.tabPageDM.Controls.Add(this.panel4);
            this.tabPageDM.Location = new System.Drawing.Point(4, 30);
            this.tabPageDM.Name = "tabPageDM";
            this.tabPageDM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDM.Size = new System.Drawing.Size(792, 426);
            this.tabPageDM.TabIndex = 1;
            this.tabPageDM.Text = "Doctor Management";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.dgvDoctors);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(303, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(486, 420);
            this.panel3.TabIndex = 16;
            // 
            // dgvDoctors
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.dgvDoctors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDoctors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDoctors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoctors.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDoctors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDoctors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDoctors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDoctors.ColumnHeadersHeight = 40;
            this.dgvDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDoctors.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDoctors.EnableHeadersVisualStyles = false;
            this.dgvDoctors.Location = new System.Drawing.Point(18, 11);
            this.dgvDoctors.Name = "dgvDoctors";
            this.dgvDoctors.ReadOnly = true;
            this.dgvDoctors.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgvDoctors.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDoctors.RowTemplate.Height = 30;
            this.dgvDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDoctors.Size = new System.Drawing.Size(450, 400);
            this.dgvDoctors.TabIndex = 17;
            this.dgvDoctors.SelectionChanged += new System.EventHandler(this.dgvDoctors_SelectionChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.tbDPN);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dtpDBD);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.textBox2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.lblDoctorCount);
            this.panel4.Controls.Add(this.btnClearDoctor);
            this.panel4.Controls.Add(this.btnDD);
            this.panel4.Controls.Add(this.btnDU);
            this.panel4.Controls.Add(this.btnDA);
            this.panel4.Controls.Add(this.lblDAD);
            this.panel4.Controls.Add(this.lblDI);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 420);
            this.panel4.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Phone Number";
            // 
            // dtpDBD
            // 
            this.dtpDBD.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDBD.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDBD.Location = new System.Drawing.Point(80, 135);
            this.dtpDBD.Name = "dtpDBD";
            this.dtpDBD.Size = new System.Drawing.Size(80, 22);
            this.dtpDBD.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(80, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 22);
            this.textBox1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(80, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 22);
            this.textBox2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Birth Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "First Name";
            // 
            // lblDoctorCount
            // 
            this.lblDoctorCount.AutoSize = true;
            this.lblDoctorCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorCount.ForeColor = System.Drawing.Color.Gray;
            this.lblDoctorCount.Location = new System.Drawing.Point(20, 394);
            this.lblDoctorCount.Name = "lblDoctorCount";
            this.lblDoctorCount.Size = new System.Drawing.Size(89, 15);
            this.lblDoctorCount.TabIndex = 5;
            this.lblDoctorCount.Text = "Total Doctors: 0";
            // 
            // btnClearDoctor
            // 
            this.btnClearDoctor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClearDoctor.FlatAppearance.BorderSize = 0;
            this.btnClearDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDoctor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearDoctor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearDoctor.Location = new System.Drawing.Point(20, 345);
            this.btnClearDoctor.Name = "btnClearDoctor";
            this.btnClearDoctor.Size = new System.Drawing.Size(259, 35);
            this.btnClearDoctor.TabIndex = 4;
            this.btnClearDoctor.Text = "Clear Fields";
            this.btnClearDoctor.UseVisualStyleBackColor = false;
            this.btnClearDoctor.Click += new System.EventHandler(this.btnClearDoctor_Click);
            // 
            // btnDD
            // 
            this.btnDD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btnDD.FlatAppearance.BorderSize = 0;
            this.btnDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDD.ForeColor = System.Drawing.Color.White;
            this.btnDD.Location = new System.Drawing.Point(20, 300);
            this.btnDD.Name = "btnDD";
            this.btnDD.Size = new System.Drawing.Size(259, 35);
            this.btnDD.TabIndex = 3;
            this.btnDD.Text = "DELETE";
            this.btnDD.UseVisualStyleBackColor = false;
            this.btnDD.Click += new System.EventHandler(this.btnDD_Click);
            // 
            // btnDU
            // 
            this.btnDU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnDU.FlatAppearance.BorderSize = 0;
            this.btnDU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDU.ForeColor = System.Drawing.Color.White;
            this.btnDU.Location = new System.Drawing.Point(20, 255);
            this.btnDU.Name = "btnDU";
            this.btnDU.Size = new System.Drawing.Size(259, 35);
            this.btnDU.TabIndex = 3;
            this.btnDU.Text = "UPDATE";
            this.btnDU.UseVisualStyleBackColor = false;
            this.btnDU.Click += new System.EventHandler(this.btnDU_Click);
            // 
            // btnDA
            // 
            this.btnDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnDA.FlatAppearance.BorderSize = 0;
            this.btnDA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDA.ForeColor = System.Drawing.Color.White;
            this.btnDA.Location = new System.Drawing.Point(20, 210);
            this.btnDA.Name = "btnDA";
            this.btnDA.Size = new System.Drawing.Size(259, 35);
            this.btnDA.TabIndex = 3;
            this.btnDA.Text = "ADD";
            this.btnDA.UseVisualStyleBackColor = false;
            this.btnDA.Click += new System.EventHandler(this.btnDA_Click);
            // 
            // lblDAD
            // 
            this.lblDAD.AutoSize = true;
            this.lblDAD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDAD.Location = new System.Drawing.Point(349, 40);
            this.lblDAD.Name = "lblDAD";
            this.lblDAD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDAD.Size = new System.Drawing.Size(114, 17);
            this.lblDAD.TabIndex = 5;
            this.lblDAD.Text = "Assignment Date";
            this.lblDAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDI
            // 
            this.lblDI.AutoSize = true;
            this.lblDI.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.lblDI.Location = new System.Drawing.Point(20, 12);
            this.lblDI.Name = "lblDI";
            this.lblDI.Size = new System.Drawing.Size(160, 20);
            this.lblDI.TabIndex = 8;
            this.lblDI.Text = "DOCTOR DATA FORM";
            // 
            // tabPageAM
            // 
            this.tabPageAM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageAM.Controls.Add(this.panel5);
            this.tabPageAM.Controls.Add(this.panel6);
            this.tabPageAM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageAM.Location = new System.Drawing.Point(4, 30);
            this.tabPageAM.Name = "tabPageAM";
            this.tabPageAM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAM.Size = new System.Drawing.Size(792, 426);
            this.tabPageAM.TabIndex = 2;
            this.tabPageAM.Text = "Assignment Management";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.dgvAssignments);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(303, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(15);
            this.panel5.Size = new System.Drawing.Size(486, 420);
            this.panel5.TabIndex = 3;
            // 
            // dgvAssignments
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.dgvAssignments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvAssignments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAssignments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAssignments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAssignments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAssignments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(8);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAssignments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvAssignments.ColumnHeadersHeight = 40;
            this.dgvAssignments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAssignments.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvAssignments.EnableHeadersVisualStyles = false;
            this.dgvAssignments.Location = new System.Drawing.Point(18, 11);
            this.dgvAssignments.Name = "dgvAssignments";
            this.dgvAssignments.ReadOnly = true;
            this.dgvAssignments.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            this.dgvAssignments.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvAssignments.RowTemplate.Height = 30;
            this.dgvAssignments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssignments.Size = new System.Drawing.Size(450, 400);
            this.dgvAssignments.TabIndex = 18;
            this.dgvAssignments.SelectionChanged += new System.EventHandler(this.dgvAssignments_SelectionChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lblAssignmentCount);
            this.panel6.Controls.Add(this.labelAssignmentTime);
            this.panel6.Controls.Add(this.lblAssignmentDate);
            this.panel6.Controls.Add(this.lblADoctor);
            this.panel6.Controls.Add(this.lblAPatient);
            this.panel6.Controls.Add(this.btnClearAssignment);
            this.panel6.Controls.Add(this.btnAD);
            this.panel6.Controls.Add(this.btnAU);
            this.panel6.Controls.Add(this.btnAA);
            this.panel6.Controls.Add(this.dtpAAT);
            this.panel6.Controls.Add(this.dtpAAD);
            this.panel6.Controls.Add(this.cbAD);
            this.panel6.Controls.Add(this.cbAP);
            this.panel6.Controls.Add(this.lblAI);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 420);
            this.panel6.TabIndex = 2;
            // 
            // lblAssignmentCount
            // 
            this.lblAssignmentCount.AutoSize = true;
            this.lblAssignmentCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentCount.ForeColor = System.Drawing.Color.Gray;
            this.lblAssignmentCount.Location = new System.Drawing.Point(20, 394);
            this.lblAssignmentCount.Name = "lblAssignmentCount";
            this.lblAssignmentCount.Size = new System.Drawing.Size(116, 15);
            this.lblAssignmentCount.TabIndex = 5;
            this.lblAssignmentCount.Text = "Total Assignments: 0";
            // 
            // labelAssignmentTime
            // 
            this.labelAssignmentTime.AutoSize = true;
            this.labelAssignmentTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAssignmentTime.Location = new System.Drawing.Point(15, 170);
            this.labelAssignmentTime.Name = "labelAssignmentTime";
            this.labelAssignmentTime.Size = new System.Drawing.Size(97, 13);
            this.labelAssignmentTime.TabIndex = 6;
            this.labelAssignmentTime.Text = "Assignment Time";
            // 
            // lblAssignmentDate
            // 
            this.lblAssignmentDate.AutoSize = true;
            this.lblAssignmentDate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignmentDate.Location = new System.Drawing.Point(15, 140);
            this.lblAssignmentDate.Name = "lblAssignmentDate";
            this.lblAssignmentDate.Size = new System.Drawing.Size(96, 13);
            this.lblAssignmentDate.TabIndex = 6;
            this.lblAssignmentDate.Text = "Assignment Date";
            // 
            // lblADoctor
            // 
            this.lblADoctor.AutoSize = true;
            this.lblADoctor.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADoctor.Location = new System.Drawing.Point(15, 110);
            this.lblADoctor.Name = "lblADoctor";
            this.lblADoctor.Size = new System.Drawing.Size(76, 13);
            this.lblADoctor.TabIndex = 7;
            this.lblADoctor.Text = "Doctor Name";
            // 
            // lblAPatient
            // 
            this.lblAPatient.AutoSize = true;
            this.lblAPatient.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAPatient.Location = new System.Drawing.Point(15, 80);
            this.lblAPatient.Name = "lblAPatient";
            this.lblAPatient.Size = new System.Drawing.Size(78, 13);
            this.lblAPatient.TabIndex = 8;
            this.lblAPatient.Text = "Patient Name";
            // 
            // btnClearAssignment
            // 
            this.btnClearAssignment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClearAssignment.FlatAppearance.BorderSize = 0;
            this.btnClearAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAssignment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAssignment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClearAssignment.Location = new System.Drawing.Point(20, 345);
            this.btnClearAssignment.Name = "btnClearAssignment";
            this.btnClearAssignment.Size = new System.Drawing.Size(259, 35);
            this.btnClearAssignment.TabIndex = 4;
            this.btnClearAssignment.Text = "Clear Fields";
            this.btnClearAssignment.UseVisualStyleBackColor = false;
            this.btnClearAssignment.Click += new System.EventHandler(this.btnClearAssignment_Click);
            // 
            // btnAD
            // 
            this.btnAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(83)))), ((int)(((byte)(80)))));
            this.btnAD.FlatAppearance.BorderSize = 0;
            this.btnAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAD.ForeColor = System.Drawing.Color.White;
            this.btnAD.Location = new System.Drawing.Point(20, 300);
            this.btnAD.Name = "btnAD";
            this.btnAD.Size = new System.Drawing.Size(259, 35);
            this.btnAD.TabIndex = 3;
            this.btnAD.Text = "DELETE";
            this.btnAD.UseVisualStyleBackColor = false;
            this.btnAD.Click += new System.EventHandler(this.btnAD_Click);
            // 
            // btnAU
            // 
            this.btnAU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnAU.FlatAppearance.BorderSize = 0;
            this.btnAU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAU.ForeColor = System.Drawing.Color.White;
            this.btnAU.Location = new System.Drawing.Point(20, 255);
            this.btnAU.Name = "btnAU";
            this.btnAU.Size = new System.Drawing.Size(259, 35);
            this.btnAU.TabIndex = 3;
            this.btnAU.Text = "UPDATE";
            this.btnAU.UseVisualStyleBackColor = false;
            this.btnAU.Click += new System.EventHandler(this.btnAU_Click);
            // 
            // btnAA
            // 
            this.btnAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAA.FlatAppearance.BorderSize = 0;
            this.btnAA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAA.ForeColor = System.Drawing.Color.White;
            this.btnAA.Location = new System.Drawing.Point(20, 210);
            this.btnAA.Name = "btnAA";
            this.btnAA.Size = new System.Drawing.Size(259, 35);
            this.btnAA.TabIndex = 3;
            this.btnAA.Text = "ADD";
            this.btnAA.UseVisualStyleBackColor = false;
            this.btnAA.Click += new System.EventHandler(this.btnAA_Click);
            // 
            // dtpAAT
            // 
            this.dtpAAT.CustomFormat = "HH : mm";
            this.dtpAAT.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAAT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAAT.Location = new System.Drawing.Point(115, 167);
            this.dtpAAT.Name = "dtpAAT";
            this.dtpAAT.ShowUpDown = true;
            this.dtpAAT.Size = new System.Drawing.Size(80, 22);
            this.dtpAAT.TabIndex = 2;
            this.dtpAAT.ValueChanged += new System.EventHandler(this.dtpAAT_ValueChanged);
            // 
            // dtpAAD
            // 
            this.dtpAAD.CustomFormat = "MM/dd/yyyy";
            this.dtpAAD.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAAD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpAAD.Location = new System.Drawing.Point(115, 137);
            this.dtpAAD.Name = "dtpAAD";
            this.dtpAAD.Size = new System.Drawing.Size(80, 22);
            this.dtpAAD.TabIndex = 2;
            // 
            // cbAD
            // 
            this.cbAD.BackColor = System.Drawing.Color.White;
            this.cbAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAD.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAD.FormattingEnabled = true;
            this.cbAD.Location = new System.Drawing.Point(96, 107);
            this.cbAD.Name = "cbAD";
            this.cbAD.Size = new System.Drawing.Size(182, 21);
            this.cbAD.TabIndex = 1;
            // 
            // cbAP
            // 
            this.cbAP.BackColor = System.Drawing.Color.White;
            this.cbAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAP.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAP.FormattingEnabled = true;
            this.cbAP.Location = new System.Drawing.Point(96, 75);
            this.cbAP.Name = "cbAP";
            this.cbAP.Size = new System.Drawing.Size(183, 21);
            this.cbAP.TabIndex = 1;
            // 
            // lblAI
            // 
            this.lblAI.AutoSize = true;
            this.lblAI.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.lblAI.Location = new System.Drawing.Point(20, 12);
            this.lblAI.Name = "lblAI";
            this.lblAI.Size = new System.Drawing.Size(175, 20);
            this.lblAI.TabIndex = 0;
            this.lblAI.Text = "ASSIGN INFORMATION";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 40);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(121)))), ((int)(((byte)(255)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(720, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "−";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(760, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(373, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PATIENT DOCTOR TRACKING";
            // 
            // tbPPN
            // 
            this.tbPPN.BackColor = System.Drawing.Color.White;
            this.tbPPN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPPN.Location = new System.Drawing.Point(105, 165);
            this.tbPPN.MaxLength = 10;
            this.tbPPN.Name = "tbPPN";
            this.tbPPN.Size = new System.Drawing.Size(76, 22);
            this.tbPPN.TabIndex = 1;
            // 
            // tbDPN
            // 
            this.tbDPN.BackColor = System.Drawing.Color.White;
            this.tbDPN.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDPN.Location = new System.Drawing.Point(105, 165);
            this.tbDPN.MaxLength = 10;
            this.tbDPN.Name = "tbDPN";
            this.tbDPN.Size = new System.Drawing.Size(76, 22);
            this.tbDPN.TabIndex = 19;
            // 
            // PDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.PDTTABS);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PDT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PATIENT DOCTOR TRACKING";
            this.Load += new System.EventHandler(this.PDT_Load);
            this.PDTTABS.ResumeLayout(false);
            this.tabPagePM.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPageDM.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoctors)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPageAM.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssignments)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl PDTTABS;
        private System.Windows.Forms.TabPage tabPagePM;
        private System.Windows.Forms.TabPage tabPageDM;
        private System.Windows.Forms.Label lblPBD;
        private System.Windows.Forms.Label lblPLN;
        private System.Windows.Forms.Label lblPFN;
        private System.Windows.Forms.Label lblPI;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.Button btnPD;
        private System.Windows.Forms.Button btnPU;
        private System.Windows.Forms.Button btnPA;
        private System.Windows.Forms.DateTimePicker dtpPBD;
        private System.Windows.Forms.TextBox tbPLN;
        private System.Windows.Forms.TextBox tbPFN;
        private System.Windows.Forms.Button btnDD;
        private System.Windows.Forms.Button btnDU;
        private System.Windows.Forms.Button btnDA;
        private System.Windows.Forms.Label lblDAD;
        private System.Windows.Forms.Label lblDI;
        private System.Windows.Forms.DataGridView dgvDoctors;
        private System.Windows.Forms.TabPage tabPageAM;
        private System.Windows.Forms.Button btnAD;
        private System.Windows.Forms.Button btnAU;
        private System.Windows.Forms.Button btnAA;
        private System.Windows.Forms.DateTimePicker dtpAAD;
        private System.Windows.Forms.ComboBox cbAD;
        private System.Windows.Forms.ComboBox cbAP;
        private System.Windows.Forms.Label lblAI;
        private System.Windows.Forms.DataGridView dgvAssignments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClearPatient;
        private System.Windows.Forms.Button btnClearDoctor;
        private System.Windows.Forms.Button btnClearAssignment;
        private System.Windows.Forms.Label lblPatientCount;
        private System.Windows.Forms.Label lblDoctorCount;
        private System.Windows.Forms.Label lblAssignmentCount;
        private System.Windows.Forms.Label lblAssignmentDate;
        private System.Windows.Forms.Label lblADoctor;
        private System.Windows.Forms.Label lblAPatient;
        private System.Windows.Forms.Label lblPD;
        private System.Windows.Forms.DateTimePicker dtpDBD;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAssignmentTime;
        private System.Windows.Forms.DateTimePicker dtpAAT;
        private System.Windows.Forms.Label lblPPN;
        private System.Windows.Forms.Label label4;
        private TextBox tbPPN;
        private TextBox tbDPN;
    }
}