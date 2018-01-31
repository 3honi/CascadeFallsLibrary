# Cascade Falls Library
The library application for the school "Cascade Falls" has the ability to allow students and teachers alike to log in, hold, and check out books. Using the application, it is also possible to see which books are due at what time, and to be able to find those books with a map.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408112121998737408/images.png?width=234&height=468)

# Table of Contents:

[Running the App](https://github.com/3honi/CascadeFallsLibrary#running-the-app)

[Browsing Books](https://github.com/3honi/CascadeFallsLibrary#browsing-books)

[Check Book Status and Due Dates](https://github.com/3honi/CascadeFallsLibrary#check-book-status-and-due-dates)

[Library Map](https://github.com/3honi/CascadeFallsLibrary#library-map)

[Account Registration and Login](https://github.com/3honi/CascadeFallsLibrary#account-registration--login)

[Social Media in the School Library](https://github.com/3honi/CascadeFallsLibrary#social-media-in-the-school-library)

[Bug Reporting](https://github.com/3honi/CascadeFallsLibrary#bug-reporting)

[C# and Multiplatform Support](https://github.com/3honi/CascadeFallsLibrary#c-and-multiplatform-support)

[Viewing Code](https://github.com/3honi/CascadeFallsLibrary#viewing-code)

[Building Code](https://github.com/3honi/CascadeFallsLibrary#building-code)

[Code Commenting](https://github.com/3honi/CascadeFallsLibrary#code-commenting)


# Running the App
To use the prebuilt apk, download the apk on an android device. Make sure that "Allow applications from foreign sources" is enabled and simply install it. Once installed, the application should open. To install on iPhone, download Xcode from your computer and transfer it through there.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408091124389904394/Screenshot_20180130-214602.png?width=234&height=468)

# Browsing Books
The Browsing page allows users to see what books are available, which allows them to either check them out or place a hold on them. Although there aren't many books in the application, further books can be easily added when using the app beyond demonstration.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408091123060572160/Screenshot_20180130-214646.png?width=234&height=468)

# Check Book Status and Due Dates
The Manage page allows users to see which books they have on hold and/or checked out. It also allows the users to see how many books are due, alongside the due dates.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408095379935199234/Screenshot_20180130-220515.png?width=234&height=468)

# Library Map
The Map page allows users to see where each book should be as well as other remedies they may need.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408091122447941633/Screenshot_20180130-214657.png?width=234&height=468)

# Account Registration & Login
The library requires its users to have an account in order to check out and hold books. By providing details, teachers and librarians can know which student has which book, making it easier to manage.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408091124389904394/Screenshot_20180130-214602.png?width=234&height=468)

![alt text](https://media.discordapp.net/attachments/380444132989992963/408093925748899840/Screenshot_20180130-215916.png?width=234&height=468)

There are various errors that may occur. If a user who is registering an account does not provide a username or password, the application will not allow registration. The same will apply if the user chooses a username which was already taken. If the login credentials are incorrect, the application will also reject the login.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408093925182799873/Screenshot_20180130-215918.png?width=234&height=468)

![alt text](https://media.discordapp.net/attachments/380444132989992963/408093925178605568/Screenshot_20180130-215929.png?width=234&height=468)

![alt text](https://media.discordapp.net/attachments/380444132989992963/408091122447941632/Screenshot_20180130-214623.png?width=234&height=468)

# Social Media in the School Library
The social media buttons below will redirect students and teachers to the respective social media website, where they can share their discoveries and see what their peers are reading.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408097053676273667/twitter.png?width=234&height=468)

![alt text](https://media.discordapp.net/attachments/380444132989992963/408097081769590808/goodreads.png?width=234&height=468)

# Bug Reporting
If there is a bug in the application, users have an easy time reporting it. The bug report button is on the bottom-right corner of the application

![alt text](https://media.discordapp.net/attachments/380444132989992963/408099240368275466/adasd.png?width=234&height=468)

# C# and Multiplatform Support
Cascade Falls Library is coded in C# using the Unity Engine. The Unity Engine supports many platforms including  iOS, Windows, and many more; this also means that the app can be built for iPhones, Windows, and many other devices. Only a pre-build apk file is provided for demonstration purposes.

# Viewing Code
In order to view the code, Visual Studio 2010 or higher, is recommended, but any IDE that can open .sln works. You will also need Unity support for Visual Studio, and Unity 2017.3x. However, if you do not have a program that can open .sln files, the most important files are:

manage.cs
books.cs
book.cs
login.cs

# Building Code
In order to build for android, ios, or other platforms, the Unity build package for that system is required.

# Code Commenting
The coding within the application is done 100% via C#, is easy to understand, and is commented in much detail.

```c#
        for (int x = 0; x < transform.childCount; x++) //Has to clear all of the books first before placing a new list
        {
            Destroy(transform.GetChild(x).gameObject);
        }
        for (int x = 0; x < bookinfo.Count-1; x++) //Takes information from the php file
        {
            string temp = (bookinfo[x].ToString());
            string a = temp.Split('`')[4];
            if (a == "1") //If the book is still available
            {
                CreateBookObject(x); //Add it to the list
            }
        }
```
