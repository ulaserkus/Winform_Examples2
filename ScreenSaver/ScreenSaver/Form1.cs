using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSaver
{
    public partial class SS : Form
    {

        List<Image> BgImg = new List<Image>();
        List<BritPic> BritPics = new List<BritPic>();
        Random rand = new Random();

        class BritPic
        {
            public int PicNumber { get; set; }
            public float xCo { get; set; }
            public float yCo { get; set; }
            public float speed { get; set; }

        }

        public SS()
        {
            InitializeComponent();
        }

        private void SS_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }

        private void SS_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("pics");
            foreach (string img in images)
            {
                BgImg.Add(new Bitmap(img));
            }

            for (int i = 0; i <500 ; i++)
            {
                BritPic mp = new BritPic();
                mp.PicNumber =i % BgImg.Count();
                mp.xCo = rand.Next(0, Width);
                mp.yCo = rand.Next(0, Height);
                BritPics.Add(mp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        private void SS_Paint(object sender, PaintEventArgs e)
        {

            foreach (BritPic bp in BritPics)
            {


                e.Graphics.DrawImage(BgImg[bp.PicNumber], bp.xCo, bp.yCo) ;
                bp.xCo -= 2;
                if (bp.xCo < -250)
                {
                    bp.xCo = Width + rand.Next(20, 100);
                }
            }


        }
    }
}
