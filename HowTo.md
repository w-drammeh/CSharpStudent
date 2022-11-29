# Init a console project

`dotnet new console [-o ProjectName]`

# Run

`dotnet run`

# Publish

`dotnet publish --configuration Release`

By default, the publishing process creates a framework-dependent deployment, which is a type of deployment where the published application runs on a machine that has the .NET runtime installed. To run the published app you can use the executable file or run the dotnet HelloWorld.dll command from a command prompt.

## Inspecting the released files

**HelloWorld.deps.json**

This is the application's runtime dependencies file. It defines the .NET components and the libraries (including the dynamic link library that contains your application) needed to run the app.

**HelloWorld.exe (HelloWorld on Linux, not created on macOS.)**

This is the framework-dependent executable version of the application. The file is operating-system-specific.

**HelloWorld.pdb (optional for deployment)**

This is the debug symbols file. You aren't required to deploy this file along with your application, although you should save it in the event that you need to debug the published version of your application.

**HelloWorld.runtimeconfig.json**

This is the application's runtime configuration file. It identifies the version of .NET that your application was built to run on. You can also add configuration options to it.

