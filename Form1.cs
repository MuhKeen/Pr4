using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr4
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    double Factorial(double n)
    {
      double fac = 1;
      while (n>1)
      {
        fac = fac * n;
        n = n - 1;
      }
      return 0;
    }
    private void button1_Click(object sender, EventArgs e)
    {
      double GranicaSummy = Convert.ToDouble(textBox1.Text);
      double PredelProizvedenia = Convert.ToDouble(textBox1.Text);
      int SumOrPro = 0;
      if (radioButton2.Checked) SumOrPro  = 1;
      double Sum = 0, Izmenyaemaya, i;

      switch (SumOrPro)
      {
        case 0:
          Izmenyaemaya = (1 / (2 * i + Factorial(i)));
          while (Izmenyaemaya>=GranicaSummy 
          break;
        case 1:
          break;
        default:
          break;
      }
    }
  }
}
