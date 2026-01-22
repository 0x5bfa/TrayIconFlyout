<h1 align="center">Tray Icon Flyout</h1>
<p align="center">Empower your app with a flyout for its tray icon in WinUI 2/3.</p>

## Installing the package

You can consume this project via NuGet. Use NuGet Package Manager or run the following command in the Package Manager Console:

### UWP/WinUI 2

<a style="text-decoration:none" href="https://www.nuget.org/packages/0x5BFA.TrayIconFlyout.Uwp"><img src="https://img.shields.io/nuget/v/0x5BFA.TrayIconFlyout.Uwp" alt="NuGet badge" /></a>

```console
> dotnet add package 0x5BFA.TrayIconFlyout.Uwp --prerelease
```

### WindowsAppSDK/WinUI 3

<a style="text-decoration:none" href="https://www.nuget.org/packages/0x5BFA.TrayIconFlyout.WinUI"><img src="https://img.shields.io/nuget/v/0x5BFA.TrayIconFlyout.WinUI" alt="NuGet badge" /></a>

```console
> dotnet add package 0x5BFA.TrayIconFlyout.WinUI --prerelease
```

## Usage

There are two flyouts are available in this project. One is `TrayIconFlyout` for the Shell Flyout behavior, and the other is `TrayIconMenuFlyout` for the Context Menu behavior.

### TrayIconFlyout

```xml
<me:TrayIconFlyout x:Class="..." ... Width="360">

    <me:TrayIconFlyoutIsland Height="300">
        <!-- Put elements here -->
    </me:TrayIconFlyoutIsland>
    <me:TrayIconFlyoutIsland Height="300">
        <!-- Put elements here -->
    </me:TrayIconFlyoutIsland>

</me:TrayIconFlyout>
```

```cs
if (_trayIconFlyout.IsOpen)
    _trayIconFlyout.Hide();
else
    _trayIconFlyout.Show();
```

### TrayIconMeunFlyout

```xml
<me:TrayIconMenuFlyout x:Class="..." ...>

    <MenuFlyoutItem Text="Theme" />
    <MenuFlyoutItem Text="Language" />
    <MenuFlyoutItem Text="Settings" />

</me:TrayIconMenuFlyout>
```

```cs
if (_trayIconMenuFlyout.IsOpen)
    _trayIconMenuFlyout.Hide();

_trayIconMenuFlyout.Show(e.Point);
```

## Building from the source

1. Prerequisites
    - Windows 10 (Build 10.0.17763.0) onwards and Windows 11
    - Visual Studio 2022
    - .NET 9/10 SDK
2. Clone the repo
    ```console
    git clone https://github.com/0x5bfa/TrayIconFlyout.git
    ```
3. Open the solution
4. Build the solution

## Screenshot

https://github.com/user-attachments/assets/95a63647-1f96-4035-a65d-1b602112c4bf
