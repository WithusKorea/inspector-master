using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inspector
{
    public class MessageQueue
    {
        private static readonly MessageQueue instance = new MessageQueue();
        public static MessageQueue Instance { get { return instance; } }

        private ConcurrentQueue<string> _message = new ConcurrentQueue<string>();

        public void Enqueue(string msg)
        {
            _message.Enqueue($"{DateTime.Now:yyyy.MM.dd HH:mm:ss} - {msg}\n");
        }

        public bool IsEmpty()
        {
            return _message.IsEmpty;
        }

        public bool Dequeue(ref string message)
        {
            bool dqResult = _message.TryDequeue(out message);
            return dqResult;
        }
    }
}
