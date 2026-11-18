using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dekat_Kafe_New.Components
{
    public partial class PilihanPeran : UserControl
    {
        private string _title;
        private string _subtitle;
        private string _keyCode;

        public PilihanPeran()
        {
            InitializeComponent();
            _title = label1.Text;
        }

        [Category("Props")]
        [Description("Teks yang akan ditampilkan sebagai judul pilihan.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("Kasir")]
        public string Title
        {
            get { return _title; }
            set { 
                _title = value;
                label1.Text = value; 
            }
        }

        [Category("Props")]
        [Description("Teks yang akan ditampilkan sebagai subjudul pilihan.")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("Barista && Counter")]
        public string Subtitle
        {
            get { return _subtitle; }
            set { 
                _subtitle = value;
                label2.Text = value;
            }
        }

        [Category("Props")]
        [Description("Teks yang akan ditampilkan sebagai petunjuk shortcut keyboard")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue("F1")]
        public string KeyCode
        {
            get { return _keyCode; }
            set { 
                _keyCode = value;
                label3.Text = value; 
            }
        }

    }
}
