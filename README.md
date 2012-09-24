Silverlight-Imagebutton
=======================

A simple imagebutton control for Silverlight 5 applications

The solution is in VS2012 format, but you could easily take the components and re-build it in any version, it's simple enough.

Note: This worked for me, you may have to make some changes. If you make improvements, just let me know :)

Components
==========

_Controls/ImageButton.cs_
The main control code, this is what you add to your XAML templates.

_Themes/Generic.xaml_
Every custom control must have a default template and this is where it has to live.

_Resources/Image.resx_
I normally store all my SL assets in resource files, this is a sample resource file with a couple of graphics - one for an on state button, one for an off. The images are also included in the Resources/Images folder.

Usage
=====

Once all the components are in place you can use it like so:

Add your namespace to your XAML header:

    xmlns:Controls="clr-namespace:SilverlightImageButton.Controls"

Add the control to your UI:
	
    <Controls:ImageButton x:Name="MyButton" />

And in the code behind you set the Off and On images like so:

    MyButton.OffImageSource = SilverlightImageButton.Resources.Images.LangEn_off;
    MyButton.OnImageSource = SilverlightImageButton.Resources.Images.LangEn_on;

If anyone can figure out how to set these properties from the .XAML, I'd be happy to hear from you :)