using System.Threading.Tasks;

namespace Simcorp.Laboratory {
    public class TaskSMSProvider : SMSProvider {
        public TaskSMSProvider() {
            StartMessageTask();
        }

        private Task StartMessageTask() {
            return Task.Factory.StartNew(StartTimer);
        }
    }
}
