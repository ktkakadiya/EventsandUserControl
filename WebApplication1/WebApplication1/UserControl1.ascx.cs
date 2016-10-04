using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public class MyEventArgs : EventArgs
    {
        public int square { get; set; }
    }
    public delegate void MyEventHandler(Object sender, MyEventArgs e);
    public partial class UserControl1 : System.Web.UI.UserControl
    {
        public event MyEventHandler myClick;
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MyEventArgs obj = new MyEventArgs() { square = Int32.Parse(TextBox1.Text) * Int32.Parse(TextBox1.Text) };
            myClick(this,obj);
        }

    }
}