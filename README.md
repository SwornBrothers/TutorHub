# TutorHub

**⚠️ This project should be archived. It is no longer maintained, has known, unresolved security issues, and relies on an outdated technology stack. Do not use it in its current state.**

## Overview

TutorHub is a Windows desktop application (WinForms) that connects students who need help with coursework to others who can help them. Students create a profile describing their educational background and skills, then post about the courses or topics they'd like help with. Other users can browse existing profiles and posts, and reach out to a student directly via a "Contact" action. The app also includes email functionality (via IMAP) and an in-progress Google account sign-up / Classroom integration.

## Prerequisites

- Visual Studio
- .NET Framework 4.5.2

## Setup

1. Clone the repository.
2. Open `TutorHub.sln` in Visual Studio and restore the NuGet packages the project depends on (`MetroModernUI`, `Newtonsoft.Json`, `S22.Imap`). Visual Studio will do this automatically on build if package restore is enabled, or you can trigger it manually via **Tools > NuGet Package Manager > Restore Packages**.
3. Attach the local database to a SQL Server instance: connect to your SQL Server instance and attach the `TutorHubDatabase.mdf` file at the repository root (its accompanying log file, `TutorHubDatabase_log.ldf`, will be attached alongside it).

## Configuration

`TutorHub/GoogleClass.cs` contains a hardcoded Google OAuth `clientID` and `clientSecret`. These are placeholder values and will not work for you — you must replace them with your own credentials from the Google API Console before the Google sign-up / Classroom feature will function.

## Running

Build and run the app from Visual Studio (e.g. press F5, or **Debug > Start Debugging**).

You can also build and run from the command line using a Developer Command Prompt for Visual Studio:

```
msbuild TutorHub.sln /p:Configuration=Debug
TutorHub\bin\Debug\TutorHub.exe
```

Note: the app currently opens the **Email** screen on startup instead of **Login** (see `TutorHub/Program.cs`). This appears to be a debug leftover rather than the intended startup flow.
