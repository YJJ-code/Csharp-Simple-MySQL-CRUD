using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ConnectDataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection conn = new MySqlConnection("Server=localhost;Database=test_database;uid=root;pwd=111111");

        private void print_in_dataGridView()
        {
            MySqlCommand mycom = conn.CreateCommand();
            mycom.CommandText = "SELECT * FROM student ; ";
            MySqlDataAdapter adap = new MySqlDataAdapter(mycom);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection Opened Successfully");
                print_in_dataGridView();
            }
            /*mycom = conn.CreateCommand();
            mycom.CommandText = "SELECT * FROM student ; ";
            MySqlDataAdapter adap = new MySqlDataAdapter(mycom);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            string sql = string.Format("SELECT * FROM student ; ");
            mycom.CommandText = sql;
            mycom.CommandType = CommandType.Text;
            MySqlDataReader sdr = mycom.ExecuteReader();

            conn.Close();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button_insert_Click(object sender, EventArgs e)
        {
            String StuID = textBox_sid.Text;
            String StuName = textBox_sname.Text;
            String StuBirth = textBox_sbirth.Text;
            String StuSex = textBox_ssex.Text;
            
            try
            {
                conn.Open();
                String insertstr = "INSERT INTO Student (s_id,s_name,s_birth,s_sex) VALUES"+"("+StuID+","+StuName+","+StuBirth+","+StuSex+");";
                MySqlCommand cmd = new MySqlCommand(insertstr, conn); //实例化数据库命令对象
                cmd.ExecuteNonQuery(); //执行命令
            }
            catch{ MessageBox.Show("输入数据有误，请输入有效数据！", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            finally { conn.Close(); }
            //显示到dataGridView
            print_in_dataGridView();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string select_id = textBox_sid.Text;//选择的当前行第一列的值，也就是ID
                string delete_by_id = "delete from Student where s_id = " + "\"" + select_id + "\"";//sql删除语句,根据学号删除
                MySqlCommand cmd = new MySqlCommand(delete_by_id, conn);
                cmd.ExecuteNonQuery(); //执行命令
            }
            catch { MessageBox.Show("请正确选择行!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { conn.Dispose(); }
            print_in_dataGridView();

        }

        private void button_update_Click(object sender, EventArgs e)
        {
            int flag1 = 0, flag2 = 0;
            try
            {
                conn.Open();//打开数据库
                string updatestr = "UPDATE Student SET ";
                String StuID = textBox_sid.Text;
                String StuName = textBox_sname.Text;
                String StuBirth = textBox_sbirth.Text;
                String StuSex = textBox_ssex.Text;
                if (checkBox_sbirth.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        updatestr += "s_birth = " +"\""+ StuBirth+"\"";

                        flag1 = 1;

                    }
                    else
                        updatestr += ", s_birth = " + "\"" + StuBirth + "\"";
                }
                if (checkBox_sname.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        updatestr += "s_name = " + "\"" + StuName + "\"";
                        flag1 = 1;
                    }
                    else
                        updatestr += ", s_name = " + "\"" + StuName + "\"";              
}
                if (checkBox_ssex.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        updatestr += "s_sex = " + "\""+ StuSex + "\"";                    
                        flag1 = 1;
                    }
                    else
                        updatestr += ", s_sex = " + "\"" + StuSex + "\"";
                }
                updatestr += " WHERE s_id = " + "\"" + StuID + "\"";
                MySqlCommand cmd = new MySqlCommand(updatestr, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                flag2 = 1;
                MessageBox.Show("输入数据违反要求!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally{ conn.Close();}

            print_in_dataGridView();
            if (flag2 == 0)
            {
                MessageBox.Show("修改成功！", "Tips", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            String StuID = textBox_sid.Text;
            String StuName = textBox_sname.Text;
            String StuSex = textBox_ssex.Text;
            String StuBirth = textBox_sbirth.Text;
            try
            {
                conn.Open();
                String select_by_id = "select * from Student where ";
                int flag1 = 0; //表示前面是否已经加了筛选条件,为1，则后面的条件需要加AND
                if (checkBox_sid.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "s_id =" + "\"" + StuID + "\"";
                        flag1 = 1;
                    }
                    else
                        select_by_id += "AND s_id =" + "\"" + StuID + "\"";               
                }

                if (checkBox_sname.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "s_name =" + "\"" + StuName + "\"";
                        flag1 = 1;
                    }
                    else
                        select_by_id += "AND s_name =" +"\"" + StuName + "\"";
                }

                if (checkBox_ssex.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "s_sex =" + "\"" + StuSex + "\"";
                        flag1 = 1;
                    }
                    else
                        select_by_id += "AND s_sex =" + "\"" + StuSex + "\"";
                }


                if (checkBox_sbirth.Checked == true)
                {
                    if (flag1 == 0)
                    {
                        select_by_id += "s_birth ="+ "\""+StuBirth + "\"";
                        flag1 = 1;
                    }
                    else
                        select_by_id += "AND Sage =" + "\"" + StuBirth + "\"";
                }
                MySqlCommand sqlCommand = new MySqlCommand(select_by_id, conn);
                MySqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = sqlDataReader;
                dataGridView1.DataSource = bindingSource;
            }
            catch{MessageBox.Show("查询语句有误，请认真检查SQL语句!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            finally{conn.Close();}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 winform = new Form2();
            winform.Show();
        }
    }
}
