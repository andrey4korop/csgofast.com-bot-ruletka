using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;


namespace Бот_для_казино
{
    public partial class Form1 : Form
    {
        public  ColorOfPixel screen;

        // объявляем API 



        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);
        // глобальные переменные, в которых будут храниться координаты 
        static protected long totalPixels = 0;
        static protected int currX;
        static protected int currY;
        static protected int diffX;
        static protected int diffY;
        

        public Form1()
        {
            InitializeComponent();
             screen = new ColorOfPixel();

        }

        

        static public Bitmap bmp;



        private void button1_Click(object sender, EventArgs e)
        {
            
            label1.Text = screen.getColor(Convert.ToInt16(krugX.Text), Convert.ToInt16(krugY.Text)).R.ToString();
            label2.Text = screen.getColor(Convert.ToInt16(krugX.Text), Convert.ToInt16(krugY.Text)).G.ToString();
            label3.Text = screen.getColor(Convert.ToInt16(krugX.Text), Convert.ToInt16(krugY.Text)).B.ToString();
            //  timer2.Enabled = true;
           // log.Text = Http();

        }
        DateTime time;
        private void button2_Click(object sender, EventArgs e)
        {
            
            time = DateTime.Now;
            start = DateTime.Now;
            ttt();
            
            
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            Point defPnt = new Point();
            GetCursorPos(ref defPnt);
            textBox1.Text = "X = " + defPnt.X.ToString();
            textBox2.Text = "Y = " + defPnt.Y.ToString();
            label1.Text = screen.getColor(Convert.ToInt16(defPnt.X.ToString()), Convert.ToInt16(defPnt.Y.ToString())).R.ToString();
            label2.Text = screen.getColor(Convert.ToInt16(defPnt.X.ToString()), Convert.ToInt16(defPnt.Y.ToString())).G.ToString();
            label3.Text = screen.getColor(Convert.ToInt16(defPnt.X.ToString()), Convert.ToInt16(defPnt.Y.ToString())).B.ToString();


        }





        public string Http()
        {
            string ret = "";
            try
            {
                string uri = "http://google.com/";
                 HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                 request.Method = "GET";
                 HttpWebResponse respouse = request.GetResponse() as HttpWebResponse;
                 
                /*HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                request.AuthenticationLevel = AuthenticationLevel.None;
                CookieContainer cookies = new CookieContainer();
                request.CookieContainer = cookies;
                NetworkCredential myCred = new NetworkCredential("", "", "");
                CredentialCache myCache = new CredentialCache();
                myCache.Add(new Uri(uri), "Basic", myCred);
                request.Credentials = myCache;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;*/

                string enc = "utf-8";
                string ct = respouse.Headers["Content-Type"];
                int n = ct.IndexOf("charset =");
                if (n >= 0) enc = ct.Substring(n + 8);

                StreamReader stream = new StreamReader(respouse.GetResponseStream(), Encoding.GetEncoding(enc));


                ret = (string)stream.ReadLine();
                stream.Close();
                return ret;
            }
            catch
            {
                //trayicon.trayicon.ShowBalloonTip(1000, "Ninja Safe Internet", "Відсутнє з'єднання з Інтернетом", System.Windows.Forms.ToolTipIcon.Error);
                return ret;
            }

        }



        private const UInt32 MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const UInt32 MOUSEEVENTF_LEFTUP = 0x0004;
        [DllImport("user32.dll")]
        private static extern void mouse_event(UInt32 dwFlags, UInt32 dx, UInt32 dy, UInt32 dwData, IntPtr dwExtraInfo);

        private string colourcout="black";
        private bool win = true;
        //private string 

        public void ttt()//делаем ставку
        {
            if (Http() == "")
            {
                win = true;
                log.AppendText(DateTime.Now.ToString("T") + " Пропал интернет ");
                timer2.Enabled = true;

            }
            else
            {

                System.Threading.Thread.Sleep(8000);
                if (win)
                {
                    if (DateTime.Now.CompareTo(time.AddMinutes(Convert.ToInt16(minute.Text))) > 0)
                    {
                        SendKeys.Send("{F5}");
                        System.Threading.Thread.Sleep(7000);
                        time = DateTime.Now;

                    }
                }
                if (colourcout == "black") // проверка текущего цветам , черный
                {
                    colourcout = "red"; //меняем цвет на красный
                                        //this.Cursor = new Cursor(Cursor.Current.Handle);

                    setMoney(win);//функция установки ставки

                    Cursor.Position = new Point(Convert.ToInt16(redX.Text), Convert.ToInt16(redY.Text)); //нажимаем на красную кнопку
                    System.Threading.Thread.Sleep(500);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, (UInt32)Convert.ToInt32(redX.Text), (UInt32)Convert.ToInt16(redY.Text), 0, new IntPtr()); //нажимаем
                    System.Threading.Thread.Sleep(100);
                    mouse_event(MOUSEEVENTF_LEFTUP, (UInt32)Convert.ToInt16(redX.Text), (UInt32)Convert.ToInt16(redY.Text), 0, new IntPtr()); //отпускаем
                    timer3.Enabled = true; //включаем таймер
                                           // timer2.Enabled = false;
                }
                else // проверка текущего цветам , красный
                {
                    colourcout = "black"; //меняем цвет на чёрный
                                          // this.Cursor = new Cursor(Cursor.Current.Handle);

                    setMoney(win);//функция установки ставки

                    Cursor.Position = new Point(Convert.ToInt16(blackX.Text), Convert.ToInt16(blackY.Text)); //нажимаем на чёрную кнопку
                    System.Threading.Thread.Sleep(500);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, (UInt32)Convert.ToInt32(blackX.Text), (UInt32)Convert.ToInt16(blackY.Text), 0, new IntPtr()); //нажимаем
                    System.Threading.Thread.Sleep(100);
                    mouse_event(MOUSEEVENTF_LEFTUP, (UInt32)Convert.ToInt16(blackX.Text), (UInt32)Convert.ToInt16(blackY.Text), 0, new IntPtr()); //отпускаем
                    timer3.Enabled = true; //включаем таймер
                                           // timer2.Enabled = false;
                }


                /*
                this.Cursor = new Cursor(Cursor.Current.Handle);
                Cursor.Position = new Point(Convert.ToInt16(redX.Text), Convert.ToInt16(redY.Text));
                mouse_event(MOUSEEVENTF_LEFTDOWN, (UInt32)Convert.ToInt32(redX.Text), (UInt32)Convert.ToInt16(redY.Text), 0, new IntPtr());
                mouse_event(MOUSEEVENTF_LEFTUP, (UInt32)Convert.ToInt16(redX.Text), (UInt32)Convert.ToInt16(redY.Text), 0, new IntPtr());

        */
            }
        }
        public int money = 0;
        void setMoney(bool win)
        {
            if (win) //якщо выиграли ставку
            {
                Cursor.Position = new Point(Convert.ToInt16(korzinaX.Text), Convert.ToInt16(korzinaY.Text)); //очищаем поле, корзина
                System.Threading.Thread.Sleep(500);
                mouse_event(MOUSEEVENTF_LEFTDOWN, (UInt32)Convert.ToInt32(korzinaX.Text), (UInt32)Convert.ToInt16(korzinaY.Text), 0, new IntPtr()); //нажимаем
                System.Threading.Thread.Sleep(100);
                mouse_event(MOUSEEVENTF_LEFTUP, (UInt32)Convert.ToInt16(korzinaX.Text), (UInt32)Convert.ToInt16(korzinaY.Text), 0, new IntPtr()); //отпускаем
                System.Threading.Thread.Sleep(500);
                Cursor.Position = new Point(Convert.ToInt16(moneyX.Text), Convert.ToInt16(moneyY.Text)); //нажимаем на поле ввода сумы
                System.Threading.Thread.Sleep(500);
                mouse_event(MOUSEEVENTF_LEFTDOWN, (UInt32)Convert.ToInt32(moneyX.Text), (UInt32)Convert.ToInt16(moneyY.Text), 0, new IntPtr()); //нажимаем
                System.Threading.Thread.Sleep(100);
                mouse_event(MOUSEEVENTF_LEFTUP, (UInt32)Convert.ToInt16(moneyX.Text), (UInt32)Convert.ToInt16(moneyY.Text), 0, new IntPtr()); //отпускаем
                System.Threading.Thread.Sleep(500);
                SendKeys.Send("10"); //отсылаем число 10
                money = 10;
                System.Threading.Thread.Sleep(500);

            }
            else //якщо проебали
            {
                if (Convert.ToInt16(maxmoney.Text) > money*2)
                {
                    Cursor.Position = new Point(Convert.ToInt16(money2X.Text), Convert.ToInt16(money2Y.Text)); //нажимаем Х2
                    money *= 2;
                    System.Threading.Thread.Sleep(500);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, (UInt32)Convert.ToInt32(money2X.Text), (UInt32)Convert.ToInt16(money2Y.Text), 0, new IntPtr()); //нажимаем
                    System.Threading.Thread.Sleep(100);
                    mouse_event(MOUSEEVENTF_LEFTUP, (UInt32)Convert.ToInt16(money2X.Text), (UInt32)Convert.ToInt16(money2Y.Text), 0, new IntPtr()); //отпускаем
                }
                else
                {
                    Cursor.Position = new Point(Convert.ToInt16(korzinaX.Text), Convert.ToInt16(korzinaY.Text)); //очищаем поле, корзина
                    System.Threading.Thread.Sleep(500);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, (UInt32)Convert.ToInt32(korzinaX.Text), (UInt32)Convert.ToInt16(korzinaY.Text), 0, new IntPtr()); //нажимаем
                    System.Threading.Thread.Sleep(100);
                    mouse_event(MOUSEEVENTF_LEFTUP, (UInt32)Convert.ToInt16(korzinaX.Text), (UInt32)Convert.ToInt16(korzinaY.Text), 0, new IntPtr()); //отпускаем
                    System.Threading.Thread.Sleep(500);
                    Cursor.Position = new Point(Convert.ToInt16(moneyX.Text), Convert.ToInt16(moneyY.Text)); //нажимаем на поле ввода сумы
                    System.Threading.Thread.Sleep(500);
                    mouse_event(MOUSEEVENTF_LEFTDOWN, (UInt32)Convert.ToInt32(moneyX.Text), (UInt32)Convert.ToInt16(moneyY.Text), 0, new IntPtr()); //нажимаем
                    System.Threading.Thread.Sleep(100);
                    mouse_event(MOUSEEVENTF_LEFTUP, (UInt32)Convert.ToInt16(moneyX.Text), (UInt32)Convert.ToInt16(moneyY.Text), 0, new IntPtr()); //отпускаем
                    System.Threading.Thread.Sleep(500);
                    SendKeys.Send("10"); //отсылаем число 10
                    money = 10;
                    System.Threading.Thread.Sleep(500);
                }
            }
        }

        public byte r;
        public byte g;
        public byte b;
        public DateTime start;
        private void timer3_Tick(object sender, EventArgs e)
        {
            r = screen.getColor(Convert.ToInt16(krugX.Text), Convert.ToInt16(krugY.Text)).R;//определяем цвет
            g = screen.getColor(Convert.ToInt16(krugX.Text), Convert.ToInt16(krugY.Text)).G;
            b = screen.getColor(Convert.ToInt16(krugX.Text), Convert.ToInt16(krugY.Text)).B;
           
            //yellow
            if ((r == 246)&& (g == 228)&&(b == 68))
            {
            }
            //black2
            if ((r == 24) && (g == 35) && (b == 40))
            {
            }

            //red
            if ((r == 203) && (g == 46) && (b == 37))
            {
                start = DateTime.Now;
                if (colourcout == "red") //якщо был красный поставленый
                {
                    win = true; //мы вииграли
                    timer3.Enabled = false;//выключаем таймер
                    ttt();//делаем ставку

                }
                else
                {
                    win = false;//мы проебали
                    timer3.Enabled = false;
                    ttt();
                }

            }
            //black
            if ((r == 0) && (g == 0) && (b == 0))
            {
                start = DateTime.Now;
                if (colourcout == "black")
                {
                    win = true;
                    timer3.Enabled = false;
                    ttt();
                }
                else
                {
                    win = false;
                    timer3.Enabled = false;
                    ttt();
                }

            }
            //green
            if ((r == 67) && (g == 156) && (b == 68))
            {       //мы лохи)))
                start = DateTime.Now;
                win = false;
                timer3.Enabled = false;
                ttt();
            }
            if (DateTime.Now.CompareTo(start.AddSeconds(80)) > 0)
            {
                timer3.Enabled = false;
                if (Http() == "")
                {
                    win = true;
                    log.AppendText(DateTime.Now.ToString("T") + " Пропал интернет ");
                    timer2.Enabled = true;
                }
                else
                {
                    win = true;
                    SendKeys.Send("{F5}");
                    System.Threading.Thread.Sleep(7000);
                    time = DateTime.Now;
                    ttt();
                }
                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Http() != "")
            {
                SendKeys.Send("{F5}");
                System.Threading.Thread.Sleep(3000);
                time = DateTime.Now;
                timer2.Enabled = false;
                ttt();
                

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void redY_TextChanged(object sender, EventArgs e)
        {

        }
    }  
}
