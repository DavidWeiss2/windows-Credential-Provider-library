
# windows-Credential-Provider-library
This repository will be updated with all the examples and links that I can find with relevant knowledge &amp; information about CP in MS Windows 7 up to version 10.
### v0.1.2
# Fast Breif
- Tile
# Links to CP Technical Reference, guides and articles
- [Dan Griffin - Create Custom Login Experiences With Credential Providers For Windows Vista](Dan%20Griffin%20-%20Create%20Custom%20Login%20Experiences%20With%20Credential%20Providers%20For%20Windows%20Vista.pdf)
- [Alun Jones - Starting to build your own Credential Provider](https://blogs.msmvps.com/alunj/2011/02/21/starting-to-build-your-own-credential-provider/)
- [Winlogon and Credential Providers - Microsoft summary page in the MSDN](https://msdn.microsoft.com/en-us/library/windows/desktop/bb648647(v=vs.85).aspx)
- [Credential Providers in Windows 10 - Microsoft Windows 10 summary page in the MSDN (still kind of a WIP)](https://msdn.microsoft.com/en-us/library/windows/desktop/mt158211(v=vs.85).aspx)
- [Credential Provider driven Windows Logon Experience - Microsoft Windows 10 technical reference](http://go.microsoft.com/fwlink/?LinkId=717287)
- [Credential Provider Framework Technical Reference - Microsoft Windows Vista technical reference](modwind.narod.ru/olderfiles/1/Credential_Provider_Technical_Reference.doc)
# Links to CP API - Windows 10
- [x] Are MUST to implement and
- [ ] are not, but adding functionality.

- [x] [ICredentialProvider interface](https://msdn.microsoft.com/en-us/library/windows/desktop/bb776042(v=vs.85).aspx) - In one word this is "IT".
- [x] [ICredentialProviderCredential interface](https://msdn.microsoft.com/en-us/library/windows/desktop/bb776029(v=vs.85).aspx) - Its a MUST if you want to provide a UI interaction.
- [ ] [ICredentialProviderCredential2 interface](https://msdn.microsoft.com/en-us/library/windows/desktop/hh706912(v=vs.85).aspx) - If you want your provider access option as a access an option in the user tile as an altarntive to the default ICredentialProviderCredential which will give you a new tile.  
- [ ] []()
- [ ] []()
- [ ] []()

# Links to CP code examples
###
- [My Micorsoft windows 8 improved example](Microsoft%20Credential%20prvider%20v2%20example%20-%20improved%20docs%20WIP)    `still WIP`
### On GitHub
 - [Windows 8 & 8.1 Sample by Microsoft](https://github.com/Microsoft/Windows-classic-samples/tree/master/Samples/CredentialProvider)`Start from here - if you have knowledge`
 - [Windows 7 Samples by Microsoft in one link](https://github.com/Microsoft/Windows-classic-samples/tree/3e987d98a074051dc9cd5c87431d162035f69a24/Samples/Win7Samples/security/credentialproviders)
 - [pGina](https://github.com/pgina/pgina)`Start from here - if you want to quick implement without to realy know whats going on. `
 - [MultiOneTimePassword](https://github.com/LastSquirrelIT/MultiOneTimePassword-CredentialProvider)
 - [multiOTPCredentialProvider](https://github.com/multiOTP/multiOTPCredentialProvider)
 - [MultiotpCPV2RDP](https://github.com/arcadejust/MultiotpCPV2RDP)
 - [multiOTP open source](https://github.com/multiOTP/multiotp)
 - [dxlogin](https://github.com/jwtab/dxlogin) `I recommand to look into this one for is well docommanded CP`
 - [Phaetto C# Credential Provider](https://github.com/phaetto/windows-credentials-provider)`Do notice that he didnt impelemt logon and worksation`
### Links from the web for download / view
 - [https://blogs.technet.microsoft.com/aho/2009/11/14/custom-credential-provider-for-password-reset/](https://blogs.technet.microsoft.com/aho/2009/11/14/custom-credential-provider-for-password-reset/)
 - [https://www.microsoft.com/en-us/download/details.aspx?id=4057](https://www.microsoft.com/en-us/download/details.aspx?id=4057)
 - [https://code.msdn.microsoft.com/windowsapps/V2-Credential-Provider-7549a730](https://code.msdn.microsoft.com/windowsapps/V2-Credential-Provider-7549a730)`its the same one as the windows 8 from above but without the update's.`
 - [https://msdn.microsoft.com/en-us/library/cc540483.aspx](https://msdn.microsoft.com/en-us/library/cc540483.aspx)
 - [Signature-based User Authentication ***PDF***](https://is.cuni.cz/webapps/zzp/download/120183949)`very useful`
