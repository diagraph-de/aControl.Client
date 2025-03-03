```markdown
# aControl.Client

aControl.Client is a .NET console application that connects to an aControl web service to retrieve printer information as well as connection and error statuses. This project demonstrates the use of Windows Communication Foundation (WCF) with Basic HTTP Binding and Basic Authentication.

## Table of Contents
- [Introduction](#introduction)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Usage](#usage)
- [Example Output](#example-output)
- [Configuration](#configuration)
- [Error Handling](#error-handling)
- [Contributing](#contributing)
- [License](#license)

## Introduction
The aControl.Client application connects to an aControl web service to:
- Retrieve the service version.
- Display a list of available printers (IDs and names).
- Prompt the user to select a printer.
- Retrieve the connection status and any error details for the selected printer.

## Prerequisites
- **.NET SDK:** .NET Core or .NET Framework, depending on your project setup.
- **Network Access:** Ensure you have access to the aControl web service (default URL: `http://192.168.174.141:8086/acontrol/webservice`).
- **Basic Knowledge of C# and WCF:** Useful for modifying or extending the code.

## Installation
1. **Clone the repository:**
   ```bash
   git clone https://github.com/yourusername/aControl.Client.git
   ```
2. **Navigate to the project directory:**
   ```bash
   cd aControl.Client
   ```
3. **Build the project:**
   ```bash
   dotnet build
   ```

## Usage
1. **Run the application:**
   ```bash
   dotnet run
   ```
2. **Workflow:**
   - The application opens a connection to the configured aControl web service.
   - It retrieves and displays the current service version.
   - It lists all available printers (name and printer ID) in the console.
   - The user is prompted to enter the index of the desired printer.
   - The application attempts to connect to the selected printer and displays the connection status along with any error details.

## Example Output
Below is an example of what the output might look like when running the application:

```plaintext
Client opened successfully.
Retrieving version...
Version: 2025.1.28528-R CAL:100
Retrieving available printer IDs...
Available Printers:
0: Name = 9FB2D89F23B19A30E259D6F52BDE982C, PrinterID = NGT (COM1)
1: Name = 6AE7DBDEE0D357BCB4E8BADEB388BD1F, PrinterID = NGT2 (192.168.173.130)
2: Name = 5C7A52E89A3DFDE9936A8B3A2B27AE52, PrinterID = NGT4 (192.168.173.132)
3: Name = 0EC20BBBF99C77FDD59D953FA6858C84, PrinterID = NGT2 (192.168.173.80)
4: Name = 4E476BA3638685EC591DB06A8B2C587C, PrinterID = NGT8 (192.168.173.131)
5: Name = F932BFBC86FB58FCCDDC97A31A78C56B, PrinterID = XL5000 (192.168.173.57)
Please select the index of the printer you want to connect to: 1
Connecting to printer with PrinterID 'NGT2 (192.168.173.130)'...
Connection status: Connected
Connection established successfully.
Printer error status: 00
No error details found.
Press any key to exit...
```

## Configuration
- **Endpoint URL:**  
  The web service endpoint is hard-coded in the application:
  ```csharp
  DiagraphWebServiceClient.EndpointAddress = "http://192.168.174.141:8086/acontrol/webservice";
  ```
  Update this value if your web service URL changes.

- **Authentication Credentials:**  
  The default credentials are set as follows:
  ```csharp
  client.ClientCredentials.UserName.UserName = "diagraph";
  client.ClientCredentials.UserName.Password = "diagraph";
  ```
  Modify these values as needed to match your web service access credentials.

## Error Handling
- **No Printers Found:**  
  The application displays a message if no printers are available.
- **Connection Issues:**  
  Errors during connection or while retrieving the service version are output to the console.
- **Client Closure:**  
  The client is properly closed after use. In case of a faulted state, the client is aborted.

## Contributing
Contributions to this project are welcome!  
1. Fork the repository.
2. Create a new branch for your changes.
3. Submit a pull request.

For significant changes or questions, please open an issue to discuss your proposed modifications.

## License
This project is licensed under the MIT License – see the [LICENSE](LICENSE) file for details.
```