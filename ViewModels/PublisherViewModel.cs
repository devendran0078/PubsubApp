

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using PubsubApp.Messages;

namespace PubsubApp.ViewModels
{
    public partial class PublisherViewModel : ObservableObject
    {
        private int _counter;

        [RelayCommand]
        private void IncrementCounters()
        {
            
            _counter++;
            // Send a message to subscribers
            WeakReferenceMessenger.Default.Send(new CounterMessage(_counter));
        }
    }
}

