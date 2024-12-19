# NullReferenceException in C# Property Access

This repository demonstrates a common C# error: a `NullReferenceException` that occurs when trying to access a property that hasn't been initialized.  The `bug.cs` file contains the problematic code, while `bugSolution.cs` provides a corrected version.

## Problem

The `MyProperty` property in `MyClass` is not explicitly initialized. If the `MyMethod` function is called before `MyProperty` is assigned a value, a `NullReferenceException` will be thrown when attempting to call `ToString()` on a null value.