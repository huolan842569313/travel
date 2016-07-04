using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public int constvalue_height;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            constvalue_height = axMapControl1.Top;
            string path = @"H:\all_chendazhen\";
            string filename = @"all_chendazhen.shp";
            axMapControl1.AddShapeFile(path,filename);
            axMapControl1.Extent = axMapControl1.FullExtent;
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            axMapControl1.Width = this.Width;
            axMapControl1.Height = this.Height - constvalue_height;
        }
    }
}
