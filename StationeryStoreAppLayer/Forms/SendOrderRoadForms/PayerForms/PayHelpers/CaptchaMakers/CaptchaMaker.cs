using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStoreUILayer.Forms.SendOrderRoadForms.PayerForms.PayHelpers.CaptchaMakers
{
     public class CaptchaMaker:ICaptchaMaker
    {
        public string MakeCaptcha(PictureBox pictureBox,Random random)
        {
            Random rnd = random;
            string captchaCode;
            // تولید کد
            captchaCode = rnd.Next(10000, 99999).ToString(); // کد 5 رقمی

            // ساخت تصویر
            Bitmap bmp = new Bitmap(150, 50);
            Graphics g = Graphics.FromImage(bmp);

            g.Clear(Color.White);

            // فونت کپچا
            using (Font font = new Font("Arial", 24, FontStyle.Bold))
            {
                g.DrawString(captchaCode, font, Brushes.Black, 10, 5);
            }

            // اضافه کردن نویز (Noise)
            for (int i = 0; i < 30; i++)
            {
                int x = rnd.Next(bmp.Width);
                int y = rnd.Next(bmp.Height);
                bmp.SetPixel(x, y, Color.Gray);
            }

            // خطوط روی تصویر
            for (int i = 0; i < 3; i++)
            {
                Pen pen = new Pen(Color.LightGray, 2);
                g.DrawLine(pen, rnd.Next(0, bmp.Width), rnd.Next(0, bmp.Height),
                                rnd.Next(0, bmp.Width), rnd.Next(0, bmp.Height));
            }

            pictureBox.Image = bmp;
            return captchaCode;
        }

    }
}
