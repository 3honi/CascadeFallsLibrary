# Cascade Falls Library
The library application for the school "Cascade Falls" has the ability to allow students and teachers alike to log in, hold, and check out books. As well as see which books are due at what time, and to be able to find those books with a map. 

![alt text](https://media.discordapp.net/attachments/380444132989992963/408112121998737408/images.png?width=234&height=468)

# Running the App
To use the prebuilt apk, download the apk on an android device. Make sure that "Allow applications from foreign sources" is enabled and simply install it. Once installed, the application should open. To install on iPhone, download Xcode from your computer and transfer it through there.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408091124389904394/Screenshot_20180130-214602.png?width=234&height=468)

# Browsing Books
The Browsing page allows users to see what books are available. Which allows them to check them out or place a hold on them. Although there are not many books in the application, further books can be easily added when using the app beyond demonstration.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408091123060572160/Screenshot_20180130-214646.png?width=234&height=468)

# Check Book Status and Due Dates
The Manage page allows users to see which books they have on hold or checked out. It also allows the users to see a total number of books they have held/checked out and how many of them are due, alongside the due dates.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408095379935199234/Screenshot_20180130-220515.png?width=234&height=468)

# Library Map
The Map page allows users to see where each book may be as well as other remedies they may need.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408091122447941633/Screenshot_20180130-214657.png?width=234&height=468)

# Account Registration & Login
The library requires its users to have an account in order to check out and hold books. By providing details, teachers and librarians can know which student has which book, making it easier to manage.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408091124389904394/Screenshot_20180130-214602.png?width=234&height=468)

![alt text](https://media.discordapp.net/attachments/380444132989992963/408093925748899840/Screenshot_20180130-215916.png?width=234&height=468)

There are various errors that may occur. If a user who is registering an account does not provide a username or password, the application will not allow registration. Same applies if the user chooses a username which was already taken. If the login credentials are incorrect, the application will also reject the login.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408093925182799873/Screenshot_20180130-215918.png?width=234&height=468)

![alt text](https://media.discordapp.net/attachments/380444132989992963/408093925178605568/Screenshot_20180130-215929.png?width=234&height=468)

![alt text](https://media.discordapp.net/attachments/380444132989992963/408091122447941632/Screenshot_20180130-214623.png?width=234&height=468)

# Social Media in the School Library
The social media buttons below will redirect students and teachers to a social media website, where they can share their discoveries and see what their peers are reading.

![alt text](https://media.discordapp.net/attachments/380444132989992963/408097053676273667/twitter.png?width=234&height=468)

![alt text](https://media.discordapp.net/attachments/380444132989992963/408097081769590808/goodreads.png?width=234&height=468)

# Bug Reporting
If there is a bug in the application, users have an easy time reporting it. The bug report button is on the bottom-right corner of the application

![alt text](https://media.discordapp.net/attachments/380444132989992963/408099240368275466/adasd.png?width=234&height=468)

# Building, C#, and Multiplatform Support
Cascade Falls Library is coded in C# using the Unity Engine. The Unity Engine supports iOS, Windows, and much more. Which means the app can be built for iPhones, Windows, etc. Only a pre-build apk file is provided for demonstration purposes.

# Viewing Code
In order to view the code, Visual Studio 2010 or higher is required. As well as Unity support for Visual Studio, and Unity 2017.3x.

# Building Code
In order to build, android, and iOS support for visual studio is required. As well as the iOS, Android, or any other platform build packages for Unity.

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
