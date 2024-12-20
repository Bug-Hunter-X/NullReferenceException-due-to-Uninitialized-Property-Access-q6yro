# NullReferenceException in C# due to Uninitialized Property Access

This repository demonstrates a common C# error: attempting to access a property before it has been initialized.  The `bug.cs` file contains the problematic code, which results in a `NullReferenceException` when `MyMethod` is called. The solution, provided in `bugSolution.cs`, addresses this by initializing the property appropriately.

This example highlights the importance of carefully considering object initialization in C# to avoid unexpected runtime errors.