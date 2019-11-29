# Description

When clicking the button (1), or any other control within the `Grid` (Image, TextBlock), the `Tapped` handler defined on `Grid` is being called. 

However when clicking outside of any controls (2) - anywhere on the *blank area*, the handler is not being called.
**Suprisingly, it is being called in the VS XAML designer**

![Runtime](/_images/exe.png)

![Runtime](/_images/vs.png)