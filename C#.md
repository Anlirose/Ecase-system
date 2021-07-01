# Ecase-system
This is a windows based application. This application is designed for a health sector ecase system.

Current Technology
UWP, XAML ,C# - File contains xmal and cs files.
Programming Constructs
•	readable code, types, operators, expressions, statements, conversion :
•	classes :        Utils - MicrosoftPassportHelper.cs, Accounthelper.cs 
	         	         Models – Account.cs
                                      Views – employee.cs
•	events or exception handling: 	    View – Balance Leave.xaml.cs
UI Techniques
extensive XAML
•	grid or stack panel - 	 View – Balance Leave.xaml
•	relative panel - 	       View – Home.xaml (for Hamburger button)
•	split view or scroll viewer -       Views – Timesheet.Xaml (Scroll viewer)
            Views – Home.xmal (split view)
•	buttons, check box, radio button, combo box, list box, image, toggle button, toggle switch, time picker, calendar date picker, calendar view, fly out button, menu fly out, autosuggest box, slider, progress bar or progression ring - 	   View – LeaverequestForm.xaml
	   View – Client.xaml
      	    View – Home.xaml
Navigation
•	Frame -         View – Home.xaml
•	root frame or hamburger -        View – Home.xaml.cs
Design Technologies
styles, resource dictionaries or themes –      
Utils - MicrosoftPassportHelper.cs
using Windows.Security.Credentials; - Provides a centralised location for securely storing and managing your passcodes, passwords, and other identifying data.
Utils - Accounthelper.cs
using Windows.Storage; - Provides classes for managing files, folders, and application settings.
using System.Xml.Serialization; - Contains classes that are used to serialize objects into XML format documents or streams.
