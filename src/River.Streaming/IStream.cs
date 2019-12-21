using System.Threading;
using System.Threading.Tasks;

namespace River.Streaming
{
  public interface IStream
  {
    Task Run();
    Task TryStop(CancellationToken cancellationToken = default(CancellationToken));
    Task Kill(CancellationToken cancellationToken = default(CancellationToken));
  }
}