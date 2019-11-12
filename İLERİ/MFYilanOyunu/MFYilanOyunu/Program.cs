using System;
using System.Threading;
using Microsoft.SPOT;
using Microsoft.SPOT.Presentation.Media;
using Microsoft.SPOT.Hardware;

namespace MFYilanOyunu
{
    public class Program
    {
        struct Pozisyon
        {
            public int x, y;
            public Pozisyon(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        enum Yonler
        {
            Yukari,
            Asagi,
            Saga,
            Sola
        }

        static Bitmap bmp = new Bitmap(320, 240);

        static Color beyaz = ColorUtility.ColorFromRGB(255, 255, 255);
        static Color kirmizi = ColorUtility.ColorFromRGB(255, 0, 0);
        static Color mavi = ColorUtility.ColorFromRGB(0, 0, 255);
        static Color cim = ColorUtility.ColorFromRGB(40, 180, 35);
        static Color arkaplan = ColorUtility.ColorFromRGB(0, 70, 0);

        static Font font1 = Resources.GetFont(Resources.FontResources.NinaB);
        static Font font2 = Resources.GetFont(Resources.FontResources.small);

        static Pozisyon[] yilanPozisyon = new Pozisyon[551];
        static Pozisyon yemPozisyon = new Pozisyon();

        static Yonler Yon;

        static Random rnd = new Random();

        static bool alanBosMu = true;
        static int puan, seviye, yilanUzunlugu;

        static Timer tmr;

        public static void YenidenBasla()
        {
            yilanPozisyon[0] = new Pozisyon(9, 9);
            yilanPozisyon[1] = new Pozisyon(8, 9);
            yilanPozisyon[2] = new Pozisyon(7, 9);
            yilanPozisyon[3] = new Pozisyon(6, 9);
            yilanUzunlugu = 4; puan = 0; seviye = 1;
            YemKoy();
            Yon = Yonler.Saga;
        }

        public static void Main()
        {
            #region Butonlar
            InterruptPort butonUst = new InterruptPort(Cpu.Pin.GPIO_Pin2, false,
                Port.ResistorMode.PullDown, Port.InterruptMode.InterruptEdgeHigh);
            InterruptPort butonAlt = new InterruptPort(Cpu.Pin.GPIO_Pin4, false,
                Port.ResistorMode.PullDown, Port.InterruptMode.InterruptEdgeHigh);
            InterruptPort butonSag = new InterruptPort(Cpu.Pin.GPIO_Pin1, false,
                Port.ResistorMode.PullDown, Port.InterruptMode.InterruptEdgeHigh);
            InterruptPort butonSol = new InterruptPort(Cpu.Pin.GPIO_Pin0, false,
                Port.ResistorMode.PullDown, Port.InterruptMode.InterruptEdgeHigh);
            InterruptPort butonOrta = new InterruptPort(Cpu.Pin.GPIO_Pin3, false,
                Port.ResistorMode.PullDown, Port.InterruptMode.InterruptEdgeHigh);

            butonUst.OnInterrupt += new NativeEventHandler(butonUst_OnInterrupt);
            butonAlt.OnInterrupt += new NativeEventHandler(butonAlt_OnInterrupt);
            butonSag.OnInterrupt += new NativeEventHandler(butonSag_OnInterrupt);
            butonSol.OnInterrupt += new NativeEventHandler(butonSol_OnInterrupt);
            butonOrta.OnInterrupt += new NativeEventHandler(butonOrta_OnInterrupt);
            #endregion

            YenidenBasla();

            tmr = new Timer(new TimerCallback(Oyna), null, 0, 200);

            Thread.Sleep(Timeout.Infinite);
        }

        #region Buton Olayları
        //Orta Buton
        static void butonOrta_OnInterrupt(uint data1, uint data2, DateTime time)
        {
            YenidenBasla();
        }

        //Sol Buton
        static void butonSol_OnInterrupt(uint data1, uint data2, DateTime time)
        {
            if (Yon != Yonler.Saga | yilanUzunlugu == 1) Yon = Yonler.Sola;
        }

        //Sag Buton
        static void butonSag_OnInterrupt(uint data1, uint data2, DateTime time)
        {
            if (Yon != Yonler.Sola | yilanUzunlugu == 1) Yon = Yonler.Saga;
        }

        //Alt Buton
        static void butonAlt_OnInterrupt(uint data1, uint data2, DateTime time)
        {
            if (Yon != Yonler.Yukari | yilanUzunlugu == 1) Yon = Yonler.Asagi;
        }

        //Ust Buton
        static void butonUst_OnInterrupt(uint data1, uint data2, DateTime time)
        {
            if (Yon != Yonler.Asagi | yilanUzunlugu == 1) Yon = Yonler.Yukari;
        }
        #endregion

        private static void Oyna(object sender)
        {
            Array.Copy(yilanPozisyon, 0, yilanPozisyon, 1, yilanUzunlugu);

            switch (Yon)
            {
                case Yonler.Yukari:
                    yilanPozisyon[0].y--;
                    break;
                case Yonler.Asagi:
                    yilanPozisyon[0].y++;
                    break;
                case Yonler.Saga:
                    yilanPozisyon[0].x++;
                    break;
                case Yonler.Sola:
                    yilanPozisyon[0].x--;
                    break;
                default:
                    break;
            }

            //Yılan sınırın dışına çıktıysa
            if (yilanPozisyon[0].x < 0 | yilanPozisyon[0].x > 28 |
                yilanPozisyon[0].y < 0 | yilanPozisyon[0].y > 18)
            {
                Thread.Sleep(2000); YenidenBasla();
            }

            //Yılan kendisine çarptıysa
            for (int i = 1; i < yilanUzunlugu; i++)
            {
                if (yilanPozisyon[0].x == yilanPozisyon[i].x &&
                    yilanPozisyon[0].y == yilanPozisyon[i].y)
                {
                    Thread.Sleep(2000); YenidenBasla();
                }
            }

            //Yılan yemi yediyse
            if (YemKontrol())
            {
                yilanUzunlugu++;
                puan += 10 * seviye;
                YemKoy();
            }

            YilanCiz();

            //Seviye ve hız kontrolü
            if (yilanUzunlugu > 50) { tmr.Change(0, 75); seviye = 6; }
            else if (yilanUzunlugu > 40) { tmr.Change(0, 100); seviye = 5; }
            else if (yilanUzunlugu > 30) { tmr.Change(0, 125); seviye = 4; }
            else if (yilanUzunlugu > 20) { tmr.Change(0, 150); seviye = 3; }
            else if (yilanUzunlugu > 10) { tmr.Change(0, 175); seviye = 2; }
        }

        //Dikdörtgen çizimi
        private static void DikdortgenCiz(int x, int y, int genislik, int yukseklik,
            Color cerceveRengi, Color icRenk)
        {
            bmp.DrawRectangle(cerceveRengi, 1, x, y, genislik, yukseklik, 0, 0, icRenk, 0, 0,
                icRenk, 0, 0, 256);
        }

        //Yılan parçası çizmimi
        private static void YilanParcaCiz(int x, int y)
        {
            bmp.DrawRectangle(beyaz, 1, x * 10 + 15, y * 10 + 35, 10, 10, 0, 0, kirmizi, 0, 0,
                kirmizi, 0, 0, 255);
        }

        //Yılanı birleştirip çizmek
        private static void YilanCiz()
        {
            //Arkaplan çiz
            DikdortgenCiz(0, 0, 320, 240, arkaplan, arkaplan);
            DikdortgenCiz(10, 30, 300, 200, beyaz, cim);

            //Yazıları çiz
            bmp.DrawText(".NET Micro Yilan", font1, beyaz, 10, 10);
            bmp.DrawText("Puan: " + puan.ToString(), font2, beyaz, 160, 13);
            bmp.DrawText("Seviye: " + seviye.ToString(), font2, beyaz, 260, 13);

            //Yem çiz
            bmp.DrawRectangle(beyaz, 1, yemPozisyon.x * 10 + 15, yemPozisyon.y * 10 + 35, 10, 10,
                0, 0, mavi, 0, 0, mavi, 0, 0, 255);

            //Yılanı birleştir ve çiz
            for (int i = 0; i < yilanUzunlugu; i++)
            {   
                YilanParcaCiz(yilanPozisyon[i].x, yilanPozisyon[i].y);
            }

            //Önbellekteki bitmap görüntüsünü ekrana yansıt
            bmp.Flush();
        }

        //Boş bir alana yem koymak
        private static void YemKoy()
        {
            do
            {
                yemPozisyon.x = rnd.Next(29);
                yemPozisyon.y = rnd.Next(19);
                //Yılanın uzunluğu boyunca konulan yemin boş alana gelip gelmediğinin kontrolü
                for (int i = 0; i < yilanUzunlugu; i++)
                {
                    if (yilanPozisyon[i].x == yemPozisyon.x && yilanPozisyon[i].y == yemPozisyon.y)
                        alanBosMu = false;
                    else
                        alanBosMu = true;
                }
            } while (!alanBosMu);          
        }

        //Yilanın baş kısmının yemi yediğinin kontrolü
        private static bool YemKontrol()
        {
            bool YediMi = false;
            if (yilanPozisyon[0].x == yemPozisyon.x && yilanPozisyon[0].y == yemPozisyon.y)
            {
                YediMi = true;
            }
            return YediMi;
        }
    }
}
