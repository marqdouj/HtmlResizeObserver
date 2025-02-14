using Microsoft.JSInterop;

namespace Marqdouj.Html.ResizeObserver
{
    public class ResizeObserverService
    {
        private readonly Lazy<Task<IJSObjectReference>> moduleTask;
        private readonly DotNetObjectReference<ResizeObserverService>? dotNetRef;

        public ResizeObserverService(IJSRuntime jsRuntime)
        {
            moduleTask = new(() => jsRuntime.InvokeAsync<IJSObjectReference>(
                "import", "./_content/Marqdouj.Html.ResizeObserver/ts/js/resizeObserver.js").AsTask());
            dotNetRef = DotNetObjectReference.Create(this);
        }

        public async ValueTask Observe(string id)
        {
            var module = await moduleTask.Value;
            await module.InvokeAsync<string>("observe", id, dotNetRef);
        }

        public async ValueTask UnObserve(string id)
        {
            var module = await moduleTask.Value;
            await module.InvokeAsync<string>("unobserve", id);
        }

        public event Action<OnResizedArgs>? OnResize;

        [JSInvokable]
        public void OnResized(string id, double height, double width)
        {
            OnResize?.Invoke(new OnResizedArgs(id, height, width));
        }

        public async ValueTask DisposeAsync()
        {
            dotNetRef?.Dispose();

            if (moduleTask.IsValueCreated)
            {
                var module = await moduleTask.Value;
                await module.DisposeAsync();
            }
        }
    }
}
