using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplicatieOnlineShop.forms.MainPage
{
    public class Card : Panel
    {

        private Panel pnlHeader;
        private Panel pnlContent;
        private Panel pnlPhoto;
        private LinkLabel titlu;
        private PictureBox pozaProdus;
        private TextBox descriere;
        private Button addCart;
        private TextBox pret;

        private void panelHeader()
        {
            titlu = new LinkLabel();
            titlu.Text = "Produs";
            titlu.Location = new Point(30, 10);

            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.BackColor = Color.LightBlue;
            pnlHeader.Size = new Size(50, 50);
            pnlHeader.Controls.Add(titlu);
            Controls.Add(pnlHeader);

        }

        private void panelPhoto()
        {
            pozaProdus = new PictureBox();
            pozaProdus.Width = 120;

            pnlPhoto = new Panel();
            pnlPhoto.Dock = DockStyle.Left;
            pnlPhoto.BackColor = Color.LightCyan;
            pnlPhoto.Width = 120;
            pnlPhoto.Controls.Add(pozaProdus);
            Controls.Add(pnlPhoto);
        }

        private void panelContent()
        {
            descriere = new TextBox();
            descriere.Text = "descriere produs";
            descriere.Multiline = true;
            descriere.Location = new Point(30, 20);
            descriere.Width = 325;
            descriere.Height = 200;

            addCart = new Button();
            addCart.Text = "Add to cart";
            addCart.Location = new Point(250, 280);
            addCart.Size = new Size(100, 40);
            //addCart.Dock = DockStyle.Left;
            addCart.BackColor = Color.White;

            pret = new TextBox();
            pret.Text = "pret produs";
            pret.Location = new Point(30, 285);

            pnlContent = new Panel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.Lavender;

            pnlContent.Controls.Add(descriere);
            pnlContent.Controls.Add(addCart);
            pnlContent.Controls.Add(pret);
            Controls.Add(pnlContent);
            pnlContent.BringToFront();
        }
        public Card(Panel panel)
        {
            this.Width = 560;
            this.Height = 400;
            panelHeader();
            panelPhoto();
            panelContent();
        }
    }
}
