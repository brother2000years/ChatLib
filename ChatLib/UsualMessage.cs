using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatLib
{
    public enum Requests
    {
        NewMessage,
        CloseConnection
    }
    /// <summary>
    /// Обычное сообщение от пользователя к другим
    /// </summary>
    [Serializable]
    public class UsualMessage
    {
        public string Message { get; set; }
        public string Sender { get; set; }
        public UsualMessage() { }
        public UsualMessage(string message, string sender)
        {
            Message = message;
            Sender = sender;
        }
    }
}
