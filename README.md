# SplitButton
A SplitButton and DropDownButton for Windows Forms written in C#, forked and improved from [Authoring Tools Framework (ATF) by Sony.](https://github.com/SonyWWS/ATF)

Overview
========
I have been looking for a free dropdown button for Windows Forms, and found nothing out there that suited my needs. You can find plenty of SplitButtons online (where you must click the right arrow for the menu to appear), but no dropdown buttons (clicking the entire button displays a menu).

So, after much searching, I stumbled across the [Authoring Tools Framework (ATF) by Sony](https://github.com/SonyWWS/ATF). They include a SplitButton control (but, again, no dropdown support). So, I have forked and modified their control to also include a DropDownButton mode.

Usage
=====

First, add the control to your form and set the ContextMenuStrip to the menu for displaying the dropdown.

By default, clicking the arrow on the button will display the menu. To enable dropdown support, either set the DropDownButton property to "true" in the designer or within code:
    
    mySplitButton.DropDownButton = true

Credits
=======
Copyright © 2014 Sony Computer Entertainment America LLC. See License.txt.

Copyright © 2017 Michael D. Corbett.
