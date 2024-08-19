using System;
using System.Diagnostics; //��ž��ġ
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
            //�� ī��Ʈ ������Ʈ
            CountUpdate(sw_person.Elapsed, lb_person); //Elapsed: TimeSpan �Ӽ����� �ð�,��,�ʸ� ������

            if (sw_person.Elapsed.TotalSeconds >= 3)
            {
                label1.Text = "��ü ���� �Ϸ�";
                timer_person.Stop(); // �Ǵ� timer_person.Enabled = false;

                if (label2.Text != "������� ����")
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
                label1.Text = "��ü ���� ��";
            }
        }

        private void timer_three_Tick(object sender, EventArgs e)
        {
            CountUpdate(sw_three.Elapsed, lb_three);
            label2.Text = "3�ʰ� �� ������";

            if (sw_three.Elapsed.TotalSeconds >= 3)
            {
                timer_three.Stop();
                count_person = true; //��� ī��Ʈ T
                label2.Text = "�۵� �Ϸ�";
            }
        }

        private void timer_five_Tick(object sender, EventArgs e)
        {
            CountUpdate(sw_five.Elapsed, lb_five);
            label3.Text = "5�ʰ� �� ������";

            if (sw_five.Elapsed.TotalSeconds >= 5)
            {
                timer_five.Stop();
                label3.Text = "�۵� �Ϸ�";
                count_water = false;
            }
            else if (sw_five.Elapsed.TotalMinutes < 5)
            {
                //5�ʹ� ���θ� True��
                count_water = true;
            }
            //Ÿ�̸� 0��: False
            //����~5�� ����: True -> 5�ʹ��� ������ �߰��� IN�� �����ٸ� 3�ʹ��� ������� ���� 
            //5�� ����: False
        }

        //��� Ÿ�̸� ����
        public void StartPersonTimer()
        {
            sw_person.Restart();
            timer_person.Start(); //�Ǵ� timer_person.Enabled = true;
            count_person = false; //�ٽ� false�� �ʱ�ȭ ���Ѿ� ��
        }

        //5�ʹ� Ÿ�̸� ����
        private void StartFiveSecondTimer()
        {
            sw_five.Restart();
            timer_five.Start();
        }

        //�� �ؽ�Ʈ �ʱ�ȭ
        public void InitializeText()
        {
            lb_person.Text = "00";
            lb_three.Text = "00";
            lb_five.Text = "00";
            label1.Text = "-";
            label2.Text = "-";
            label3.Text = "-";
        }

        //���� �ߴ�
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

        //ī��Ʈ �� ������Ʈ
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
                label2.Text = "������� ����";
            }
        }

        private void btn_out_Click(object sender, EventArgs e)
        {
            if (count_person)
            {
                //��� ī��Ʈ�� �Ǿ����� 5�� �� ����
                StartFiveSecondTimer();
            }
            else if (!count_person)
            {
                //ī��Ʈ�� ���� �ʾ�����, 5�� ���� ������ �ʰ�, ���� �ʱ�ȭ ��Ű��. Ÿ�̸� ��� ���߱�
                StopAllTimers();
            }
        }


    }
}
