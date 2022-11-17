using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//6.M01_LogIn 화면에 M01_LogIn using Assemble;
using Assembly;
//9. SQL Server 에 접속 할 수 있는 클레스 라이브러리 생성
using System.Data.SqlClient;


namespace MainForm
{
    
    public partial class M01_LogIn : Form
    {
        //10. 접속경로 커넥터객체 지역변수로 만들기.
        private SqlConnection Connect = null;
        public M01_LogIn()
        {
            InitializeComponent();

            //7.M01_LogIn() 진입 시 sConnectInfo 에 접속정보 입력
            Commons.Coninf = "Server = Localhost; Uid = sa; Pwd = 1111;" + "database = AppDev";

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //8.로그인 버튼 클릭 이벤트 생성.

            //11.try구문 작성
            try
            {
                //데이터베이스 접속경로 Commons에서 받아오기
                string strConn = Commons.Coninf;

                //데이터베이스 접속경로 커넥터 객체에 전달
                Connect = new SqlConnection(strConn);

                //데이터베이스 접속 여부 확인
                Connect.Open();
                if (Connect.State != ConnectionState.Open)
                {
                    MessageBox.Show("데이터베이스 연결에 실패하였습니다.");
                    return;
                }
                string sLogInId = txtID.Text;
                string sPassWord = txtPw.Text;

                //ID 찾는 SQL 구문으로 변경
                string sFindUserSQL = " SELECT USERNAME , PW ";
                sFindUserSQL        += " FROM TB_USER ";
                sFindUserSQL        += $" WHERE USERID = '{sLogInId}'";

                // SqlDataAdapter : 데이터베이스에 연결 후 SELECT SQL 구문 전달,
                //                  결과값 리턴받는 클래스
                SqlDataAdapter Adapter = new SqlDataAdapter(sFindUserSQL, Connect);

                //DataTable : 프로그래밍 언어에서 데이터를 DB의 테이블 형태로 관리하는
                //            데이터 자료 구조 클래스
                // SQL 서버로 SQL문 전달 후 결과를 DataTable에 담기.
                DataTable dtTemp = new DataTable();

                //Fill은 데이터 소스의 행과 일치하도록 DataSet의 행을 추가하거나 새로 고칩니다.
                Adapter.Fill(dtTemp);

                //ID와 PW가 일치하지 않을 경우 (dtTemp에 데이터가 한 건도 없을 경우)
                //return;

                if (dtTemp.Rows.Count == 0)
                {

                    MessageBox.Show("로그인 ID가 없습니다.");
                    //입력한 값이 USERID에 없다.
                    txtID.Text = "";
                    txtID.Focus();
                    return;
                }//dtTemp 테이블에 받아온 데이터 중 PassWord 정보를 변수에 담는다.
                else if (sPassWord != Convert.ToString(dtTemp.Rows[0]["PW"]))
                {
                    MessageBox.Show("PW 가 일치하지 않습니다.");
                    txtPw.Text = sPassWord;
                    txtPw.Focus();
                    return;
                }

                // ID와 PW가 일치할 경우 LogIn

                //공통변수에 값 대입.
                Commons.sLogInUserID = sLogInId;
                Commons.sLogInUserName = Convert.ToString(dtTemp.Rows[0]["USERNAME"]);
                this.Tag = true;

                MessageBox.Show($"{Commons.sLogInUserName}님 반갑습니다.");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                Connect.Close();
            }

        }

        private void btnwasswordch_Click(object sender, EventArgs e)
        {
            M02_PassWordChange M02 = new M02_PassWordChange();
            this.Visible = false;//로그인 화면 숨기기
            M02.ShowDialog();   //M02클래스가 종료 되기 전까지 다음로직을 수행하지 않는다.
            this.Visible = true;//로그인 화면 다시 나타내기

        }
    }
}
