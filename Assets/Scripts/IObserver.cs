
public interface IObserver
{
    public void Execute(ISubject
    subject);
}
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

