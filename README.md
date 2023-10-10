# windows-Credential-Provider-library
This repository will be updated with all the examples and links that I can find with relevant knowledge &amp; information about CP in MS Windows 7 up to version 10.
### v0.1.2
# Fast brief
Credential providers are the primary mechanism for user authentication—they currently are the only method for users to prove their identity which is required for logon and other system authentication scenarios. With Windows 10 and the introduction of Microsoft Passport, credential providers are more important than ever; they will be used for authentication into apps, websites, and more.
currently after you you can provide an authentication option for windows Logon-the login screen in the Image below. or a credential picker UI.

To learn more about the windows authentication proccess please read: [Sonny articale on medium](https://medium.com/@browninfosecguy/windows-authentication-and-attacks-101-part-a-dbe757f2f436)

![](https://github.com/DavidWeiss2/windows-Credential-Provider-library/blob/master/Login%20Screen.jpg)
- Left down is the "Tile" every user in MS Windows 10 have one, and a CP can have a tile too.
- Middle down is the "Credential-Providers" icons list. a user can select only one at a time. the fields shown are depended on this.
- The center middle is the provider field/s - this time a password field.
- The "I forgot my PIN" will be shown only for providers that support change password scenario. the text can be selected.
- The title below that will be shown if there are other available CP in this tile.
# Links to CP Technical Reference, guides, and articles
- [Dan Griffin - Create Custom Login Experiences With Credential Providers For Windows Vista](Dan%20Griffin%20-%20Create%20Custom%20Login%20Experiences%20With%20Credential%20Providers%20For%20Windows%20Vista.pdf)
- [Alun Jones - Starting to build your own Credential Provider](https://blogs.msmvps.com/alunj/2011/02/21/starting-to-build-your-own-credential-provider/)
- [Winlogon and Credential Providers - Microsoft summary page in the MSDN](https://msdn.microsoft.com/en-us/library/windows/desktop/bb648647(v=vs.85).aspx)
- [Credential Providers in Windows 10 - Microsoft Windows 10 summary page in the MSDN (still kind of a WIP)](https://msdn.microsoft.com/en-us/library/windows/desktop/mt158211(v=vs.85).aspx)
- [Credential Provider driven Windows Logon Experience - Microsoft Windows 10 technical reference](http://go.microsoft.com/fwlink/?LinkId=717287)
- [Credential Provider Framework Technical Reference - Microsoft Windows Vista technical reference](modwind.narod.ru/olderfiles/1/Credential_Provider_Technical_Reference.doc)
- [Creating Custom Windows Credential Providers in .NET - By Steve Syfuhs October 15, 2017](https://syfuhs.net/2017/10/15/creating-custom-windows-credential-providers-in-net/)
- [Random Musings About Windows Credential Providers and Authentication Packages - rileyg98](https://gist.github.com/rileyg98/228bed3040034be3b03f39aec8dbed72)
# Links to CP API - Windows 10
- [ICredentialProvider interface](https://msdn.microsoft.com/en-us/library/windows/desktop/bb776042(v=vs.85).aspx) - This is the CP, the other two are just UI.
- [ICredentialProviderCredential interface](https://msdn.microsoft.com/en-us/library/windows/desktop/bb776029(v=vs.85).aspx) - Its a MUST if you want to provide a UI interaction.
- [ICredentialProviderCredential2 interface](https://msdn.microsoft.com/en-us/library/windows/desktop/hh706912(v=vs.85).aspx) - If you want your provider to be listed under the user tile you MUST implement this, othewiwe you will gain you own tile.
# Links to CP code examples
###
- [My Micorsoft windows 8 improved example](Microsoft%20Credential%20prvider%20v2%20example%20-%20improved%20docs%20WIP)    `still WIP`
### On GitHub
 - [Windows 8 & 8.1 Sample by Microsoft](https://github.com/Microsoft/Windows-classic-samples/tree/master/Samples/CredentialProvider)`Start from here - if you have knowledge`
 - [Windows 7 Samples by Microsoft in one link](https://github.com/Microsoft/Windows-classic-samples/tree/3e987d98a074051dc9cd5c87431d162035f69a24/Samples/Win7Samples/security/credentialproviders)
 - [pGina](https://github.com/pgina/pgina)`Start from here - if you want to quick implement without to realy know whats going on. `
 - [pGina FORK](https://github.com/MutonUfoAI/pgina/)`The fork was created first simply because it's the way to contribute on Github. Later on due to time pressure and a refused pull request. Now the code differs so much that it's hard to merge it back again. `
 - [MultiOneTimePassword](https://github.com/LastSquirrelIT/MultiOneTimePassword-CredentialProvider)
 - [multiOTPCredentialProvider](https://github.com/multiOTP/multiOTPCredentialProvider)
 - [MultiotpCPV2RDP](https://github.com/arcadejust/MultiotpCPV2RDP)
 - [multiOTP open source](https://github.com/multiOTP/multiotp)
 - [dxlogin](https://github.com/jwtab/dxlogin) `I recommand to look into this one for is well docommanded CP`
 - [Phaetto C# Credential Provider](https://github.com/phaetto/windows-credentials-provider)`Do notice that he didnt impelemt logon and worksation`
### Links from the web for download / view
 - [https://blogs.technet.microsoft.com/aho/2009/11/14/custom-credential-provider-for-password-reset/](https://blogs.technet.microsoft.com/aho/2009/11/14/custom-credential-provider-for-password-reset/)
 - [https://www.microsoft.com/en-us/download/details.aspx?id=4057](https://www.microsoft.com/en-us/download/details.aspx?id=4057)
 - [https://code.msdn.microsoft.com/windowsapps/V2-Credential-Provider-7549a730](https://code.msdn.microsoft.com/windowsapps/V2-Credential-Provider-7549a730)`its the same one as the windows 8 from above but without the updates.`
 - [https://msdn.microsoft.com/en-us/library/cc540483.aspx](https://msdn.microsoft.com/en-us/library/cc540483.aspx)
 - [Signature-based User Authentication ***PDF***](https://dspace.cuni.cz/bitstream/handle/20.500.11956/62580/DPTX_2014_1_11320_0_392301_0_157676.pdf?sequence=1&isAllowed=y)`very useful`
### Background on the Windows Logon Process
- Yoni Avital presention - E2EVC 2015 [Diving into Windows Logon Process](https://www.youtube.com/watch?v=aCVdGUjP72Q)
