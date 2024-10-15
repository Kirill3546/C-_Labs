
namespace Pz1.TaskSystem
{
    internal class TaskController
    {
        private InputController _inputController;
        private TasksChanger _tasksChanger;

        public TaskController()
        {
            _inputController = new InputController();
            _tasksChanger = new TasksChanger();
        }
        public void Start()
        {
            TaskType taskType = _inputController.Input();
            while (taskType != TaskType.Exit)
            {
                _tasksChanger.ChangeTask(taskType);
                Console.WriteLine("Press Enter to select another task");
                Console.ReadLine();
                taskType = _inputController.Input();

            }
        }
    }
}