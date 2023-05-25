namespace Events
{
    public delegate void PostEvents();
    public class ProcessBusinessLogic
    {
        public PostEvents ProcessCompleted;   
        public void StartProcess()
        {
            Console.WriteLine("Process Started!");
            Thread.Sleep(1500);
            OnProcessCompleted();
        }

        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}
