using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspector.Controllers
{
    public class BrowserController
    {
        private static readonly BrowserController instance = new BrowserController();
        public static BrowserController Instance { get { return instance; } }

        public void InitializeBrowser()
        {
            MessageQueue.Instance.Enqueue("브라우저 초기화");
        }
    }
}
