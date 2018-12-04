using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 时间
{
    public partial class Form1 : Form
    {
        public static bool canLock = false;
        public static string mima = "";
        public static bool isLock = false;
        public static DateTime lockTime;

        public static bool isInit1;
        public static bool isInit2;
        public static bool isInit3;
        public static bool isInit4;
        public static bool isInit5;
        public static bool isInit6;

        public static string tb1Str = "";
        public static string tb2Str = "";
        public static string tb3Str = "";
        public static string tb4Str = "";
        public static string tb5Str = "";
        public static string tb6Str = "";

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            InitForm();
            button15.Text = "锁定系统时间";
        }

        public void InitForm()
        {
            isInit1 = true;
            isInit2 = true;
            isInit3 = true;
            isInit4 = true;
            isInit5 = true;
            isInit6 = true;

            tB1.BackColor = Color.White;
            tB2.BackColor = Color.White;
            tB3.BackColor = Color.White;
            tB4.BackColor = Color.White;
            tB5.BackColor = Color.White;
            tB6.BackColor = Color.White;
        }

        public void LockForm()
        {
            tB1.Enabled = false;
            tB2.Enabled = false;
            tB3.Enabled = false;
            tB4.Enabled = false;
            tB5.Enabled = false;
            tB6.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button16.Enabled = false;
        }

        public void UnLockForm()
        {
            tB1.Enabled = true;
            tB2.Enabled = true;
            tB3.Enabled = true;
            tB4.Enabled = true;
            tB5.Enabled = true;
            tB6.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button16.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetLocalDateTime(DateTime.Now.AddYears(1));
            InitForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetTimeToForm(DateTime.Now);
        }

        public bool SetTimeToForm(DateTime dt)
        {
            try
            {
                if (isInit1)
                    tB1.Text = dt.ToString("yyyy");
                if (isInit2)
                    tB2.Text = dt.ToString("MM");
                if (isInit3)
                    tB3.Text = dt.ToString("dd");
                if (isInit4)
                    tB4.Text = dt.ToString("HH");
                if (isInit5)
                    tB5.Text = dt.ToString("mm");
                if (isInit6)
                    tB6.Text = dt.ToString("ss");
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DateTime GetTextTime()
        {
            DateTime dt = DateTime.Now;
            string timeStr = $"{tB1.Text.Trim()}-{tB2.Text.Trim()}-{tB3.Text.Trim()} {tB4.Text.Trim()}:{tB5.Text.Trim()}:{tB6.Text.Trim()}";
            if (DateTime.TryParse(timeStr, out dt))
                return dt;
            MessageBox.Show($"输入的时间有误：{timeStr}");
            return DateTime.MinValue;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            InitForm();
        }
        private void button14_Click(object sender, EventArgs e)
        {
            if ((!isInit1 && tb1Str != tB1.Text.Trim()) ||
                (!isInit2 && tb1Str != tB2.Text.Trim()) ||
                (!isInit3 && tb1Str != tB3.Text.Trim()) ||
                (!isInit4 && tb1Str != tB4.Text.Trim()) ||
                (!isInit5 && tb1Str != tB5.Text.Trim()) ||
                (!isInit6 && tb1Str != tB6.Text.Trim())
                )
            {
                DateTime dt = GetTextTime();
                if (dt != DateTime.MinValue)
                    SetLocalDateTime(dt);
            }
            else
            {
                MessageBox.Show("请先修改文本框的时间。");
            }
            InitForm();
        }

        private void tB1_Enter(object sender, EventArgs e)
        {
            if (isInit1)
            {
                tb1Str = tB1.Text.Trim();
                isInit1 = false;
            }
        }
        private void tB1_Leave(object sender, EventArgs e)
        {
            if (tb1Str != tB1.Text.Trim())
                tB1.BackColor = Color.Pink;
            else
                isInit1 = true;
        }
        private void tB2_Enter(object sender, EventArgs e)
        {
            if (isInit2)
            {
                tb2Str = tB2.Text.Trim();
                isInit2 = false;
            }
        }
        private void tB2_Leave(object sender, EventArgs e)
        {
            if (tb2Str != tB2.Text.Trim())
                tB2.BackColor = Color.Pink;
            else
                isInit2 = true;
        }
        private void tB3_Enter(object sender, EventArgs e)
        {
            if (isInit3)
            {
                tb3Str = tB3.Text.Trim();
                isInit3 = false;
            }
        }
        private void tB3_Leave(object sender, EventArgs e)
        {
            if (tb3Str != tB3.Text.Trim())
                tB3.BackColor = Color.Pink;
            else
                isInit3 = true;
        }
        private void tB4_Enter(object sender, EventArgs e)
        {
            if (isInit4)
            {
                tb4Str = tB4.Text.Trim();
                isInit4 = false;
            }
        }
        private void tB4_Leave(object sender, EventArgs e)
        {
            if (tb4Str != tB4.Text.Trim())
                tB4.BackColor = Color.Pink;
            else
                isInit4 = true;
        }
        private void tB5_Enter(object sender, EventArgs e)
        {
            if (isInit5)
            {
                tb5Str = tB5.Text.Trim();
                isInit5 = false;
            }
        }
        private void tB5_Leave(object sender, EventArgs e)
        {
            if (tb5Str != tB5.Text.Trim())
                tB5.BackColor = Color.Pink;
            else
                isInit5 = true;
        }
        private void tB6_Enter(object sender, EventArgs e)
        {
            if (isInit6)
            {
                tb6Str = tB6.Text.Trim();
                isInit6 = false;
            }
        }
        private void tB6_Leave(object sender, EventArgs e)
        {
            if (tb6Str != tB6.Text.Trim())
                tB6.BackColor = Color.Pink;
            else
                isInit6 = true;
        }


        [DllImport("kernel32.dll")]
        private static extern bool SetLocalTime(ref Systemtime time);

        [StructLayout(LayoutKind.Sequential)]
        private struct Systemtime
        {
            public short year;
            public short month;
            public short dayOfWeek;
            public short day;
            public short hour;
            public short minute;
            public short second;
            public short milliseconds;
        }

        /// <summary>
        /// 设置系统时间
        /// </summary>
        /// <param name="dt">需要设置的时间</param>
        /// <returns>返回系统时间设置状态，true为成功，false为失败</returns>
        public static bool SetLocalDateTime(DateTime dt)
        {
            Systemtime st;

            st.year = (short)dt.Year;
            st.month = (short)dt.Month;
            st.dayOfWeek = (short)dt.DayOfWeek;
            st.day = (short)dt.Day;
            st.hour = (short)dt.Hour;
            st.minute = (short)dt.Minute;
            st.second = (short)dt.Second;
            st.milliseconds = (short)dt.Millisecond;
            bool rt = SetLocalTime(ref st);
            return rt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetLocalDateTime(DateTime.Now.AddYears(-1));
            InitForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SetLocalDateTime(DateTime.Now.AddMonths(1));
            InitForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetLocalDateTime(DateTime.Now.AddMonths(-1));
            InitForm();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetLocalDateTime(DateTime.Now.AddDays(1));
            InitForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SetLocalDateTime(DateTime.Now.AddDays(-1));
            InitForm();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SetLocalDateTime(DateTime.Now.AddHours(1));
            InitForm();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SetLocalDateTime(DateTime.Now.AddHours(-1));
            InitForm();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetLocalDateTime(DateTime.Now.AddMinutes(1));
            InitForm();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SetLocalDateTime(DateTime.Now.AddMinutes(-1));
            InitForm();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SetLocalDateTime(DateTime.Now.AddSeconds(1));
            InitForm();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SetLocalDateTime(DateTime.Now.AddSeconds(-1));
            InitForm();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now - lockTime).TotalHours < 1 && (DateTime.Now - lockTime).TotalHours > -1)
            {
                lockTime = DateTime.Now;
            }
            else
            {
                DateTime dt = DateTime.Now;
                SetLocalDateTime(lockTime);
                MessageBox.Show($"注意，有人在{lockTime}试图修改系统时间为{dt}！");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == "锁定系统时间")
            {
                if (!canLock)
                {
                    Form2 myabout = new Form2();
                    if (myabout.ShowDialog() == DialogResult.OK)
                    {
                        myabout.Close();
                    }
                }
                if (canLock)
                {
                    lockTime = DateTime.Now;
                    timer2.Start();
                    button15.Text = "解锁系统时间";
                    LockForm();
                    InitForm();
                }
                else if(!string.IsNullOrWhiteSpace(mima))
                {
                    MessageBox.Show($"抱歉，密码错误！");
                }
            }
            else
            {
                UnLockForm();
                timer2.Stop();
                button15.Text = "锁定系统时间";
                InitForm();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DateTime dt = GetStandardTime();
            if(dt!= DateTime.MinValue)
                SetLocalDateTime(dt);
        }

        /// <summary>  
        /// [3]获取标准北京时间2 ,读取(xml)http://www.time.ac.cn/timeflash.asp?user=flash  
        /// </summary>  
        /// <returns></returns>  
        public DateTime GetStandardTime()
        {
            #region  文件格式  
            /// //<?xml version="1.0" encoding="GB2312" ?>               
            //- <ntsc>              
            //- <time>             
            //  <year>2011</year>          
            //  <month>7</month>          
            //  <day>10</day>            
            //  <Weekday />     
            //  <hour>19</hour>          
            //  <minite>45</minite>          
            //  <second>37</second>           
            //  <Millisecond />          
            //  </time>           
            //  </ntsc>      
            #endregion

            DateTime dt;
            WebRequest wrt = null;
            WebResponse wrp = null;
            try
            {
                wrt = WebRequest.Create("http://www.time.ac.cn/timeflash.asp?user=flash");
                wrt.Credentials = CredentialCache.DefaultCredentials;

                wrp = wrt.GetResponse();
                StreamReader sr = new StreamReader(wrp.GetResponseStream(), Encoding.UTF8);
                string html = sr.ReadToEnd();
                sr.Close();
                wrp.Close();

                //int yearIndex = html.IndexOf("<year>") ;  
                //int secondIndex = html.IndexOf("</second>");  
                //html = html.Substring(yearIndex, secondIndex - yearIndex);  
                html = html.Substring(51, 109);

                string[] s1 = html.Split(new char[2] { '<', '>' });
                string year = s1[2];
                string month = s1[6];
                string day = s1[10];
                string hour = s1[18];
                string minite = s1[22];
                string second = s1[26];

                dt = DateTime.Parse(year + "-" + month + "-" + day + " " + hour + ":" + minite + ":" + second);
            }
            catch (WebException)
            {
                MessageBox.Show("获取网络时间异常");
                return DateTime.MinValue;
            }
            catch (Exception)
            {
                MessageBox.Show("获取网络时间异常");
                return DateTime.MinValue;
            }
            finally
            {
                if (wrp != null)
                    wrp.Close();
                if (wrt != null)
                    wrt.Abort();
            }
            return dt;
        }
    }
}
