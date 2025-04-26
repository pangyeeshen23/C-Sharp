using GenericsTutorial.TaskManagement.Interface;

namespace GenericsTutorial
{
    class TaskProcessor<TTask, TResult> where TTask : ITask<TResult>
    {
        private TTask _task;
        public TaskProcessor(TTask task)
        {
            _task = task;
        }

        public TResult Execute()
        {
            return _task.Perform();
        }
    }
}
