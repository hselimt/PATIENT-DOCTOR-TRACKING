using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace PATIENT_DOCTOR_TRACKING
{
    public partial class PDT : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public PDT()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            ApplyRoundedCorners();
        }

        private void PDT_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPatients();
                LoadDoctors();
                LoadAssignments();

                try
                {
                    LoadDoctorPatientComboBoxes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading patient/doctor selection " + ex.Message);
                }

                UpdateCountLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading form: " + ex.Message);
            }

            dtpPBD.MaxDate = DateTime.Today;
            dtpDBD.MaxDate = DateTime.Today;
            dtpAAD.MinDate = DateTime.Today;

            dtpAAT.Value = DateTime.Today.AddHours(9);
        }

        private void ApplyRoundedCorners()
        {
            foreach (Control c in panel2.Controls)
            {
                if (c is Button btn)
                {
                    btn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 8, 8));
                }
            }

            foreach (Control c in panel4.Controls)
            {
                if (c is Button btn)
                {
                    btn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 8, 8));
                }
            }

            foreach (Control c in panel6.Controls)
            {
                if (c is Button btn)
                {
                    btn.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 8, 8));
                }
            }
        }

        private void UpdateCountLabels()
        {
            if (dgvPatients.DataSource is DataTable patientTable)
                lblPatientCount.Text = $"Total Patients: {patientTable.Rows.Count}";

            if (dgvDoctors.DataSource is DataTable doctorTable)
                lblDoctorCount.Text = $"Total Doctors: {doctorTable.Rows.Count}";

            if (dgvAssignments.DataSource is DataTable assignmentTable)
                lblAssignmentCount.Text = $"Total Assignments: {assignmentTable.Rows.Count}";
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void LoadPatients()
        {
            string query = "SELECT patient_id, first_name, last_name, birth_date, phone_number FROM Patient";
            DataTable dt = DatabaseConnection.ExecuteQuery(query);

            if (dt != null)
            {
                dgvPatients.DataSource = dt;

                if (dgvPatients.Columns.Count > 0)
                {
                    dgvPatients.Columns["patient_id"].HeaderText = "ID";
                    dgvPatients.Columns["first_name"].HeaderText = "First Name";
                    dgvPatients.Columns["last_name"].HeaderText = "Last Name";
                    dgvPatients.Columns["birth_date"].HeaderText = "Birth Date";
                    dgvPatients.Columns["phone_number"].HeaderText = "Phone Number";
                }

                lblPatientCount.Text = $"Total Patients: {dt.Rows.Count}";
            }
        }

        private void btnPA_Click(object sender, EventArgs e)
        {
            string firstName = tbPFN.Text.Trim();
            string lastName = tbPLN.Text.Trim();
            string phoneNumber = tbPPN.Text.Trim();
            DateTime birthDate = dtpPBD.Value;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter both first name and last name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"INSERT INTO Patient (first_name, last_name, birth_date, phone_number) VALUES (N'{firstName}', N'{lastName}', '{birthDate.ToString("yyyy-MM-dd")}', N'{phoneNumber}')";

            if (DatabaseConnection.ExecuteNonQuery(query))
            {
                MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearPatientFields();
                LoadPatients();
                LoadDoctorPatientComboBoxes();
            }
        }

        private void btnPU_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int patientId = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["patient_id"].Value);
            string firstName = tbPFN.Text.Trim();
            string lastName = tbPLN.Text.Trim();
            string phoneNumber = tbPPN.Text.Trim();
            DateTime birthDate = dtpPBD.Value;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter both first name and last name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"UPDATE Patient SET first_name = N'{firstName}', last_name = N'{lastName}', birth_date = '{birthDate.ToString("yyyy-MM-dd")}', phone_number = '{phoneNumber}' WHERE patient_id = {patientId}";

            if (DatabaseConnection.ExecuteNonQuery(query))
            {
                MessageBox.Show("Patient updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearPatientFields();
                LoadPatients();
                LoadDoctorPatientComboBoxes();
            }
        }

        private void btnPD_Click(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a patient to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int patientId = Convert.ToInt32(dgvPatients.SelectedRows[0].Cells["patient_id"].Value);

            string checkQuery = $"SELECT COUNT(*) FROM Assignment WHERE patient_id = {patientId}";
            int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(checkQuery));

            if (count > 0)
            {
                MessageBox.Show("This patient has assignments. Please delete the assignments first.",
                                "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Delete",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = $"DELETE FROM Patient WHERE patient_id = {patientId}";

                if (DatabaseConnection.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearPatientFields();
                    LoadPatients();
                    LoadDoctorPatientComboBoxes();
                }
            }
        }

        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPatients.SelectedRows.Count > 0)
            {
                tbPFN.Text = dgvPatients.SelectedRows[0].Cells["first_name"].Value.ToString();
                tbPLN.Text = dgvPatients.SelectedRows[0].Cells["last_name"].Value.ToString();
                dtpPBD.Value = Convert.ToDateTime(dgvPatients.SelectedRows[0].Cells["birth_date"].Value);
                tbPPN.Text = dgvPatients.SelectedRows[0].Cells["phone_number"].Value.ToString();
            }
        }

        private void ClearPatientFields()
        {
            tbPFN.Text = string.Empty;
            tbPLN.Text = string.Empty;
            tbPPN.Text = string.Empty;
            dtpPBD.Value = DateTime.Today;
        }

        private void btnClearPatient_Click(object sender, EventArgs e)
        {
            ClearPatientFields();
        }

        private void LoadDoctors()
        {
            string query = "SELECT doctor_id, first_name, last_name, birth_date, phone_number FROM Doctor";
            DataTable dt = DatabaseConnection.ExecuteQuery(query);

            if (dt != null)
            {
                dgvDoctors.DataSource = dt;

                if (dgvDoctors.Columns.Count > 0)
                {
                    dgvDoctors.Columns["doctor_id"].HeaderText = "ID";
                    dgvDoctors.Columns["first_name"].HeaderText = "First Name";
                    dgvDoctors.Columns["last_name"].HeaderText = "Last Name";
                    dgvDoctors.Columns["birth_date"].HeaderText = "Birth Date";
                    dgvDoctors.Columns["phone_number"].HeaderText = "Phone Number";
                }

                lblDoctorCount.Text = $"Total Doctors: {dt.Rows.Count}";
            }
        }

        private void LoadDoctorPatientComboBoxes()
        {
            try
            {
                string doctorQuery = "SELECT doctor_id, CAST(doctor_id AS VARCHAR) + ' - ' + first_name + ' ' + last_name AS full_name FROM Doctor";
                DataTable dtDoctor = DatabaseConnection.ExecuteQuery(doctorQuery);

                string patientQuery = "SELECT patient_id, CAST(patient_id AS VARCHAR) + ' - ' + first_name + ' ' + last_name AS full_name FROM Patient";
                DataTable dtPatient = DatabaseConnection.ExecuteQuery(patientQuery);

                if (cbAP != null && dtPatient != null && dtPatient.Rows.Count > 0)
                {
                    cbAP.DataSource = dtPatient;
                    cbAP.DisplayMember = "full_name";
                    cbAP.ValueMember = "patient_id";
                }

                if (cbAD != null && dtDoctor != null && dtDoctor.Rows.Count > 0)
                {
                    cbAD.DataSource = dtDoctor;
                    cbAD.DisplayMember = "full_name";
                    cbAD.ValueMember = "doctor_id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in LoadDoctorPatientComboBoxes: " + ex.Message);
            }
        }

        private void btnDA_Click(object sender, EventArgs e)
        {
            string firstName = textBox2.Text.Trim();
            string lastName = textBox1.Text.Trim();
            string phoneNumber = tbDPN.Text.Trim();
            DateTime birthDate = dtpDBD.Value;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter both first name and last name.", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"INSERT INTO Doctor (first_name, last_name, birth_date, phone_number) VALUES (N'{firstName}', N'{lastName}', '{birthDate.ToString("yyyy-MM-dd")}', N'{phoneNumber}')";

            if (DatabaseConnection.ExecuteNonQuery(query))
            {
                MessageBox.Show("Doctor added successfully.", "Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDoctorFields();
                LoadDoctors();
                LoadDoctorPatientComboBoxes();
            }
        }

        private void btnDU_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a doctor to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int doctorId = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells["doctor_id"].Value);
            string firstName = textBox2.Text.Trim();
            string lastName = textBox1.Text.Trim();
            string phoneNumber = tbDPN.Text.Trim();
            DateTime birthDate = dtpDBD.Value;

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Please enter both first name and last name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"UPDATE Doctor SET first_name = N'{firstName}', last_name = N'{lastName}', birth_date = '{birthDate.ToString("yyyy-MM-dd")}', phone_number = '{phoneNumber}' WHERE doctor_id = {doctorId}";

            if (DatabaseConnection.ExecuteNonQuery(query))
            {
                MessageBox.Show("Doctor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDoctorFields();
                LoadDoctors();
                LoadDoctorPatientComboBoxes();
            }
        }

        private void btnDD_Click(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a doctor to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int doctorId = Convert.ToInt32(dgvDoctors.SelectedRows[0].Cells["doctor_id"].Value);

            string checkQuery = $"SELECT COUNT(*) FROM Assignment WHERE doctor_id = {doctorId}";
            int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(checkQuery));

            if (count > 0)
            {
                MessageBox.Show("This doctor has assignments. Please delete the assignments first.",
                                "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this doctor?", "Confirm Delete",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = $"DELETE FROM Doctor WHERE doctor_id = {doctorId}";

                if (DatabaseConnection.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Doctor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearDoctorFields();
                    LoadDoctors();
                    LoadDoctorPatientComboBoxes();
                }
            }
        }

        private void dgvDoctors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDoctors.SelectedRows.Count > 0)
            {
                textBox2.Text = dgvDoctors.SelectedRows[0].Cells["first_name"].Value.ToString();
                textBox1.Text = dgvDoctors.SelectedRows[0].Cells["last_name"].Value.ToString();
                dtpDBD.Value = Convert.ToDateTime(dgvDoctors.SelectedRows[0].Cells["birth_date"].Value);
                tbDPN.Text = dgvDoctors.SelectedRows[0].Cells["phone_number"].Value.ToString();
            }
        }

        private void ClearDoctorFields()
        {
            textBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
            tbDPN.Text = string.Empty;
            dtpDBD.Value = DateTime.Today;
        }

        private void btnClearDoctor_Click(object sender, EventArgs e)
        {
            ClearDoctorFields();
        }

        private void LoadAssignments()
        {
            string query = @"SELECT a.assignment_id, 
                     p.patient_id, 
                     CAST(p.patient_id AS VARCHAR) + ' (' + p.first_name + ' ' + p.last_name + ')' AS patient_name, 
                     d.doctor_id, 
                     CAST(d.doctor_id AS VARCHAR) + ' (' + d.first_name + ' ' + d.last_name + ')' AS doctor_name, 
                     a.assignment_date, 
                     a.assignment_time
                     FROM Assignment a
                     INNER JOIN Patient p ON a.patient_id = p.patient_id
                     INNER JOIN Doctor d ON a.doctor_id = d.doctor_id";

            DataTable dt = DatabaseConnection.ExecuteQuery(query);

            if (dt != null)
            {
                dgvAssignments.DataSource = dt;

                if (dgvAssignments.Columns.Count > 0)
                {
                    dgvAssignments.Columns["assignment_id"].HeaderText = "ID";
                    dgvAssignments.Columns["patient_id"].Visible = false;
                    dgvAssignments.Columns["doctor_id"].Visible = false;
                    dgvAssignments.Columns["patient_name"].HeaderText = "Patient";
                    dgvAssignments.Columns["doctor_name"].HeaderText = "Doctor";
                    dgvAssignments.Columns["assignment_date"].HeaderText = "Date";
                    dgvAssignments.Columns["assignment_time"].HeaderText = "Time";
                }

                lblAssignmentCount.Text = $"Total Assignments: {dt.Rows.Count}";
            }
        }

        private void btnAA_Click(object sender, EventArgs e)
        {
            int patientId = Convert.ToInt32(cbAP.SelectedValue);
            int doctorId = Convert.ToInt32(cbAD.SelectedValue);
            DateTime assignmentDate = dtpAAD.Value.Date;
            DateTime assignmentTime = dtpAAT.Value;

            string checkDTQuery = $"SELECT COUNT(*) FROM Assignment WHERE doctor_id = {doctorId} AND assignment_date = '{dtpAAD.Value:yyyy-MM-dd}' AND assignment_time = '{dtpAAT.Value:HH:mm}'";
            int countDT = Convert.ToInt32(DatabaseConnection.ExecuteScalar(checkDTQuery));

            string checkIDQuery = $"SELECT COUNT(*) FROM Assignment WHERE patient_id = {patientId} AND doctor_id = {doctorId}";
            int countID = Convert.ToInt32(DatabaseConnection.ExecuteScalar(checkIDQuery));

            string query = $"INSERT INTO Assignment (patient_id, doctor_id, assignment_date, assignment_time) VALUES ({patientId}, {doctorId}, '{assignmentDate.ToString("yyyy-MM-dd")}', '{assignmentTime.ToString("HH:mm")}')";

            if (cbAP.SelectedValue == null || cbAD.SelectedValue == null)
            {
                MessageBox.Show("Please select both a patient and a doctor.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (countDT > 0)
            {
                MessageBox.Show("This doctor is not available at that moment.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (countID > 0)
            {
                MessageBox.Show("This patient is already assigned to this doctor.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DatabaseConnection.ExecuteNonQuery(query))
            {
                MessageBox.Show("Assignment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAssignments();
            }
        }

        private void btnAU_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int assignmentId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["assignment_id"].Value);
            int patientId = Convert.ToInt32(cbAP.SelectedValue);
            int doctorId = Convert.ToInt32(cbAD.SelectedValue);
            DateTime assignmentDate = dtpAAD.Value;
            DateTime assignmentTime = dtpAAT.Value;

            string checkQuery = $"SELECT COUNT(*) FROM Assignment WHERE patient_id = {patientId} AND doctor_id = {doctorId} AND assignment_id != {assignmentId}";
            int count = Convert.ToInt32(DatabaseConnection.ExecuteScalar(checkQuery));

            if (count > 0)
            {
                MessageBox.Show("This patient is already assigned to this doctor.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"UPDATE Assignment SET patient_id = {patientId}, doctor_id = {doctorId}, assignment_date = '{assignmentDate.ToString("yyyy-MM-dd")}', assignment_time = '{assignmentTime.ToString("HH:mm")}' WHERE assignment_id = {assignmentId}";

            if (DatabaseConnection.ExecuteNonQuery(query))
            {
                MessageBox.Show("Assignment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAssignments();
            }
        }

        private void btnAD_Click(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an assignment to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int assignmentId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["assignment_id"].Value);
            if (MessageBox.Show("Are you sure you want to delete this assignment?", "Confirm Delete",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = $"DELETE FROM Assignment WHERE assignment_id = {assignmentId}";
                if (DatabaseConnection.ExecuteNonQuery(query))
                {
                    MessageBox.Show("Assignment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAssignments();
                }
            }
        }

        private void dgvAssignments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAssignments.SelectedRows.Count > 0)
            {
                int patientId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["patient_id"].Value);
                int doctorId = Convert.ToInt32(dgvAssignments.SelectedRows[0].Cells["doctor_id"].Value);
                DateTime assignmentDate = Convert.ToDateTime(dgvAssignments.SelectedRows[0].Cells["assignment_date"].Value);
                TimeSpan assignmentTime = (TimeSpan)dgvAssignments.SelectedRows[0].Cells["assignment_time"].Value;

                cbAP.SelectedValue = patientId;
                cbAD.SelectedValue = doctorId;
                dtpAAD.Value = assignmentDate;

                dtpAAT.Value = DateTime.Today.Add(assignmentTime);
            }
        }

        private void btnClearAssignment_Click(object sender, EventArgs e)
        {
            if (cbAP.Items.Count > 0) cbAP.SelectedIndex = 0;
            if (cbAD.Items.Count > 0) cbAD.SelectedIndex = 0;
            dtpAAD.Value = DateTime.Now;
            dtpAAT.Value = DateTime.Today.AddHours(9);
        }

        private void dtpAAT_ValueChanged(object sender, EventArgs e)
        {
            dtpAAT.ValueChanged -= dtpAAT_ValueChanged;

            int hour = dtpAAT.Value.Hour;
            int minute = dtpAAT.Value.Minute;

            if (hour < 9) { hour = 9; minute = 0; }
            if (hour > 17) { hour = 17; minute = 30; }

            minute = (minute > 0 && minute < 30) ? 0 : (minute >= 30 ? 30 : 0);

            dtpAAT.Value = new DateTime(dtpAAT.Value.Year, dtpAAT.Value.Month, dtpAAT.Value.Day, hour, minute, 0);
            dtpAAT.ValueChanged += dtpAAT_ValueChanged;
        }
    }
}