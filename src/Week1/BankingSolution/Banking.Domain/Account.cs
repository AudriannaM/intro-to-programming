namespace Banking.Domain;

public class Account
{
    private decimal _balance = 5000M;
    public void Deposit(TransactionValueTypes.Deposit amountToDeposit)
    {
        _balance += amountToDeposit;

    }
    public TransactionValueTypes GetBalance()
    {
        //Slime it (Gary Bernhardt)
        return _balance; //JFHIC - Just Hardcode It :)
    }

    //"Primitive Obsession" - 
    public void Withdraw(TransactionValueTypes amountToWithdraw)
    {
        GuardHasSufficientFunds(amountToWithdraw);

        _balance -= amountToWithdraw; //The important business

    }

    private void GuardHasSufficientFunds(decimal amountToWithdraw)
    {
        if (amountToWithdraw > _balance)
        {
            throw new OverdraftException();
        }
    }
}
