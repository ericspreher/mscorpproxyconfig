# mscorpproxyconfig
Core code to provide a method for Microsoft-based configuration to connect to a corporate proxy.

## Introduction
By default, many Microsoft-based services directly communicate with outside resources and no not reference a proxy. Usually a proxy configuration can be introduced by modifying the coorsponding *.config file of the resource.

However, with certain corproate proxy configurations, certain authenication requirements cannot be introduced with basic configurations. In these use cases, a module can be compile and introduced into the *.config file.

## Implementation Instructions
In this specific example, the class include the username, password, and proxy endpoint. Replace these values for your proxy settings and compile to a ProxyAuthModule.dll file.

Next, edit the *.config file that will reference this proxy and include the following lines:
```html
<system.net>
  <defaultProxy>
   <module type="ProxyAuthModule.ProxyAuthModule, ProxyAuthModule />
  <defaultProxy/>
<system.net/>
```                
## Additional TODOs
1. Create a .config for input variables.
2. Password encyption.
