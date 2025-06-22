
public abstract class Logistics
{
    // Factory method
    public abstract ITransport CreateTransport();

    public void PlanDelivery()
    {
        ITransport transport = CreateTransport();
        transport.Deliver();
    }
}
