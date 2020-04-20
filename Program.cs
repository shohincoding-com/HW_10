using System;

namespace HW_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class DocumentWorker
    {
        public virtual void OpenDoc()
        {
            Console.WriteLine("Документ открыт");
        }

        public virtual void EditDoc()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }

        public virtual void SaveDoc()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDoc()
        {
            Console.WriteLine("Документ отредактирован");
        }
 
        public override void SaveDoc()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
 
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDoc()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
