using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inspector.UserControls
{
    public partial class SystemConsole : UserControl
    {
        private MessageQueue _Message => MessageQueue.Instance;

        private static readonly SystemConsole instance = new SystemConsole();
        public static SystemConsole Instance { get { return instance; } }

        public SystemConsole()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            richTextBox1.Dock = DockStyle.Fill;
        }
        private void SystemConsole_Load(object sender, EventArgs e)
        {
            MessageQueue.Instance.Enqueue("시스템 콘솔 초기화 완료");
        }

        private void InterfaceTimer_Tick(object sender, EventArgs e)
        {
            while (!_Message.IsEmpty())
            {
                string message = string.Empty;
                bool dqResult = _Message.Dequeue(ref message);
                if (dqResult)
                {
                    if (string.IsNullOrEmpty(message))
                        continue;

                    richTextBox1.AppendText(message);
                    richTextBox1.ScrollToCaret();
                }
            }
        }
    }
}
