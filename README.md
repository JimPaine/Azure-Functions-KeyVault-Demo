# Azure Functions KeyVault Demo
A demo to show how you can how integrate KeyVault secrets directly into your app through appsettings using the new @Microsoft.KeyVault syntax

[![Deploy to Azure](http://azuredeploy.net/deploybutton.png)](https://azuredeploy.net/)

The team have added a great feature that allows secrets to be read from an Azure Key Vault and injected into your function through the Function App appsettings. This means you can now access and use Key Vault secrets without even needing to reference the KeyVault package.

## It is all in the wiring up.

You will see in both the Functions.csx and the index.js examples they are simply reading from the environment variables, so how is it happening?

If you take a look at the azuredeploy.json file you will notice a few key things:
- I have set the Function App to use [Managed Service Identity](https://github.com/JimPaine/Azure-Functions-KeyVault-Demo/blob/master/azuredeploy.json#L61-L63)
- I have setup an [access policy](https://github.com/JimPaine/Azure-Functions-KeyVault-Demo/blob/master/azuredeploy.json#L137-L160) to allow the Function app to read from the vault. It is important to note the policy is a seperate resource to the key vault, to remove the circular dependency with the Function App and KeyVault
- [Add the secrets to the vault](https://github.com/JimPaine/Azure-Functions-KeyVault-Demo/blob/master/azuredeploy.json#L161-L173)
- Then finally use the @Microsoft.KeyVault syntax within the [appsettings](https://github.com/JimPaine/Azure-Functions-KeyVault-Demo/blob/master/azuredeploy.json#L94-L97)

And that is it, you can now work locally without the worry of how to mock a managed service identity or keyvault and the code is also cleaner and easier to maintain
