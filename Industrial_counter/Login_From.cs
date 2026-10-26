using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Industrial_counter
{
    public partial class Login_From : Form
    {
        static string connectionstr = start_workbench_command.connect_str;
        public Login_From()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(Login_From_FormClosing);
        }

        private void Login_From_FormClosing(object sender, FormClosingEventArgs e)
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

        private void login_btn_Click(object sender, EventArgs e)
        {
            string input_id = IDBox.Text.Trim();
            string input_pw = PWBox.Text.Trim();

            if (string.IsNullOrEmpty(input_id) || string.IsNullOrEmpty(input_pw))
            {
                MessageBox.Show("사용자 이름 또는 비밀번호를 입력하십시오.", "로그인 오류");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionstr))
                {
                    connection.Open();

                    string selectQuery = "SELECT COUNT(*) from polishing_db.account_data WHERE user_name = @id AND user_password = @pw;";
                    string departmentQuery = "SELECT user_department from polishing_db.account_data WHERE user_name = @id;";

                    MySqlCommand cmdd = new MySqlCommand(departmentQuery, connection);
                    cmdd.Parameters.Add("@id", MySqlDbType.VarChar).Value = IDBox.Text;

                    using (MySqlDataReader reader = cmdd.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            string department = reader["user_department"].ToString();
                            if (department == "생산자")
                            {
                                Form1 form1 = new Form1();
                                form1.ShowDialog();
                            }
                            else if (department == "검사자")
                            {
                                Form2 form2 = new Form2();
                                form2.ShowDialog();
                            }
                            else
                            {
                                Form3 form3 = new Form3();
                                form3.ShowDialog();
                            }
                        }
                    }

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@id", input_id);
                        cmd.Parameters.AddWithValue("@pw", input_pw);

                        long count = (long)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            //MessageBox.Show(count.ToString());
                            this.Visible = false;
                            connection.Close();
                            //this.Close();
                        }
                        else
                        {
                            MessageBox.Show("아이디 또는 비밀번호가 일치하지 않습니다. 다시 시도하십시오.", "로그인 오류");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터베이스 연결 중 오류가 발생했습니다: {ex.Message}", "오류");
            }
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            //이곳에 회원가입 폼 불러오기 코드 작성...
            //동일한 아이디가 존재하지 않도록 선별하는 코드도 추가하여야 함.
            CreateAccount_Form account_Form = new CreateAccount_Form();
            account_Form.ShowDialog();
        }
    }
}
