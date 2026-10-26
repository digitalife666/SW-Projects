using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections;
using MySqlX.XDevAPI.Relational;

namespace Industrial_counter
{
    public partial class Form1 : Form
    {

        static string connstr = start_workbench_command.connect_str;
        MySqlConnection connection = new MySqlConnection(connstr);

        int db_id = 0;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("정말 종료하시겠습니까?", "종료 확인", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                // 종료 취소
                e.Cancel = true;
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void Load_SQL()
        {
            connection.Open();
            //향후 if문으로 스캐너 연결 감지를 하여 하기된 코드를 그곳에 대입.
            scanner01.Enabled = true;


            string selectQuery = "SELECT * from polishing_db.scanner01";
            MySqlCommand cmd = new MySqlCommand(selectQuery, connection);

            cmd.Connection = connection;
            //MessageBox.Show("Opened.");

            MySqlDataReader table = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (table.Read())
            {
                dataGridView1.Rows.Add(table["id"], table["MODEL"], table["QUANTITY"], table["BOX_QUANTITY"], table["ERROR"], table["UNUSED"]);
                db_id = dataGridView1.Rows.Count;
            }

            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void searching(string valueToSearch)
        {
            int value_index = 0;
            //connection.Open();
            //MessageBox.Show(valueToSearch.Length.ToString());
            connection.Open();
            string search_query = $"SELECT * FROM polishing_db.scanner01 WHERE {valueToSearch};";
            MessageBox.Show("query: " + search_query);

            MySqlCommand cmd = new MySqlCommand(search_query, connection);

            cmd.Connection = connection;

            MySqlDataReader table = cmd.ExecuteReader();
            
            dataGridView1.Rows.Clear();
            while (table.Read())
            {
                dataGridView1.Rows.Add(table["id"], table["MODEL"], table["QUANTITY"], table["BOX_QUANTITY"], table["ERROR"], table["UNUSED"]);
            }
            
            connection.Close();
            //connection.Close();

        }

        private void searching_btn_Click(object sender, EventArgs e)
        {
            if (model_text.Text == "" && quantity_text.Text == "" && box_quantity_text.Text == "" && error_text.Text == "" && unused_text.Text == "")
            {
                MessageBox.Show("모델명이 공란이 되어선 안 됩니다. 올바른 이름을 기입하십시오.", "검색 오류");
            }
            else
            {
                string model = "'" + model_text.Text + "'";
                string quantity = quantity_text.Text;
                string box_quantity = box_quantity_text.Text;
                string error = error_text.Text;
                string unused = unused_text.Text;

                string[] data_collection = { model, quantity, box_quantity, error, unused };
                int data_index = 0;

                while (data_index < data_collection.Length)
                {
                    string data = data_collection[data_index];
                    string[] data_name = { "model", "quantity", "box_quantity", "error", "unused" };

                    //MessageBox.Show("dsfsa"); 5번 출력됨.

                    if (string.IsNullOrEmpty(data) || data == "''")
                    {
                        if (data_index == 0)
                            data = $"{data_name[data_index]} IS NOT NULL";
                        else
                            data = $" AND {data_name[data_index]} IS NOT NULL";
                        data_collection[data_index] = data;
                        //MessageBox.Show("collection: " + data + " ");
                    }
                    else
                    {
                        if(data_index == 0)
                            data = $"{data_name[data_index]} = {data}";
                        else
                            data = $" AND {data_name[data_index]} = {data}";
                        data_collection[data_index] = data;
                        //MessageBox.Show("collection2: " + data);
                    }

                    data_index++;

                }
                //MessageBox.Show(string.Join("", data_collection));
                searching(string.Join("", data_collection));

                model_text.Text = "";
                quantity_text.Text = "";
                box_quantity_text.Text = "";
                error_text.Text = "";
                unused_text.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(db_id.ToString());
            Load_SQL();
            //searching("");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //db_id++;
                connection.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;

                string barcode_data = textBox1.Text;
                string[] barcode_query = barcode_data.Split();
                //textbox로 값을 읽어 insertValue에 값을 대입하는 것으로...
                string insertValue = $"INSERT INTO scanner01(id,MODEL,QUANTITY,BOX_QUANTITY,ERROR,UNUSED) VALUES ({db_id},'{barcode_query[0]}', {barcode_query[1]}, {barcode_query[2]}, {barcode_query[3]}, {barcode_query[4]});";
                MySqlCommand insertcmd = new MySqlCommand(insertValue, connection);
                insertcmd.ExecuteNonQuery();
                textBox1.Clear();
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Load_SQL();
        }

        private void 로그인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("정말로 로그아웃 하시겠습니까?", "로그아웃", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Visible = false;
                this.Close();
                Login_From login_From = new Login_From();
                login_From.Visible = true;
            }
        }
    }
}
