# Blazor Localisation Setup Guide

# Index Page (`Index.razor`)

- **`@inject IStringLocalizer<Index> local`**: 
  - The `@inject` directive is used to inject services into a Blazor component.
  - `IStringLocalizer<Index>` is a service provided by ASP.NET Core for localization. It allows the component to access localized strings based on the current culture.
  - In this context, `local` is an instance of `IStringLocalizer` specifically for the `Index` component, which enables the component to retrieve localized strings defined in resource files.

# Main Layout (`MainLayout.razor`)

- **Choose Language Component**:
  - The `ChooseLanguage` component is added to the layout to facilitate language selection by users. It allows users to choose their preferred language, enabling dynamic language switching within the application.

# App Settings (`appsettings.json`)

- **`Cultures` Configuration**:
  - The `Cultures` section in the `appsettings.json` file defines the supported cultures and their corresponding display names. This configuration is used for setting up localization options.

# Program.cs

- **Service Configuration**:
  - Various services are added to the Blazor application using the `Add*` methods.
  - `AddRazorPages().AddViewLocalization()` adds Razor Pages with support for localization, enabling localization of Razor Page content.
  - `AddLocalization()` adds localization services to the application, allowing for the localization of UI elements and resources.
  - `AddSingleton(typeof(IStringLocalizer<>), typeof(StringLocalizer<>))` registers a string localizer service, enabling components to retrieve localized strings based on the specified type.
  - `AddPortableObjectLocalization(options => options.ResourcesPath = "Resources")` adds support for loading localization resources from portable object (PO) files located in the specified directory.

- **Localization Options**:
  - The `GetLocalizationOptions` method retrieves culture configurations from the app settings and creates `RequestLocalizationOptions`. These options are used to configure request localization for the application.

# Controller (`CultureController.cs`)

- **Language Switching**:
  - The `CultureController` includes an action method `setCulture` responsible for setting the culture cookie based on the user's language selection. This controller enables dynamic language switching within the application.

# Short Form Summary of the above step by step.

- **Localization**:
  - Services and components related to localization, such as `IStringLocalizer` and language switching functionality, are added to the application.
- **Layout and Structure**:
  - The `ChooseLanguage` component is added to the layout to enable users to select their preferred language.
- **Configuration**:
  - App settings are used to configure supported cultures and other application settings.
- **Service Configuration**:
  - Localization services, including string localizer services and support for loading resources from portable object files, are added to the application in `Program.cs`.
