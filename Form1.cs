using System;
using System.Diagnostics; //스탑워치
using System.Windows.Forms;

namespace Timer_0814
{
    public partial class Form1 : Form
    {
        private Stopwatch sw_person = new Stopwatch();
        private Stopwatch sw_three = new Stopwatch();
        private Stopwatch sw_five = new Stopwatch();

        public bool count_person = false;
        public bool count_water = false;

        public Form1()
        {
            InitializeComponent();

            timer_person.Interval = 1000;
            timer_person.Tick += timer_person_Tick;
            timer_person.Enabled = false;

            timer_three.Interval = 1000;
            timer_three.Tick += timer_three_Tick;
            timer_three.Enabled = false;

            timer_five.Interval = 1000;
            timer_five.Tick += timer_five_Tick;
            timer_five.Enabled = false;
        }

        private void timer_person_Tick(object sender, EventArgs e)
        {
            //초 카운트 업데이트
            CountUpdate(sw_person.Elapsed, lb_person); //Elapsed: TimeSpan 속성으로 시간,분,초를 가져옴

            if (sw_person.Elapsed.TotalSeconds >= 3)
            {
                label1.Text = "인체 감지 완료";
                timer_person.Stop(); // 또는 timer_person.Enabled = false;

                if (label2.Text != "실행되지 않음")
                {
                    sw_three.Restart();
                    timer_three.Start();
                }
                else
                {
                    count_person = true;
                }
            }
            else if (sw_person.Elapsed.TotalSeconds > 0)
            {
                label1.Text = "인체 감지 중";
            }
        }

        private void timer_three_Tick(object sender, EventArgs e)
        {
            CountUpdate(sw_three.Elapsed, lb_three);
            label2.Text = "3초간 물 내려옴";

            if (sw_three.Elapsed.TotalSeconds >= 3)
            {
                timer_three.Stop();
                count_person = true; //사람 카운트 T
                label2.Text = "작동 완료";
            }
        }

        private void timer_five_Tick(object sender, EventArgs e)
        {
            CountUpdate(sw_five.Elapsed, lb_five);
            label3.Text = "5초간 물 내려옴";

            if (sw_five.Elapsed.TotalSeconds >= 5)
            {
                timer_five.Stop();
                label3.Text = "작동 완료";
                count_water = false;
            }
            else if (sw_five.Elapsed.TotalMinutes < 5)
            {
                //5초물 여부를 True로
                count_water = true;
            }
            //타이머 0초: False
            //시작~5초 이전: True -> 5초물이 나오는 중간에 IN이 눌린다면 3초물은 실행되지 않음 
            //5초 이후: False
        }

        //사람 타이머 시작
        public void StartPersonTimer()
        {
            sw_person.Restart();
            timer_person.Start(); //또는 timer_person.Enabled = true;
            count_person = false; //다시 false로 초기화 시켜야 함
        }

        //5초물 타이머 시작
        private void StartFiveSecondTimer()
        {
            sw_five.Restart();
            timer_five.Start();
        }

        //라벨 텍스트 초기화
        public void InitializeText()
        {
            lb_person.Text = "00";
            lb_three.Text = "00";
            lb_five.Text = "00";
            label1.Text = "-";
            label2.Text = "-";
            label3.Text = "-";
        }

        //전부 중단
        public void StopAllTimers()
        {
            timer_person.Stop();
            timer_three.Stop();
            timer_five.Stop();

            sw_person.Stop();
            sw_three.Stop();
            sw_five.Stop();

            InitializeText();
        }

        //카운트 라벨 업데이트
        private void CountUpdate(TimeSpan elapsedTime, Label label)
        {
            label.Text = elapsedTime.ToString(@"ss");
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            StartPersonTimer();
            InitializeText();

            if (count_water)
            {
                label2.Text = "실행되지 않음";
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            if (count_person)
            {
                //사람 카운트가 되었으니 5초 물 실행
                StartFiveSecondTimer();
            }
            else if (!count_person)
            {
                //카운트가 되지 않았으니, 5초 물이 나오지 않고, 전부 초기화 시키기. 타이머 모두 멈추기
                StopAllTimers();
            }
        }


    }
}
