#ui-navigation-drawer

In the early days of modern mobile computing, there were challenges to present users with a set of menus with limited screen space. With mobile apps growing in complexity, mobile app developers begin to wonder how they can add more menus to the app, with shallow learning curve that will aid users in providing extended navigation while keeping the user experience pleasant when using the app. Comes the navigation drawer, originally custom-implemented in Facebook app, more mobile apps are drawing increasingly closer in incorporating the navigation drawer in their apps.

Nowadays, it's very common to see the navigation drawer in mobile apps and Google even decided to incorporate the navigation drawer in the standard Android SDK. This is the navigation pattern that most developers will want to use in their app, so, Crosslight has created a support in using the navigation drawer for Android and iOS apps. Crosslight provides several samples that incorprorates the navigation drawer pattern to help developers integrate the navigation drawer into their Crosslight-powered apps easily. To learn more about drawer navigation pattern in Crosslight, see [Drawer Navigation](http://developer.intersoftsolutions.com/display/crosslight/Drawer+Navigation).

![image](http://developer.intersoftsolutions.com/download/attachments/5148174/drawer-samples.png?version=2&modificationDate=1398825482827&api=v2)

#Supported Platforms

This sample works on the following platforms:

* iOS: iOS 8 and above
* Android: 4.0.3 and above (optimized for 5.0 and above)
* WinPhone: WinPhone 7
* WinStore: WinStore 8

This project requires Crosslight 5.0.5000.526 or higher. For more information, see [Crosslight 5.0 Release Notes](http://developer.intersoftsolutions.com/display/crosslight/Crosslight+5.0+Release+Notes).

#Project Structure

This directory contains 4 sub-projects:

## DrawerSamples

* DrawerSamples.Android.Material: Crosslight Android.Material project, works on phones and tablets.
* DrawerSamples.Core: Shared Portable Class Library project running Profile78.
* DrawerSamples.iOS: Crosslight iOS project, works on iPhones and iPad with Storyboard support.
* DrawerSamples.WinRT: Crosslight Windows Store 8 project.

## DrawerSamples.Facebook

* DrawerSamples.Facebook.Android.Material: Crosslight Android.Material project, works on phones and tablets.
* DrawerSamples.Core: Shared Portable Class Library project running Profile78.
* DrawerSamples.Facebook.iOS: Crosslight iOS project, works on iPhones and iPad with Storyboard support.
* DrawerSamples.Facebook.WinRT: Crosslight Windows Store 8 project.

## DrawerSamples.Translucent

* DrawerSamples.Translucent.Android.Material: Crosslight Android.Material project, works on phones and tablets.
* DrawerSamples.Core: Shared Portable Class Library project running Profile78.
* DrawerSamples.Translucent.iOS: Crosslight iOS project, works on iPhones and iPad with Storyboard support.
* DrawerSamples.Translucent.WinRT: Crosslight iOS project, works on iPhones and iPad with Storyboard support.

## DrawerSamples.Worthy

* DrawerSamples.Worthy.Android.Material: Crosslight Android.Material project, works on phones and tablets.
* DrawerSamples.Core: Shared Portable Class Library project running Profile78.
* DrawerSamples.Worthy.iOS: Crosslight iOS project, works on iPhones and iPad with Storyboard support.
* DrawerSamples.Worthy.WinRT: Windows Store 8 project.


#Features Overview

* DrawerSamples: Demonstrates the most basic usage of the drawer UI component with only the left drawer, with customizable menu appearance.
* DrawerSamples.Facebook: Demonstrates the most basic usage of the drawer UI component with only the right drawer, with customizable menu appearance and Facebook-themed navigation drawer.
* DrawerSamples.Translucent: Demonstrates the use of UIBlurView Class combined with the navigation drawer.
* DrawerSamples.Worthy: Demonstrates the use of the left and right navigation drawer with customizable content on each side.

#Features Highlight

This sample demonstrates various navigation drawer samples style, including the use of left and right drawer, combined with Facebook-themed drawers, translucent drawers and Worthy-app style drawers.

#Running the Sample

This sample is NuGet-enabled. For more information on restoring NuGet packages, check out this document: [Introduction to Crosslight NuGet Packages](http://developer.intersoftsolutions.com/display/crosslight/Introduction+to+Crosslight+NuGet+Packages#IntroductiontoCrosslightNuGetPackages-RestoringCrosslightPackages).

##Running on Mac
If you run this sample on Mac Xamarin Studio, all you have to do is just open the solution using Xamarin Studio and the NuGet packages will be restored automatically. Simply set one of the platform projects as start-up projects and run.

##Running on Windows
If you run this sample on Windows Visual Studio, right-click on the solution, then choose Restore NuGet packages. Wait until all the NuGet packages are restored, then simply set one of the platform projects as start-up projects and run.

#Relevant Links

* [Drawer Navigation](http://developer.intersoftsolutions.com/display/crosslight/Drawer+Navigation).

Copyright © Intersoft Solutions.