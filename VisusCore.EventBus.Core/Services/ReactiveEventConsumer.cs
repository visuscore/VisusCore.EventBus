using System;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;
using Tingle.EventBus;

namespace VisusCore.EventBus.Core.Services;

public class ReactiveEventConsumer<TEvent> : IEventConsumer<TEvent>, IDisposable
    where TEvent : class, new()
{
    private readonly Subject<TEvent> _subject = new();
    private bool _disposed;

    public IAsyncObservable<TEvent> Events => _subject.AsObservable().ToAsyncObservable();

    public Task ConsumeAsync(EventContext<TEvent> context, CancellationToken cancellationToken)
    {
        _subject.OnNext(context.Event);

        return Task.CompletedTask;
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                _subject.Dispose();
            }

            _disposed = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}
