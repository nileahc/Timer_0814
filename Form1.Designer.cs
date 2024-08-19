namespace Timer_0814
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btn_in = new Button();
            btn_out = new Button();
            lb_person = new Label();
            lb_three = new Label();
            lb_five = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            timer_person = new System.Windows.Forms.Timer(components);
            timer_three = new System.Windows.Forms.Timer(components);
            timer_five = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btn_in
            // 
            btn_in.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            btn_in.ForeColor = SystemColors.HotTrack;
            btn_in.Location = new Point(102, 77);
            btn_in.Name = "btn_in";
            btn_in.Size = new Size(186, 134);
            btn_in.TabIndex = 0;
            btn_in.Text = "IN";
            btn_in.UseVisualStyleBackColor = true;
            btn_in.Click += btn_in_Click;
            // 
            // btn_out
            // 
            btn_out.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            btn_out.ForeColor = SystemColors.HotTrack;
            btn_out.Location = new Point(102, 245);
            btn_out.Name = "btn_out";
            btn_out.Size = new Size(186, 134);
            btn_out.TabIndex = 1;
            btn_out.Text = "OUT";
            btn_out.UseVisualStyleBackColor = true;
            btn_out.Click += btn_out_Click;
            // 
            // lb_person
            // 
            lb_person.AutoSize = true;
            lb_person.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            lb_person.ForeColor = SystemColors.HotTrack;
            lb_person.Location = new Point(360, 134);
            lb_person.Name = "lb_person";
            lb_person.Size = new Size(32, 25);
            lb_person.TabIndex = 2;
            lb_person.Text = "00";
            // 
            // lb_three
            // 
            lb_three.AutoSize = true;
            lb_three.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            lb_three.ForeColor = SystemColors.HotTrack;
            lb_three.Location = new Point(360, 222);
            lb_three.Name = "lb_three";
            lb_three.Size = new Size(32, 25);
            lb_three.TabIndex = 3;
            lb_three.Text = "00";
            // 
            // lb_five
            // 
            lb_five.AutoSize = true;
            lb_five.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            lb_five.ForeColor = SystemColors.HotTrack;
            lb_five.Location = new Point(360, 302);
            lb_five.Name = "lb_five";
            lb_five.Size = new Size(32, 25);
            lb_five.TabIndex = 4;
            lb_five.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(440, 134);
            label1.Name = "label1";
            label1.Size = new Size(19, 25);
            label1.TabIndex = 5;
            label1.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(440, 222);
            label2.Name = "label2";
            label2.Size = new Size(19, 25);
            label2.TabIndex = 6;
            label2.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(440, 302);
            label3.Name = "label3";
            label3.Size = new Size(19, 25);
            label3.TabIndex = 7;
            label3.Text = "-";
            // 
            // timer_person
            // 
            timer_person.Interval = 1000;
            timer_person.Tick += timer_person_Tick;
            // 
            // timer_three
            // 
            timer_three.Interval = 1000;
            timer_three.Tick += timer_three_Tick;
            // 
            // timer_five
            // 
            timer_five.Interval = 1000;
            timer_five.Tick += timer_five_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb_five);
            Controls.Add(lb_three);
            Controls.Add(lb_person);
            Controls.Add(btn_out);
            Controls.Add(btn_in);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_in;
        private Button btn_out;
        private Label lb_person;
        private Label lb_three;
        private Label lb_five;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer_person;
        private System.Windows.Forms.Timer timer_three;
        private System.Windows.Forms.Timer timer_five;
    }
}
