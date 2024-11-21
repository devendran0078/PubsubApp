using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using PubsubApp.Messages;
using PubsubApp;

namespace PubsubApp.ViewModels
{
    public partial class SubscriberViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _receivedCounter;

        public SubscriberViewModel()
        {
            // Register to receive messages
            WeakReferenceMessenger.Default.Register<CounterMessage>(this, (recipient, message) =>
            {
                ReceivedCounter = message.Value; // Update the property with the received value
            });
        }
    }
}

