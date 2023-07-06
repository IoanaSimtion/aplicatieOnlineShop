using Application.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view.formsOnlineShop
{
    public partial class Main : Form
    {

        private Panel pnlContainer;
        private Panel pnlHeader;
        private Panel pnlHeader2;
        private Button menu;
        private ComboBox filtru;
        private Label produse;
        private Label titlu;
        public Main()
        {
            InitializeComponent();
            setContainer();
            setHeader2();
            setHeader();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        

        private void PopulateContainer(Panel container)
        {
            ProductService products = new ProductService();

            int x = 0, y = 80, k = 1;

            for (int i = 0; i < products.cardsNumber(); i++)
            {
                Cards card = new Cards(container, "sadd", "nume", 143, "descriperv ", "D:\\mycode\\icons\\download.png", 12)
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
            PictureBox cartIcon = new PictureBox();
            Label cart = new Label();

            cartIcon.Image = Image.FromFile("D:\\mycode\\icons\\cart.png");
            cartIcon.Location = new Point(1855, 20);
            cartIcon.SizeMode = PictureBoxSizeMode.Zoom;
            cartIcon.Size = new Size(52, 41);
            cartIcon.BackColor = Color.LightSkyBlue;

            cart.Text = "Cart";
            cart.Location = new Point(1857, 65);
            cart.Size = new Size(100, 100);
            cart.ForeColor = Color.White;
            cart.Font = new Font("Century Gothic", 10, FontStyle.Bold);

            titlu = new Label();
            titlu.Text = "Online shop";
            titlu.Location = new Point(850, 30);
            titlu.Size = new Size(300, 300);
            titlu.Font = new Font("Century Gothic", 18, FontStyle.Bold);
            titlu.ForeColor = Color.White;

            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.LightSkyBlue;
            pnlHeader.Height = 94;

            pnlHeader.Controls.Add(titlu);
            pnlHeader.Controls.Add(cartIcon);
            pnlHeader.Controls.Add(cart);
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
            pnlContainer.BackColor = Color.White;
            pnlContainer.AutoScroll = true;
            PopulateContainer(pnlContainer);

            this.Controls.Add(pnlContainer);

        }
    }
}
