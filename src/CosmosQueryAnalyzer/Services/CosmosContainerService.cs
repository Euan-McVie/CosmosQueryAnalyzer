using CosmosQueryAnalyzer.Models;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace CosmosQueryAnalyzer.Services;

internal class CosmosContainerService
{
    private BehaviorSubject<ConnectionState> _connectionState = new(ConnectionState.Disconnected); 
    
    internal IObservable<ConnectionState> ConnectionStateObservable => _connectionState.AsObservable();

    internal async Task Connect(string connectionString){
        _connectionState.OnNext(ConnectionState.Connecting);
        
        await Task.Delay(2000); 
        
        _connectionState.OnNext(ConnectionState.Connected);        
    }
}
