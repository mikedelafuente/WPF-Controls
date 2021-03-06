---
title: "Localization"
page-title: "Localization - Docking & MDI Layout, Globalization, and Accessibility Features"
order: 10
---
# Localization

All strings that are displayed in the user interface can be customized and localized. In addition, all user interface text properties have the `Localizability` attribute applied to them.

## Customizing String Resources

All strings that are displayed in the user interface are available from static methods on the `ActiproSoftware.Products.Docking.SR` class.  Use that class to customize string resources as well.

> [!NOTE]
> String resource customization is described in great detail in the general [Customizing String Resources](../../customizing-string-resources.md) topic.  Please see that topic for in-depth information related to localization of string resources.

An enumation named `SRName` includes a list of all the string resource names. A XAML markup extension named `SRExtension` is available for use within XAML templates to access string resources.

## Localizable Text Properties

The following text properties are flagged as localizable via the `Localizability` attribute:

- [DockingWindow](xref:ActiproSoftware.Windows.Controls.Docking.DockingWindow).[Description](xref:ActiproSoftware.Windows.Controls.Docking.DockingWindow.Description)

- [DockingWindow](xref:ActiproSoftware.Windows.Controls.Docking.DockingWindow).[TabText](xref:ActiproSoftware.Windows.Controls.Docking.DockingWindow.TabText)

- [DockingWindow](xref:ActiproSoftware.Windows.Controls.Docking.DockingWindow).[TabToolTip](xref:ActiproSoftware.Windows.Controls.Docking.DockingWindow.TabToolTip)

- [DockingWindow](xref:ActiproSoftware.Windows.Controls.Docking.DockingWindow).[Title](xref:ActiproSoftware.Windows.Controls.Docking.DockingWindow.Title)

- [DockingWindow](xref:ActiproSoftware.Windows.Controls.Docking.DockingWindow).[FloatingWindowTitle](xref:ActiproSoftware.Windows.Controls.Docking.DockSite.FloatingWindowTitle)

- [WindowControl](xref:ActiproSoftware.Windows.Controls.Docking.WindowControl).[Title](xref:ActiproSoftware.Windows.Controls.Docking.WindowControl.Title)
