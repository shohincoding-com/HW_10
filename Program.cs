using System;

namespace HW_10
{
    class Program
    {


         static void Main(string[] args)
         {

         
        ///////////////Task_2///////////////////


        /*{
            string ExpAccess = "shohin";
            string ProAccess = "guest";
            
            Console.WriteLine("Введите ключ доступа!");
            var KeyAccess = Console.ReadLine();

            DocumentWorker worker;
            if(KeyAccess == ExpAccess)
            {
                worker = new ExpertDocumentWorker();
            }
            else if(KeyAccess == ProAccess)
            {
                worker = new ProDocumentWorker();
            }
            else
            {
                worker = new DocumentWorker();
            }

            Console.WriteLine("Выбирайте нужную комманду!\nо/открыт\nр/редактировать\nс/сохранить");
            var command = Console.ReadLine();

            if(command == "о")
            {
                worker.OpenDoc();
            }
            else if(command == "р")
            {
                worker.EditDoc();
            }
            else if(command == "с")
            {
                worker.SaveDoc();
            }
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

        
    } */
    //////////////EndTask_2///////////////////
    
    //////////////Task_3///////////////////
    
    Console.WriteLine("Дайте пожалуйста команду!\n1. Play\n2. Paus\n3. Stop\n4. Record");
    var userCmd = Console.ReadLine();

    
    }

    }

    interface IPlayable
    {
        void Play()
        {

        }

        void Pause()
        {
            
        }

        void Stop()
        {
            
        }
    }

    interface IRecodable
    {

        void Record()
        {

        }

        void Pause()
        {
            
        }

        void Stop()
        {
            
        }

    }

    class Player : IPlayable, IRecodable
    {

        
        public void Play()
        {
            Console.WriteLine("PLAY - current note");
        }
        
        

        public void Pause()
        {
            Console.WriteLine("PAUSE - current note");
        }

        public void Stop()
        {
            Console.WriteLine("STOP - current note");
        }
        public void Record()
        {
            Console.WriteLine("RECORD - current note");
        }
    }
    //////////////EndTask_3///////////////////
}

