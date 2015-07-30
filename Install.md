# Install #
To install follow the easy steps listed below:

  * Download a package
  * Unpack and edit Config.vb (/admin/common/Config.vb)
```
Public Class Config
    ' ---------------------------------------------
    ' Your Site name "My Guestbook"
    ' SiteName = "My Guestbook"
    Public Const SiteName = "Winn Guestbook " + WinnGuestbook.Core.VersionIn

    ' ---------------------------------------------
    ' Your Install directory
    Public Const GuestBookURL = "http://localhost/guestbook/"

    ' ---------------------------------------------
    ' Google Analytics
    ' Start keeping track of your traffic!
    ' $GoogleAnalytics = 'UA-0202020-1';
    Public Const GoogleAnalytics = "none"
End Class
```
  * Correct connect string if needed in the Web.config file
  * Upload to your web server.
  * Visit the admin area (http://installPath/guestbook/admin/)
```
Login: admin
Password: Owner@1
```
  * Once logged in you now can use the guestbook!