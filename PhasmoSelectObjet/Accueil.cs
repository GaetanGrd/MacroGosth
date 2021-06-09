using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.Configuration;


using System.Drawing.Imaging;
using System.Drawing;

namespace PhasmoSelectObjet
{



    public partial class PhasmoSelectObject : Form
    {
        public PhasmoSelectObject()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);


        //-------------------------------
        [DllImport("user32.dll", CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int UnhookWindowsHookEx(int idHook);

        [DllImport("user32.dll", CharSet = CharSet.Auto,
        CallingConvention = CallingConvention.StdCall, SetLastError = true)]
        private static extern int CallNextHookEx(
            int idHook,
            int nCode,
            int wParam,
            IntPtr lParam);

        [DllImport("user32")]
        private static extern int ToAscii(
            int uVirtKey,
            int uScanCode,
            byte[] lpbKeyState,
            byte[] lpwTransKey,
            int fuState);

        [DllImport("user32")]
        private static extern int GetKeyboardState(byte[] pbKeyState);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern short GetKeyState(int vKey);

        //Déclaration des Variable Global

        int sleep = Convert.ToInt32(ConfigurationManager.AppSettings["Delay"]);
        string NoVersion = "1.3.0";
        int ColG = 900;
        int ColD = 1440;
        int Itm1 = 355;
        int ecart = 30;


        //Fonction



        private enum WindowShowStyle : uint
        {
            Hide = 0,
            ShowNormal = 1,
            ShowMinimized = 2,
            ShowMaximized = 3,
            Maximize = 3,
            ShowNormalNoActivate = 4,
            Show = 5,
            Minimize = 6,
            ShowMinNoActivate = 7,
            ShowNoActivate = 8,
            Restore = 9,
            ShowDefault = 10,
            ForceMinimized = 11
        }

        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004
        }

        public void VerifProcess()
        {
            Process[] process = Process.GetProcessesByName("Phasmophobia");
            if (process != null && process.Length > 0)
            {
                BtnLaunchPhasmo.Text = "Fermer le jeux";
            }
            else
            {
                BtnLaunchPhasmo.Text = "Lancer le jeux";
            }
        }

        public void ClickObjet(int x, int y)
        {
            Cursor.Position = new System.Drawing.Point(x, y);
            mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
            mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);

            Thread.Sleep(sleep);
        }

        public List<int> serialisationListeObjet(string Player)
        {
            //Recupere la valeur du joueur selectionner dans app.config et coupe la chaine
            //pour remplir une liste des objet 

            string obj = ConfigurationManager.AppSettings[Player];
            List<int> ListeObjet = new List<int>();
            int start = 0;
            while (obj.Substring(start, 1) != ";")
            {
                int count = 0;
                while (obj.Substring(start + count, 1) != "," && (obj.Substring(start + count, 1) != ";"))
                {
                    count += 1;
                }
                if (obj.Substring(start, 1) != ",")
                {
                    ListeObjet.Add(Convert.ToInt16(obj.Substring(start, count)));
                    start += count;
                }
                else
                { start += 1; }
            }
            return ListeObjet;
        }


        //evenement et traitement
        private void PhasmoSelectObject_Load(object sender, EventArgs e)
        {

            //Affichage de la version
            LbVersion.Text = "Version : " + NoVersion;

            //Verification programme lancer ou non.
            VerifProcess();
        }

        private void Player_Click(object sender, EventArgs e)
        {
            String xPlayer = Convert.ToString(sender);
            int Player = Convert.ToInt16(xPlayer.Substring(xPlayer.Length - 1, 1));
            List<int> ListeObjet = serialisationListeObjet("J" + Player);
            int x;
            int y;
            int itemSelect;

            Process[] process = Process.GetProcessesByName("Phasmophobia");
            if (process != null && process.Length > 0)
            {

                bool result = ShowWindow(process[0].MainWindowHandle, WindowShowStyle.Minimize);
                bool result2 = ShowWindow(process[0].MainWindowHandle, WindowShowStyle.ShowMaximized);


                //Create a new bitmap.
                var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                               Screen.PrimaryScreen.Bounds.Height,
                                               PixelFormat.Format32bppArgb);

                // Create a graphics object from the bitmap.
                var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

                // Take the screenshot from the upper left corner to the right bottom corner.
                /*gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                                            Screen.PrimaryScreen.Bounds.Y,
                                            0,
                                            0,
                                            Screen.PrimaryScreen.Bounds.Size,
                                            CopyPixelOperation.SourceCopy);

                // Save the screenshot to the specified path that the user has chosen.
                bmpScreenshot.Save("Screenshot.png", ImageFormat.Png);
                */

                Thread.Sleep(1000);
                ClickObjet(1118, 722);

                foreach (int item in ListeObjet)
                {
                    if (item < 15)
                    {
                        x = ColG;
                        itemSelect = item;
                    }
                    else
                    {
                        x = ColD;
                        itemSelect = item - 15;
                    }

                    y = Itm1 + itemSelect * ecart;

                    ClickObjet(x, y);
                }
                for (int i = 0; i < 2; i++)
                {
                    ClickObjet(878, 832);
                }
            }
            else
            {
                MessageBox.Show("Erreur \"Phasmophobia\" n'est pas ouvert !!!!");
            }
        }

        private void BtnLaunchPhasmo_Click(object sender, EventArgs e)
        {
            Process[] process = Process.GetProcessesByName("Phasmophobia");
            if (process != null && process.Length > 0)
            {
                var processes = Process.GetProcessesByName("Phasmophobia");
                foreach (var process2 in processes)
                {
                    process2.Kill();
                    BtnLaunchPhasmo.Text = "Lancer le jeux";
                }
            }
            else
            {
                Process process2 = new Process();
                process2.StartInfo.UseShellExecute = true;
                process2.StartInfo.FileName = "steam://rungameid/739630";
                process2.Start();
                BtnLaunchPhasmo.Text = "Fermer le jeux";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnHelp_Click(object sender, EventArgs e)
        {
            

        }

        private void btnParam_Click(object sender, EventArgs e)
        {
            Parametre Parametre = new Parametre();
            Parametre.ShowDialog();
        }

        private void PhasmoSelectObject_Activated(object sender, EventArgs e)
        {
            sleep = Convert.ToInt32(ConfigurationManager.AppSettings["Delay"]);
        }


    }
}