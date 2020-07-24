using System;
using System.Windows.Forms;

namespace LambdaForm
{
    public partial class Form1 : Form
    {
        /// Lambda expression is accualy an anonymous function with an anonymous delegate
        /// 
        /// 3 Parts:
        ///     *Parameter(s)
        ///     * =>  "goes to" operator"
        ///     * Expression or Statements
        ///     
        /// 
        ///      =>   -   lambda operator
        public Form1()
        {
            InitializeComponent();


            //"ClickMeButton_Click1" - is a delegate that points to : "ClickMeButton_Click" method when the "Click" event accursed
            //See ClickMeButton_Click below
            ClickMeButton.Click += ClickMeButton_Click1;


            //An anonumous method (no name)
            ClickMeButton.Click += delegate (object sender, EventArgs e)
            {
                MessageBox.Show("You clicked me anonymously");
            };


            //Lambda expression long way
            ClickMeButton.Click +=
                (object sender, EventArgs e) =>
            {
                MessageBox.Show("You clicked me without declaring a delegate");
            };



            //Lamda expression short wierd way
            // "s" = object  -   parameter
            // "e" = EventArgs
            // "=>" = go to operator
            ClickMeButton.Click += (s, e) => MessageBox.Show("ShortCuts!");



        }

        private void ClickMeButton_Click1(object sender, EventArgs e)
        {
            MessageBox.Show("You clicked me");
        }

    }
}
