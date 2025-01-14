namespace Concurrency;

public class BankAccount
{
    public BankAccount(string ownerName) => OwnerName = ownerName;
        
    public readonly string OwnerName;
    public long Rubles;
    public object bankLock;

    public override string ToString() => $"{OwnerName} has {Rubles} RUB";
}