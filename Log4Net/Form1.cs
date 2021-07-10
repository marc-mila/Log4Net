using log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log4Net
{
    public partial class Form1 : Form
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Form1));
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            try
            {
                logger.Info("this is an info message");
                logger.Debug("this is a debug message to debug variables");
                logger.Warn("this is a warn message");
                logger.Error("this is an error message");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message + " " + ex.StackTrace);
                //ex.Data
                //despues se haria el throw
            }
        }
    }
}
