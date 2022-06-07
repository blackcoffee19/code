using System;
using System.Linq;
using CipherServices.Models;

namespace CipherServices.Data
{
    public class DbInitialize
    {
        public static void Initialize(MessageContext context)
        {
            context.Database.EnsureCreated();
            if(context.Messages.Any()){
                return;
            }
            var Messages = new Message[]
            {
                new Message { Text="dwwdfn"},
                new Message { Text="khoor"},
                new Message {Text="flwlchq"},
            };
            foreach (Message m in Messages)
            {
                context.Messages.Add(m);
            };
            context.SaveChanges();
        }   

    }
}