using Events;

Console.WriteLine("Task: Events");
Console.WriteLine("============");

ProcessBusinessLogic process = new();
process.ProcessCompleted += bl_ProcessCompleted;

process.StartProcess();

static void bl_ProcessCompleted() {
    Console.WriteLine("Method Invoked");
}

Console.ReadLine();