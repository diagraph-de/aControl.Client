using System.ServiceModel;

namespace aControl.Client;

internal class Program
{
    private static async Task Main(string[] args)
    {
        // Create the client to aControl WS-URL (see Settings->Server->Webservice), 
        DiagraphWebServiceClient.EndpointAddress = "http://192.168.174.141:8086/acontrol/webservice";

        var client = new DiagraphWebServiceClient(DiagraphWebServiceClient.EndpointConfiguration
            .BasicHttpBinding_IDiagraphWebService);

        // Configure the binding for Basic Authentication.
        if (client.Endpoint.Binding is BasicHttpBinding binding)
        {
            binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
        }

        client.ClientCredentials.UserName.UserName = "diagraph";
        client.ClientCredentials.UserName.Password = "diagraph";

        // Open the client.
        await client.OpenAsync();
        Console.WriteLine("Client opened successfully.");

        try
        {
            // Retrieve the version.
            Console.WriteLine("Retrieving version...");
            var version = await client.GetVersionAsync();

            if (string.IsNullOrEmpty(version))
            {
                Console.WriteLine("No version found.");
                return;
            }
            else
            {
                Console.WriteLine($"Version: {version}");
            }

            // Retrieve available printer IDs.
            Console.WriteLine("Retrieving available printer IDs...");
            var printers = await client.GetPrinterIDsAsync();

            if (printers == null || printers.Length == 0)
            {
                Console.WriteLine("No printers found.");
                return;
            }

            // Display the available printers. 
            Console.WriteLine("Available Printers:");
            for (var i = 0; i < printers.Length; i++)
                Console.WriteLine($"{i}: Name = {printers[i].Key}, PrinterID = {printers[i].Value}");

            // Ask the user to select the printer index.
            Console.Write("Please select the index of the printer you want to connect to: ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out var index) || index < 0 || index >= printers.Length)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            var selectedPrinter = printers[index];
            Console.WriteLine($"Connecting to printer with PrinterID '{selectedPrinter.Value}'...");

            // Connect to the selected printer using its PrinterID.
            var connected = await client.GetConnectionStatusAsync(selectedPrinter.Key);

            if (!connected)
                connected = await client.ConnectAsync(selectedPrinter.Key);

            Console.WriteLine($"Connection status: {(connected ? "Connected" : "Not Connected")}");

            if (connected)
            {
                Console.WriteLine("Connection established successfully.");


                // Retrieve printer error status.
                var errorStatus = await client.GetErrorStatusAsync(selectedPrinter.Key);
                Console.WriteLine($"Printer error status: {errorStatus}");

                // Retrieve printer error details.
                var errorDetails = await client.GetErrorDetailsAsync(selectedPrinter.Key);
                if (errorDetails != null && errorDetails.Length > 0)
                {
                    Console.WriteLine("Printer error details:");
                    foreach (var detail in errorDetails) Console.WriteLine($"- {detail}");
                }
                else
                {
                    Console.WriteLine("No error details found.");
                }
            }
            else
            {
                Console.WriteLine("Could not establish connection.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error calling web service: " + ex.Message);
        }
        finally
        {
            // Properly close the client.
            if (client.State == CommunicationState.Faulted)
                client.Abort();
            else
                await client.CloseAsync();
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}