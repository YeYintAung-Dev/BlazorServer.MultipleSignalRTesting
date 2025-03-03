using BlazorServer.MultipleSignalRTesting.ConsoleApp;

Console.WriteLine("Starting SignarlR service");
Console.ReadKey();

SignalRService service =  new SignalRService();
await service.PushNotification();

Console.ReadKey();