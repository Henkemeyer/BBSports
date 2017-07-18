using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BBSports
{
    public partial class Lifting : Form
    {
        private string cs = "";
        private HomePage homebase = null;

        public Lifting(HomePage hp)
        {
            InitializeComponent();
            homebase = hp;
            cs = ConfigurationManager.ConnectionStrings["BBSports.DB"].ConnectionString;
            Reset();
        }

        private void Reset()
        {
            List<ComboBoxItem> groups = new List<ComboBoxItem>();

            string getGroups = String.Format(@"select StrengthId, StrengthName from StrengthGroups " +
                                            "where AdministrationId = {0}", homebase.AdminId);

            string unassigned = String.Format(@"select distinct a.AthleteId, a.FullName from Athletes a, Teams t, Roster r " +
                                                "where t.AdministrationId = {0} and t.Active = 1 and t.TeamId = r.TeamId " +
                                                "and r.Eligibility <> 'Alumni' and r.Status <> 'Cut' and r.AthleteId = a.AthleteId " +
                                                "and a.AthleteId not in(select sg.AthleteId from StrengthGroups sg " +
                                                            "where sg.AdministrationId = t.AdministrationId)", homebase.AdminId);

            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    connection.Open();
                    using (var cmd = new SqlCommand(getGroups, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            cbGroups.Items.Clear();
                            while (reader.Read())
                            {
                                ComboBoxItem group = new ComboBoxItem(reader.GetString(1), reader.GetInt32(0));
                                cbGroups.Items.Add(group);
                                groups.Add(group);
                            }
                        }
                    }
                    if (groups.Count == 0)
                    {
                        TextBox name = new TextBox()
                        {
                            Text = "New Group",
                            Size = tbName.Size,
                            Font = tbName.Font
                        };

                        TableLayoutPanel newGp = new TableLayoutPanel()
                        {
                            BackColor = tlpDefault.BackColor,
                            Size = tlpDefault.Size,
                            RowCount = 1,
                            ColumnCount = 1,
                            AllowDrop = true
                        };
                        tpGroups.Controls.Add(name);
                        tpGroups.Controls.Add(newGp);
                        name.Location = tbName.Location;
                        newGp.Location = tlpDefault.Location;
                    }
                    else
                    {
                        foreach (var gp in groups)
                        {
                            /*TextBox name = new TextBox()
                            {
                                Text = gp.ToString(),
                                Size = tbName.Size,
                                Font = tbName.Font
                            };

                            Button destroy = new Button()
                            {
                                Font = bDelete.Font,
                                Text = "X",
                                BackColor = Color.Red,
                                Size = bDelete.Size
                            };*/
                        }
                    }
                    using (var cmd = new SqlCommand(unassigned, connection))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            tlpUnassigned.Controls.Clear();
                            while (reader.Read())
                            {
                                Button athlete = new Button()
                                {
                                    Tag = reader.GetInt32(0),
                                    Text = reader.GetString(1),
                                    Width = tlpUnassigned.Width,
                                    BackColor = Color.White,
                                    ForeColor = Color.Black
                                };
                                tlpUnassigned.Controls.Add(athlete);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "GetMeets", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItem group = (ComboBoxItem)sender;
                
            string getAthletes = String.Format(@"select a.FullName from StrengthGroups s, Athletes a " +
                                            "where s.StrengthId = {0} and s.AthleteId = a.AthleteId", group.GetId);

            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    using (var cmd = new SqlCommand(getAthletes, connection))
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            lbAthletes.Items.Clear();
                            while (reader.Read())
                            {
                                lbAthletes.Items.Add(reader.GetInt32(0));
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "GetMeets", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void NewGroup()
        {
            TextBox name = new TextBox()
            {
                Text = "New Group",
                Size = tbName.Size,
                Font = tbName.Font,
                Dock = DockStyle.Fill
            };
            name.TextChanged += new EventHandler(Name_TextChanged);

            TableLayoutPanel newGp = new TableLayoutPanel()
            {
                BackColor = tlpDefault.BackColor,
                Size = tlpDefault.Size,
                RowCount = 1,
                ColumnCount = 1,
                AllowDrop = true
            };

            Button destroy = new Button()
            {
                Font = bDelete.Font,
                Text = "X",
                BackColor = Color.Red,
                Size = bDelete.Size,
                Visible = false
            };

            flpGroups.Controls.Add(newGp);
            newGp.Controls.Add(name, 0, 0);
            newGp.Controls.Add(destroy, 1, 0);
        }

        private void Name_TextChanged(object sender, EventArgs e)
        {
            NewGroup();
        }
    }
}
