using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//스레드를 사용하기 위한 라이브러리 참조
using System.Threading;
using Assembly;
using Form_List;
//어셈블리 파일 호출 하는 라이브러리 참조
using System.Reflection;

namespace MainForm
{
    public partial class M03_MainForm : Form
    {

        private Thread thNowTime;//현재 시각을 표현할 스레드 객체

        public M03_MainForm()
        {
            InitializeComponent();
            //2.메인 창이 열리는 순간 로그인을 실행 한다.
            M01_LogIn M01 = new M01_LogIn();
            M01.ShowDialog();

            //호출했던 로그인 화면의 결과 Tag값이 성공이 아니면
            //프로그램 종료.
            if (Convert.ToBoolean(M01.Tag) != true)
            {
                //프로그램 종료
                Environment.Exit(0);
            }


        }


        //신규 스레드를 통한 현재 시간 체크
        //Thread : 프로세스 내부에서 생성되는 작업을 주체.
        // 스레드를 생성함으로서 하나의 프로세스 외에 여러가지 일을 동시 수행 가능

        private void M03_MainForm_Load(object sender, EventArgs e)
        {
            //현재시각 Thread 시작.
            thNowTime = new Thread(new ThreadStart(GetNowTime));
            if (thNowTime.IsAlive == false) thNowTime.Start();

            stsUserName.Text = Commons.sLogInUserName;
        }

        private void GetNowTime()
        {

            while (true)
            {
                Thread.Sleep(1000);// 1  초 마다 잠시 쉬었다가 실행.
                stsNowTime.Text = String.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            }
        }

        private void tsExit_Click(object sender, EventArgs e)
        {
            //종료 버튼 클릭 시
            //어플리케이션 종료
            Application.Exit();
        }

        private void M03_MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //프로그램을 종료 하시겠습니까?
            if (MessageBox.Show("프로그램을 종료 하시겠습니까?","프로그램 종료",
                MessageBoxButtons.YesNo)
                == DialogResult.No) e.Cancel = true;

            if (thNowTime.IsAlive) thNowTime.Abort();
        }


    }
}
