# PostmanCloneApp

This is a clone of Postman following a [tutorial by Tim Corey](https://youtu.be/FUqz2LF4BUs?si=2wWeoAd_z2yE5qKV). The tutorial walks through the **UI** and **Library** projects up to the point of sending a GET call and returning the results. The **AUI** project was built by me using Avalonia allowing for cross-platform UI with the same functionality.

## Technologies Used
- C#
- .NET 8
- WinForms
- HTTPClient
- AvaloniaUI

## PostmanCloneUI
A Windows Form based UI. Allows input of an API URL and to call it, returning the results or the error message if one occurs. 
![WinForms UI](Images/Screenshots/postman-win-form.png)

## PostmanCloneLibrary
The business logic is here providing a seperation of concerns. This makes it easy to spin up a new frontend using consistent logic. 

## PostmanCloneAUI
A cross-platform frontend using [AvaloniaUI](https://www.avaloniaui.net).
![Avalonia UI](Images/Screenshots/postman-avalonia.png)


## Future Updates
- Support for POST, PUT, PATCH commands
- Web UI
- Better UI Layout with Avalonia