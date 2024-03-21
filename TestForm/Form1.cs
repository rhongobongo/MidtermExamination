using Microsoft.VisualBasic.Devices;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Web;

namespace TestForm
{
    public partial class Form1 : Form
    {
        OleDbDataAdapter? da;
        OleDbCommand? command;
        DataSet? ds;
        int indexRow;

        static string dataBase = "googleplaystore";
        static string filePath = "C:\\Users\\Jeff Leung\\Documents\\Playstore1clone.accdb";
        OleDbConnection oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Persist Security Info=False;");

        public Form1()
        {
            InitializeComponent();
            Form1 form = this;
            form.Text = dataBase + " Database";
            btnLoadData();
        }


        private void btnLoadData()
        {
            dgvStudentInfo.Refresh();
            da = new OleDbDataAdapter($"SELECT * FROM {dataBase}", oleDbConnection);

            ds = new DataSet();

            try
            {
                oleDbConnection.Open();
                da.Fill(ds, dataBase);
                dgvStudentInfo.DataSource = ds.Tables[dataBase];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                oleDbConnection.Close();
            }
        }


        private void btnInputStudent_Click(object sender, EventArgs e)
        {

            string appName = textBox01.Text;
            string category = textBox02.Text;
            double rating = trackBarAppRating.Value / 10;
            string reviews = textBox03.Text;
            string size = textBox04.Text;
            string installs = textBox05.Text;
            string type = textBox06.Text;
            double price = double.Parse(textBox07.Text);
            string contentRating = textBox08.Text;
            string genres = textBox10.Text;
            DateTime lastUpdated = DateTime.Parse(textBox11.Text);
            string currentVersion = textBox12.Text;
            string androidVersion = textBox13.Text;
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = oleDbConnection;

                command.CommandText = "INSERT INTO googleplaystore (App, Category, Rating, Reviews, AppSize, Installs, Type, Price, Content_Rating, Genres, Last_Updated, Current_Ver, Android_Ver) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                command.Parameters.AddWithValue("@App", appName);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Rating", rating);
                command.Parameters.AddWithValue("@Reviews", reviews);
                command.Parameters.AddWithValue("@AppSize", size);
                command.Parameters.AddWithValue("@Installs", installs);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Content_Rating", contentRating);
                command.Parameters.AddWithValue("@Genres", genres);
                command.Parameters.AddWithValue("@Last_Updated", lastUpdated);
                command.Parameters.AddWithValue("@Current_Ver", currentVersion);
                command.Parameters.AddWithValue("@Android_Ver", androidVersion);

                try
                {
                    oleDbConnection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Student data inserted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inserting student data: " + ex.Message);
                }
                finally
                {
                    oleDbConnection.Close();
                    btnLoadData();
                }
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbCommand command = new OleDbCommand();
                string appName = textBox01.Text;
                string category = textBox02.Text;
                double rating = trackBarAppRating.Value / 10;
                string reviews = textBox03.Text;
                string size = textBox04.Text;
                string installs = textBox05.Text;
                string type = textBox06.Text;
                double price = double.Parse(textBox07.Text);
                string contentRating = textBox08.Text;
                string genres = textBox10.Text;
                DateTime lastUpdated = DateTime.Parse(textBox11.Text);
                string currentVersion = textBox12.Text;
                string androidVersion = textBox13.Text;
                string id = textBoxID.Text;
                command.Connection = oleDbConnection;

                command.CommandText = "UPDATE googleplaystore " +
                      "SET App = ?, Category = ?, Rating = ?, Reviews = ?, AppSize = ?, Installs = ?, Type = ?, Price = ?, Content_Rating = ?, Genres = ?, Last_Updated = ?, Current_Ver = ?, Android_Ver = ? " +
                      "WHERE id = @id";

                command.Parameters.AddWithValue("@App", appName);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Rating", rating);
                command.Parameters.AddWithValue("@Reviews", reviews);
                command.Parameters.AddWithValue("@AppSize", size);
                command.Parameters.AddWithValue("@Installs", installs);
                command.Parameters.AddWithValue("@Type", type);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Content_Rating", contentRating);
                command.Parameters.AddWithValue("@Genres", genres);
                command.Parameters.AddWithValue("@Last_Updated", lastUpdated);
                command.Parameters.AddWithValue("@Current_Ver", currentVersion);
                command.Parameters.AddWithValue("@Android_Ver", androidVersion);
                command.Parameters.AddWithValue("@id", id);
                oleDbConnection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                oleDbConnection.Close();
                btnLoadData();
            }
        }

        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indexRow = e.RowIndex;
                DataGridViewRow row = dgvStudentInfo.Rows[indexRow];
                textBoxID.Text = row.Cells[0].Value.ToString();
                textBox01.Text = row.Cells[1].Value.ToString();
                textBox02.Text = row.Cells[2].Value.ToString();
                textBox03.Text = row.Cells[4].Value.ToString();
                textBox04.Text = row.Cells[5].Value.ToString();
                textBox05.Text = row.Cells[6].Value.ToString();
                textBox06.Text = row.Cells[7].Value.ToString();
                textBox07.Text = row.Cells[8].Value.ToString();
                textBox08.Text = row.Cells[9].Value.ToString();
                textBox10.Text = row.Cells[10].Value.ToString();
                textBox11.Text = row.Cells[11].Value.ToString();
                textBox12.Text = row.Cells[12].Value.ToString();
                textBox13.Text = row.Cells[13].Value.ToString();
                trackBarAppRating.Value = (int)(double.Parse(row.Cells[3].Value.ToString()) * 10);
            }
            catch (Exception ex)
            {

            }
        }
        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"DELETE FROM {dataBase} WHERE ID = @id";
                oleDbConnection = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Persist Security Info=False;");
                command = new OleDbCommand(query, oleDbConnection);
                command.Parameters.AddWithValue("@id", dgvStudentInfo.CurrentRow.Cells[0].Value);
                oleDbConnection.Open();
                command.ExecuteNonQuery();
                oleDbConnection.Close();
                btnLoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBarAppRating_ValueChanged(object sender, EventArgs e)
        {
            labelRating.Text = "Rating: " + (float)trackBarAppRating.Value / 10 + " Stars";
        }

        private void textBox07_TextChanged(object sender, EventArgs e)
        {
            // Get the reference to the TextBox control
            TextBox textBox = sender as TextBox;

            // Store the current cursor position
            int cursorPosition = textBox.SelectionStart;

            // Iterate through each character in the textbox text
            for (int i = 0; i < textBox.Text.Length; i++)
            {
                char c = textBox.Text[i];

                // Allow digits, decimal point, and control keys like Backspace
                if (!char.IsDigit(c) && c != '.' && !char.IsControl(c))
                {
                    // Remove the invalid character
                    textBox.Text = textBox.Text.Remove(i, 1);

                    // Reset the cursor position
                    textBox.SelectionStart = cursorPosition;
                    textBox.SelectionLength = 0;

                    // Break the loop
                    return;
                }

                // Allow only one decimal point
                if (c == '.' && textBox.Text.IndexOf('.') != i)
                {
                    // Remove the extra decimal point
                    textBox.Text = textBox.Text.Remove(i, 1);

                    // Reset the cursor position
                    textBox.SelectionStart = cursorPosition;
                    textBox.SelectionLength = 0;

                    // Break the loop
                    return;
                }
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int from, to;

            if (textBoxFrom.Text != "" && textBoxTo.Text != "")
            {
           
                if (int.Parse(textBoxFrom.Text) < int.Parse(textBoxTo.Text))
                {
                 
                    from = int.Parse(textBoxFrom.Text);
                    to = int.Parse(textBoxTo.Text);
                }
                else
                {
                   
                    from = int.Parse(textBoxTo.Text);
                    to = int.Parse(textBoxFrom.Text);
                }
            }
            else
            {
               
            }

        }
    }
}
