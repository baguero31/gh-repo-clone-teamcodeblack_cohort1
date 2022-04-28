using System;

namespace WorkerClasses
{
    public interface IWorkerClass
    {
        void Clear(WorkerClass wc);
    }

    public class WorkerClass : IWorkerClass
    {
        public bool IsWorkable { get; set; }
        public string NameInfo { get; set; }
        public int IdIndicator { get; set; }

        public void Clear(WorkerClass wc)
        {
            wc.IsWorkable = false;
            wc.NameInfo = string.Empty;
            wc.IdIndicator = 0;
        }
    }
}
