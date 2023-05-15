using System.Windows.Forms;

namespace StaticConstructors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyControl control = new MyControl();

            MyControl control1 = new MyControl();
        }
    }
}
