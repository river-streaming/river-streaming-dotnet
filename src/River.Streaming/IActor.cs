using System.Threading;
using System.Threading.Tasks;

namespace River.Streaming
{
  public interface IActor
  {
    Task ExecuteAsync(CancellationToken cancellationToken = default(CancellationToken));
  }
}