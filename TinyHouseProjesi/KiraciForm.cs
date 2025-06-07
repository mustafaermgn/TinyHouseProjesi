using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyHouseProjesi
{
    public partial class KiraciForm : Form
    {
        private int kullaniciId;

        public KiraciForm(int kullaniciId)
        {
            InitializeComponent();
            this.kullaniciId = kullaniciId;

           
        }

        public KiraciForm()
        {
            InitializeComponent();
        }
    }
}
