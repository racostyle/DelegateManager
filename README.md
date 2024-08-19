# Action and Delegate Wrapper Classes

This project provides a set of wrapper classes for actions and functions, allowing for easy registration and invocation of delegates. These classes help manage the complexity of handling multiple delegate types in a clean and consistent manner.

## Features

- **WrappedAction**: Simplifies the registration and invocation of `Action` delegates with up to six parameters.
- **WrappedFunc**: Manages `Func` delegates, supporting up to five input parameters and one return type.
- **ManagerDelegate**: Provides an example of how to use the wrapper classes to manage and invoke actions within a manager class.

### Installation

1. Clone this repository to your local machine:
   ```bash
   git clone https://github.com/your-username/repository-name.git
   ```

2. Import the project into your Unity project or C# solution.

### Usage

#### Registering an Action

To register an action, use the `Register` method of the `WrappedAction` class.

```csharp
var wrappedAction = new ActionWrapperClasses.WrappedAction<string, string>();
wrappedAction.Register(MyActionMethod);

void MyActionMethod(string arg1, string arg2)
{
    // Your logic here
}
```

#### Invoking an Action

Once registered, you can invoke the action using the `Invoke` method.

```csharp
wrappedAction.Invoke("arg1", "arg2");
```

#### Using ManagerDelegate

The `ManagerDelegate` class demonstrates how to use the wrapper classes to manage actions within a manager.

```csharp
var manager = new Managers.ManagerDelegate();
manager.Example.Register(MyActionMethod);
```

### Files Overview

- **ActionWrapperClasses.cs**: Contains classes for wrapping `Action` delegates with varying numbers of parameters.
- **DelegateWrapperClasses.cs**: Contains classes for wrapping `Func` delegates, allowing for return types and multiple input parameters.
- **ManagerDelegate.cs**: Example class showing how to use the wrapped actions in a management scenario.

### Example

```csharp
// Example usage in a Manager class
var manager = new Managers.ManagerDelegate();
manager.Example.Register((arg1, arg2) => {
    //Method
});
```
