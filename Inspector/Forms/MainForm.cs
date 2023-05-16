using Inspector.Controllers;
using Inspector.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inspector.Forms
{
    public partial class MainForm : Form
    {        
        public MainForm()
        {
            InitializeComponent();
            this.ShowIcon = false;
            this.Text = Application.ProductName;

            #region
            // 시스템 콘솔 초기화
            panel_SystemMessage.Controls.Add(SystemConsole.Instance);
            #endregion
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageQueue.Instance.Enqueue("메인 화면 초기화 완료");
        }

        private void menuItem_InitBrowser_Click(object sender, EventArgs e)
        {
            BrowserController.Instance.InitializeBrowser();
        }

        private void menuItem_EXIT_Click(object sender, EventArgs e)
        {
            // TODO : 청소
            Environment.Exit(0);
        }        
    }
}
