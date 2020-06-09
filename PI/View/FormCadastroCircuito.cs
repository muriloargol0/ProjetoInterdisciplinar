using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI.View
{
    public partial class FormCadastroCircuito : Form
    {
        private static bool _opened = false;
        public bool isOpened {
            get {
                return _opened;
            }

            set {
                _opened = true;
            } 
        }
        public FormCadastroCircuito()
        {
            InitializeComponent();
        }
    }
}
