using System;

namespace dio_series
{
    class Program
    {
        static SeriesRepository seriesRepository = new SeriesRepository();
        static void Main(string[] args)
        { 
            int option;

            do{
                option = optionsMenu();
                switch(option){
                    case 1:
                        Console.Clear();
                        ListSeries();
                        Console.Read();
                        break;

                    case 2:
                        Console.Clear();
                        Insert();
                        Console.Read();
                        break;

                    case 3:
                        Console.Clear();
                        Update();
                        Console.Read();
                        break;

                    case 4:
                        Console.Clear();
                        Delete();
                        Console.Read();
                        break;

                    case 5:
                        Console.Clear();
                        Show();
                        Console.Read();
                        break;

                    case 0:
                        Console.Clear();
                        System.Console.WriteLine("Exiting program ...");
                        Console.Read();
                        break;

                    default:
                        System.Console.WriteLine("Invalid Option");
                        break;
                }
            }while(option!=0);
          
        }

        private static int optionsMenu(){        
            Console.Clear();
            System.Console.WriteLine("Choose a option");
            System.Console.WriteLine();
            System.Console.WriteLine("1 - List Series");
            System.Console.WriteLine("2 - Insert Series");
            System.Console.WriteLine("3 - Update Series");
            System.Console.WriteLine("4 - Delete Series");
            System.Console.WriteLine("5 - Show a Series");
            System.Console.WriteLine("0 - Exit");
            System.Console.WriteLine();

            int option=int.Parse(Console.ReadLine());
            return option;
        }

        private static void ListSeries(){
            System.Console.WriteLine("List of Series");
            var list = seriesRepository.List();
            if(list.Count ==0){
                System.Console.WriteLine("Empty List");
                return;
            }
            foreach(var serie in list){
                var deleted = serie.returnDeleted();
                System.Console.WriteLine($"Id: {serie.returnId()} Title: {serie.returnTitle()} Deleted: {deleted}");
            }
        }

        private static void Insert(){
            System.Console.WriteLine("Insert New Series");
            foreach(int i in Enum.GetValues(typeof(Genre)))
                System.Console.WriteLine("{0}-{1}",i,Enum.GetName(typeof(Genre),i));

            System.Console.WriteLine("Choose a genre");
            int genre=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Inform the title");
            string title=Console.ReadLine();

            System.Console.WriteLine("Inform the year");
            int year = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Inform the description");
            string description = Console.ReadLine();

            Series newSerie = new Series(id:seriesRepository.NextId(),
                                         genre: (Genre)genre,
                                         title: title,
                                         year:year,
                                         description:description);
            seriesRepository.Insert(newSerie);
            Console.Clear();
            System.Console.WriteLine("Serie added");
        }

        public static void Update(){
            System.Console.WriteLine("Inform the series id");
            int id=int.Parse(Console.ReadLine());
            foreach(int i in Enum.GetValues(typeof(Genre)))
                System.Console.WriteLine("{0}-{1}",i,Enum.GetName(typeof(Genre),i));

            System.Console.WriteLine("Choose a genre");
            int genre=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Inform the title");
            string title=Console.ReadLine();

            System.Console.WriteLine("Inform the year");
            int year = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Inform the description");
            string description = Console.ReadLine();

            Series updateSerie = new Series(id:id,
                                         genre: (Genre)genre,
                                         title: title,
                                         year:year,
                                         description:description);
            seriesRepository.Update(id,updateSerie);
            Console.Clear();
            System.Console.WriteLine("Series Updated");
        }

        private static void Delete(){
            System.Console.WriteLine("Inform the series id");
            int id=int.Parse(Console.ReadLine());
            seriesRepository.Delete(id);
            Console.Clear();
            System.Console.WriteLine("Series deleted");
        }

        private static void Show(){
            System.Console.WriteLine("Inform the series id");
            int id=int.Parse(Console.ReadLine());
            var serie = seriesRepository.ReturnById(id);
            System.Console.WriteLine(serie);
        }
    }
}
