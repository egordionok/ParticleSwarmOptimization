using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParticleSwarmOptimization.Forms
{
    public partial class DeveloperForm : Form
    {
        public DeveloperForm()
        {
            InitializeComponent();

            label1.Text = "Программу разработал студет Московского Авиационного Института(МАИ) " +
                "Института №8 \"Информационные технологии и прикладная математика\" " +
                "направления \"Прикладная математика\", группы М8О-209Б-19 " +
                "Гордионок Е.А.";

        }
    }
}
