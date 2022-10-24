using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec2_Star
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {//取得列數
            int? rows = Getrows();
            if (rows.HasValue == false)
            {
                MessageBox.Show("請輸入列數");
                return;
            }
            //判斷列數
            if (rows.Value <= 0)
            {
                MessageBox.Show("列數不可小於零");
                return;
            }
            //生成三角形
            string satrs = GentraStars(rows.Value);

            //用TEXT呈現

            textBoxStart.Text = satrs;
            startLabel.Text = satrs;

        }

        private string GentraStars(int rows)
        {
            string reault = string.Empty;
            for (int i = 1; i <= rows; i++)
            {
                reault += new string('*', i) + "\r\n";
            }
            return reault;
        }

        private int? Getrows()
        {
            string input = textBoxsRows.Text;

            bool isInt = int.TryParse(input, out int rows);

            if (isInt)
            {
                return rows;
            }
            else
            {
                return null;
            }
        }

        private void midButton_Click(object sender, EventArgs e)
        {
            int? rows = Getrows();
            if (rows.HasValue == false)
            {
                MessageBox.Show("請輸入列數");
                return;
            }
            //判斷列數
            if (rows.Value <= 0)
            {
                MessageBox.Show("列數不可小於零");
                return;
            }
            //生成三角形
            string satrs = GentraStars2(rows.Value);

            //用TEXT呈現

            textBoxStart.Text = satrs;
            startLabel.Text = satrs;

        }

        private string GentraStars2(int rows)
        {
            string reault = string.Empty;
            for (int i = 1; i <= rows; i++)
            {
                reault += new string(' ',rows-i)+new string('*', i)+new string('*',i-1) + "\r\n";
            }
            return reault;
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            int? rows = Getrows();
            if (rows.HasValue == false)
            {
                MessageBox.Show("請輸入列數");
                return;
            }
            //判斷列數
            if (rows.Value <= 0)
            {
                MessageBox.Show("列數不可小於零");
                return;
            }
            //生成三角形
            string satrs = GentraStars3(rows.Value);

            //用TEXT呈現

            textBoxStart.Text = satrs;
            startLabel.Text = satrs;

        }

        private string GentraStars3(int rows)
        {
            string reault = string.Empty;
            for (int i = 1; i <= rows; i++)
            {
                reault += new string(' ', rows - i) + new string('*', i) + "\r\n";
            }
            return reault;
        }
    }
}
