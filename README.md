# mscorpproxyconfig
Core code to provide a method for Microsoft-based configuration to connect to a corporate proxy.

<h3>Introduction</h3>
<p>By default, many Microsoft-based services directly communicate with outside resources and no not reference a proxy.
 Usually a proxy configuration can be introduced by modifying the coorsponding *.config file of the resource.</p>
<p>However, with certain corproate proxy configurations, certain authenication requirements cannot be introduced with basic configurations.
 In these use cases, a module can be compile and introduced into the *.config file.</p>
 <h3>Implementation Instructions</h3>
 <p>In this specific example, the class include the username, password, and proxy endpoint. Replace these values for your proxy settings and compile to a ProxyAuthModule.dll file.</p>
 <p>Next, edit the *.config file that will reference this proxy and include the following lines:</p>
 <p>
 <system.net><br />
   <defaultProxy><br />
     <module type="ProxyAuthModule.ProxyAuthModule,  /><br />
   </defaultProxy/>
 </p>
