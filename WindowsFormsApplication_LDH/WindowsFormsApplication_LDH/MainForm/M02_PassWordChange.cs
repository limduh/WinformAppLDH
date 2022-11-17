using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MainForm
{
    public partial class M02_PassWordChange : Form
    {
        //1. 공통 클래스 (Select와 Insert,Update,Delete 명령전달 시 공통으로 사용
        private SqlConnection Connect;//데이터베이스 접속 정보 관리 클래스

        //2. Select를 실행 후 데이터를 받아오는 클래스
        private SqlDataAdapter Adapter;

        //3. Insert,Delete,Update를 실행 할 명령 전달 클래스.
        private SqlTransaction transaction; //데이터관리 권한부여 클래스.
        private SqlCommand cmd;             //sql명령전달 클래스.



        public M02_PassWordChange()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoChangePassWord();
        }

        private void DoChangePassWord()
        {
            //비밀번호 변경 클릭
            try
            {
                //텍스트박스에 필수 입력값 등록 여부 확인.
                string sMessage = string.Empty;//메세지 변수.

                if (txtUserId.Text == "") sMessage = "사용자 ID";
                else if (txtOldPw.Text == "") sMessage = "이전 비밀번호";
                else if (txtNewPw.Text == "") sMessage = "변경 비밀번호";

                if (sMessage != "")
                {
                    MessageBox.Show(sMessage + "을 입력하지 않았습니다.");
                    return;
                }

                //벨리데이션 체크 후 데이터 베이스 접속
                //1.데이터베이스 접속 경로 설정.
                string strConn = "Server = Localhost; Uid = sa; Pwd = 1111; database = AppDev;";

                //2. 접속경로 커넥터 객체에 전달.
                Connect = new SqlConnection(strConn);


                //3. 데이터베이스 연결상태 확인.
                Connect.Open();
                if (Connect.State != ConnectionState.Open)
                {
                    MessageBox.Show("데이터베이스 연결에 실패하였습니다.");
                    return;

                }
                //입력내용 변수에 저장.
                string sLogInId               = txtUserId.Text;//사용자 ID
                string sOldPassWord           = txtOldPw.Text;//현재 비밀번호
                string sNewPassWord           = txtNewPw.Text;//변경 할 비밀번호


                //1. 기존 비밀번호 찾기 SQL구문 작성.
                string sFindUserInfo;
                sFindUserInfo = " SELECT PW ";
                sFindUserInfo += " FROM TB_USER ";
                sFindUserInfo += $" WHERE USERID = '{sLogInId}'";

                //2. Adapter(SELECT 구문을 실행하고 결과를 받아오는 클래스)
                //에 SQL 구문과 접속 정보 등록.
                Adapter = new SqlDataAdapter(sFindUserInfo, Connect);

                //3. Database로 부터 결과값을 받을 빈 DataTable객체 생성
                DataTable dtTemp = new DataTable();

                //4. Adapter 실행 및 결과 값 DataTable에 등록.
                Adapter.Fill(dtTemp);

                //5. ID 존재여부 확인
                if (dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("로그인 ID가 잘못되었습니다.");
                    return;

                }
                //현재 비밀번호 비교.
                else if (sOldPassWord != Convert.ToString(dtTemp.Rows[0]["PW"]))
                {
                    MessageBox.Show("현재 비밀번호를 잘못 입력하였습니다.");
                    return;
                }

                if (MessageBox.Show("해당 비밀번호로 변경을 진행 하시겠습니까?",
                    "비밀번호 변경", MessageBoxButtons.YesNo)
                    == DialogResult.No) //Yes/No버튼 중 NO 버튼을 클릭 하였을 경우 return;
                    return;

                //데이터베이스 명령 전달 클래스 객체에 설정한 Sql문 등록 및 실행
                
                //1.트랜잭션 선언 (데이터 관리 권한 부여) ** Update, INsert, Delete
                //여러건의 데이터를 처리 시 중간에 오류가 발생할 경우 데이터를 원상복구
                //시키기 위해 사용.
                transaction = Connect.BeginTransaction();

                //2. Insert, Update, Delete 명열을 전달 할 SqlCommand클래스 객체 생성.
                cmd = new SqlCommand();

                //3. 생성한 Command에 트랜잭션 설정 정보 등록.
                cmd.Transaction = transaction;

                //4. 접속정보 등록.
                cmd.Connection = Connect;

                //5. 실행할 SQL 구문 등록
                string sUpdateSql;
                sUpdateSql = " UPDATE TB_USER ";
                sUpdateSql += $" SEt PW = '{sNewPassWord}'";
                sUpdateSql += $" WHERE USERID = '{sLogInId}'";

                //6. 커멘드에 실행 할 sql구문
                cmd.CommandText = sUpdateSql;

                //7. 커멘드 실행
                cmd.ExecuteNonQuery();

                //8.정상완료 시 Commint
                transaction.Commit();
                MessageBox.Show("비밀번호를 정상적으로 등록 하였습니다.");
                this.Close();

            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("비밀번호 등록 중 오류가 발생 하였습니다. \r\n"
                    + ex.ToString());

            }
            finally
            {
                Connect.Close();

            }

        }

        private void txtNewPw_KeyDown(object sender, KeyEventArgs e)
        {
            //변경될 비밀번호 입력 후 엔터 입력 시 변경버튼 클릭.
            if (e.KeyCode == Keys.Enter)
            {
                DoChangePassWord();
            }
        }
    }
}
