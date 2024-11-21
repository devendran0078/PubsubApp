using CommunityToolkit.Mvvm.Messaging.Messages;

namespace PubsubApp.Messages;

public class CounterMessage : ValueChangedMessage<int>
    {
        public CounterMessage(int value) : base(value)
        {
        }
    }
