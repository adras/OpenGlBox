The library is being tested using WPF. This allows for a userinterface which doesn't require
any additional components.

In order to initialize the openTk.Wpf control the following has to be done
in the constructor of the wpf element using it. Here, openTk is the OpenTk.Wpf.GLWpfControl

GLWpfControlSettings settings = new GLWpfControlSettings
{
	MajorVersion = 2,
	MinorVersion = 1,
};

openTk.Start(settings);
openTk.Render += OpenTk_Render;


