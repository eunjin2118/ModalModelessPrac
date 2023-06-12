using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModalModelessPrac
{
    class CustomForm : Form
    {
        public CustomForm() {
            Text = "제목 글자";
        }

        private Button button1;
        private Button button2;

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(321, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CustomForm
            // 
            this.ClientSize = new System.Drawing.Size(536, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "CustomForm";
            this.ResumeLayout(false);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            form.Show();
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("내용");
            MessageBox.Show("내용", "제목");

            DialogResult result;
            do
            {
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel); 
            } while (result == DialogResult.Retry);
            if(result == DialogResult.Cancel)
            {
                MessageBox.Show("사용자가 취소하였습니다", "알림");
            }
        }
    }
}
