namespace River.Streaming
{

  public interface IStreamBuilder
  {
    IStreamBuilder AddChannel<T>(string name = null, int capacity = 0);
    IActorBuilder AddActor<T>(string name = null, string input = null, string output = null) where T : IActor;
    IStream Build();
  }
}