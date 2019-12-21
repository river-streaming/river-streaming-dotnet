namespace River.Streaming
{
  public interface IActorBuilder : IStreamBuilder
  {
    IActorBuilder WithChannel<T>();
  }
}