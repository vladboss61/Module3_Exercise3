using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppExample;

public partial class Form1 : Form
{
    public Form1()
    {
        MouseMove += (sender, args) =>
        {
            Debug.WriteLine(args.Location);
        };

        //MouseWheel += (sender, args) =>
        //{
        //    Debug.WriteLine(args.Location);
        //};

        InitializeComponent();
    }

    private void button1_Click(object sender, System.EventArgs e)
    {
        Thread.Sleep(5000);
        label1.Text = "Thread Click";
    }

    private async void button2_Click(object sender, System.EventArgs e)
    {
        await Task.Delay(5000);
        label1.Text = "Async Click";
    }
}
