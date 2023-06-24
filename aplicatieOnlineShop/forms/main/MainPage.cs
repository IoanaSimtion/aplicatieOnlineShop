using aplicatieOnlineShop.forms.MainPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicatieOnlineShop.forms
{
    public partial class MainPage : Form
    {

        private Panel pnlContainer;
        private Panel pnlHeader;
        private Panel pnlHeader2;
        private Button menu;
        private Button cart;
        private ComboBox filtru;
        private Label produse;
        private Label titlu;
        public MainPage()
        {
            InitializeComponent();
            setContainer();
            setHeader2();
            setHeader();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }

        private void PopulateContainer(Panel container)
        {
            int x = 0, y = 80, k = 1;

            for (int i = 0; i < 6; i++)
            {
                Card card = new Card(container)
                {
                    Parent = container,
                    Location = new Point(x, y)
                };

                x += card.Width + 100;

                if (k == 3)
                {
                    x = 0;
                    y += card.Height + 80;

                    k = 1;
                }
                else
                {
                    k++;
                }
            }
        }

        private void setHeader()
        {

            titlu = new Label();
            titlu.Text = "Online shop";
            titlu.Location = new Point(this.Width / 2, 94 / 2);
            titlu.Size = new Size(100, 100);

            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.LightSkyBlue;
            pnlHeader.Height = 94;

            pnlHeader.Controls.Add(titlu);
            this.Controls.Add(pnlHeader);


        }


        private void setHeader2()
        {

            produse = new Label();
            produse.Text = "Produse";
            produse.Location = new Point(10, 15);

            pnlHeader2 = new Panel();
            pnlHeader2.Dock = DockStyle.Top;
            pnlHeader2.BackColor = Color.LightBlue;
            pnlHeader2.Height = 53;

            pnlHeader2.Controls.Add(produse);
            this.Controls.Add(pnlHeader2);
        }

        private void setContainer()
        {
            pnlContainer = new Panel();
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.BackColor = Color.LavenderBlush;
            pnlContainer.AutoScroll = true;
            PopulateContainer(pnlContainer);

            this.Controls.Add(pnlContainer);

        }
    }
}
