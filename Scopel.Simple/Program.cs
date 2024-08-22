using Scopel.Simple;

var scope = new MainScope();
var helloWorld = new HelloWordObject();
var message = new HelloWordMessage("Hello World");

await scope.AddObject(helloWorld);
await scope.SetupMessage(message);
await scope.Run();