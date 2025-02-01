This is a test program for creating a new window in Avalonia UI.

## Steps for creating the code:
1. Create an MVVW application with "dotnet new avalonia.mvvm -o MyApp"
2. Duplicate the code of the MainWindow to create a SubWindow
3. Make the SubWindow open when the button in the MainWindow is pressed

## Test environment: 
1. Windows 11 .NET 8 (Avalonia ui Version 11.0.1)
2. Raspberry Pi Zero 2 W + Raspbian (Avalonia ui Version 11.0.1)


## Problems confirmed on Raspberry Pi
When opening a SubWindow, the background of the SubWindow temporarily becomes all black, and then the contents of the SubWindow are displayed.
I want to fix this, but I don't know how.
(The same phenomenon probably occurs on Windows 11. I think that Windows 11 is fast enough that it is not noticeable.)

Only MainWindow  
![P1080171](https://github.com/user-attachments/assets/89d36439-d5fa-4327-bf5c-b50692a92fa5)

SubWindow appeares, but contents are filled with black  
![P1080172](https://github.com/user-attachments/assets/68dfab36-9fa9-4689-a575-32cd046b8f1b)

SubWindow appears perfectly  
![P1080173](https://github.com/user-attachments/assets/d8540648-cecb-4de3-85dc-1190b83b0500)

