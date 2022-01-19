// See https://aka.ms/new-console-template for more information
class program
{
    //anna wants new earrings for christmas 
    class Present
    {
        string name;
        string gift;
        public Present(string _name, string _gift)
        {
            name = _name;
            gift = _gift;

        }
        public string Name
        {
            get { return name; }
        }
        public string Gift
        {
            get { return gift; }
        }

    }
        static void Main(string[] args)
        {
            List<Present> mygifts = new List<Present>();
            string[] newgiftfromFile = GetDataFromFile();

        foreach (string line in newgiftfromFile)
            {
            string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            Present newGift = new Present(tempArray[0], tempArray[1]);
            mygifts.Add(newGift);
            }
            foreach (Present GiftsfromList in mygifts)
            {
                Console.WriteLine($" {GiftsfromList.Name} wants {GiftsfromList.Gift} for Christmas");
            }



        }
        public static void DisplayElementsFromArray(string[] someArray)
        {

            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()

                 {     
        
            string filepath = @"C:\Users\marti\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filepath);

            return dataFromFile;



                   }






    } 

