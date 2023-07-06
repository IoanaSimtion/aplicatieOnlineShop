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
    public partial class Cart : Form
    {
        private Panel pnlContainer;
        private Panel pnlHeader;
        private Panel pnlFooter;
        private Label titlu;
        public Cart()
        {
            InitializeComponent();
            setContainer();
            setHeader();
            setFooter();

        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        public void setHeader()
        {
            titlu = new Label();
            titlu.Text = "Cart";
            titlu.Location = new Point(850, 30);
            titlu.Size = new Size(300, 300);
            titlu.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            titlu.ForeColor = Color.White;

            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.LightSkyBlue;
            pnlHeader.Height = 94;

            pnlHeader.Controls.Add(titlu);
            this.Controls.Add(pnlHeader);
        }
        public void setFooter()
        {

            Button checkout = new Button();
            Button continueShopping = new Button();
            
            checkout.Text = "Cart";
            checkout.Location = new Point(1050, 30);
            checkout.Size = new Size(300, 300);
            checkout.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            checkout.ForeColor = Color.Black;

            continueShopping.Text = "Cart";
            continueShopping.Location = new Point(50, 30);
            continueShopping.Size = new Size(300, 300);
            continueShopping.Font = new Font("Century Gothic", 14, FontStyle.Bold);
            continueShopping.ForeColor = Color.Black;

            pnlFooter = new Panel();
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.BackColor = Color.LightSkyBlue;
            pnlFooter.Height = 94;

            pnlFooter.Controls.Add(checkout);
            pnlFooter.Controls.Add(continueShopping);
            this.Controls.Add(pnlFooter);
        }

        private void PopulateContainer(Panel container)
        {

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
