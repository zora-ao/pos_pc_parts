using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_pc_parts
{
    public partial class ProductCard : UserControl
    {

        public string ProductID { get; set; }

        public Image ProductImage
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }


        public string ProductName
        {
            get => lblName.Content;
            set => lblName.Content = value;
        }

        public decimal Price
        {
            get => decimal.Parse(lblPrice.Tag.ToString());
            set
            {
                lblPrice.Tag = value;
                lblPrice.Content = $"₱ {value:N2}";
            }
        }

        public int Quantity
        {
            get => int.Parse(lblQty.Tag.ToString());
            set
            {
                lblQty.Tag = value;
                lblQty.Content = $"Qty: {value}";
            }
        }

        public ProductCard()
        {
            InitializeComponent();

            pictureBox2.Click += (s, e) => this.OnClick(e);

        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            int radius = 15;
            var path = new GraphicsPath();
            path.StartFigure();


            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);


            path.AddArc(new Rectangle(Width - radius, 0, radius, radius), 270, 90);

            // Bottom-right corner
            path.AddArc(new Rectangle(Width - radius, Height - radius, radius, radius), 0, 90);

            // Bottom-left corner
            path.AddArc(new Rectangle(0, Height - radius, radius, radius), 90, 90);

            path.CloseFigure();
            this.Region = new Region(path);
        }




        private void cuiPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
