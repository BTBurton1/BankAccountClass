---------------------------------
# BankAccount Class Design
---------------------------------
## **UML Design**
---------------------------------
- accountId : int(private) -
- customerName : string (private) -
- balance : decimal (private) -
- transactions : List<string> (private) -
---------------------------------
+ AccountId : int { get; } (public) +
+ CustomerName : string { get; } (public) +
+ Balance : decimal { get; } (public) +
+ Transactions : List<string> { get; } (public) +
---------------------------------
+ BankAccount(customerName : string, initialBalance : decimal) (public) +
+ Deposit(amount : decimal) : void (public) +
+ Withdraw(amount : decimal) : void (public) +
+ DisplayAccountInfo() : void (public) +

------

## Test Cases

### **Success cases**
1. Create account with valid name and positive balance.
2. Deposit valid positive amount.
3. Withdraw valid amount within balance.
4. Transactions recorded correctly.

### **Failure cases**
1. Deposit negative or zero amount.
2. Withdraw more than balance.
3. Withdraw negative or zero.

------

## Output code:
![Screenshot](Screenshot_2025-09-24_202919.png)
