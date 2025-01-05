# Running Python Scripts in WinForms Application

This VB.NET project enables the execution of Python scripts within a Windows Forms application, which is designed to
harness the flexibility and power of Python in conjunction with the user interface capabilities of WinForms. This 
project is a result of my ongoing practice and development efforts, and currently supports only the standard libraries 
of Python. Therefore, there is significant potential for expansion and enhancement - I plan to add more functionality 
as time and opportunities arise.

## Project Overview

Python scripts for this application are stored in the "PyScripts" folder, providing a centralized location for 
easy management and access.

## Python Main Function Specification

To ensure that the output from your Python scripts is properly captured and displayed by the WinForms application, 
the main function in your Python scripts must be defined according to the following guidelines:

### With Arguments

If your script is designed to accept arguments, the main function should take a `StringIO` object for output and
an optional list of arguments. The function should print to the `StringIO` object and return its contents.

```python
from io import StringIO


def main(output: StringIO, args: list = []) -> str:
    # Join arguments and print to output
    print(str().join(args), file=output)
    # Return the contents of the output buffer
    return output.getvalue()
```

### Without Arguments

If your script does not require arguments, the main function can be simplified to only accept a `StringIO` object.

```python
from io import StringIO


def main(output: StringIO) -> str:
    # Print a message to output
    print("Hello world!", file=output)
    # Return the contents of the output buffer
    return output.getvalue()
```

## How to Use

To use this project, simply place your Python scripts in the "PyScripts" folder, ensuring they adhere to the 
main function definitions provided. The WinForms application will execute your scripts and display their output.

## Contributing

While this project is currently a solo endeavor, I am open to collaboration. If you're interested in contributing, 
please reach out to discuss potential enhancements, bug fixes, or new features.

## License

This project is released under the [MIT License](LICENSE). Feel free to use, modify, and distribute this project, 
provided you comply with the terms of the license.
