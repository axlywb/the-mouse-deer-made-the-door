//Make sure to Import LD.
using LD;
using LD.Wallet;


//function which has an argument of type "LDManager"
  LDManager.onLDReady += LDReady;

private void LDReady(LDManager LD)
    {
        // Once LD is ready, you can do any steps like Login, Logout, Transactions etc.
        
        //To Login:
        LD.WalletAuth.ConnectWallet((wallet) =>
        {
            addressTxt.text = "Wallet Address: " + wallet.publicAddress;
            loginDateTxt.text = "Login Date: " + wallet.loginDate.ToString();
        });
        
        //To Logout:
        LD.WalletAuth.Logout();
    }

  
//Check if the user is logged in or not
   WalletData walletData = WalletData.TryLoadSavedWallet();
if (walletData.WalletConnected){
    // User is already logged in
}
else{
    // Ask user to login
}

//get the User's wallet address, if the user is logged in

petra Wallet Address = walletData.PublicAddress
Smart Account Address = walletData.SmartAccount

//Login directly
 LDManager.Instance.WalletAuth.ConnectWallet(loginUrl, (walletData) =>
{
    // Get all the user's wallet data from "walletData"
});

//Logout directly
 LDManager.Instance.WalletAuth.Logout();

