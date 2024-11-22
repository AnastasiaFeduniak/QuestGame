using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Lab5
{
    public class UserConf
    {
        private static UserConf user = null;
        private string name { get; set; }
        private List<int> choices = [];
        private List<int> inventory = []; 
        public UserConf(string name)
        {
            this.name = name;
        }
        public UserConf() {
            if (user == null)
            {
                user = new UserConf("");
            }

        }

        public static UserConf Initialize(string name)
        {
            if (user == null)
            {
                user = new UserConf(name);
            }
            return user;
        }
        public static UserConf Initialize()
        {
            if (user == null)
            {
                user = new UserConf();
            }
            return user;
        }

        public void MainMenu()
        {
        
            
        }

        public void Story()
        {
            Console.Clear();
            const int windowWidth = 120;

            string[] inv = ["", "Cake", "Knife", "Pizza"];
            //string[] text = ["This story has not yet began...", "What do you expect to see?", "This is the end"];
            List<Replics> text = new List<Replics>();
            text.Add(new Replics(
                new Script(["", "", ""], ["It was a harsh day don't u think?", "Well I don't have a time for replics, so", "Continue?"], [0, 0, 0], 1),
                true,
                new InventoryGiver(0, 0),
                new MandatoryChoice([], [])
                ));
            text.Add(new Replics(
                new Script(["Name1", ""], ["Okay you've got something", "Here is your item"], [0, 0], 1),
                false,
                new InventoryGiver(2, 1),
                new MandatoryChoice([0], [0])
                ));
            text.Add(new Replics(
               new Script(["Name2", ""], ["Okay just another replic", "No item this time"], [0, 0], 2),
               false,
               new InventoryGiver(0, 0),
               new MandatoryChoice([0], [1])
               ));
            text.Add(new Replics(
               new Script([""], ["Control check"], [0], 1),
               true,
               new InventoryGiver(0, 0),
               new MandatoryChoice([], [])
               ));
            text.Add(new Replics(
               new Script(["User", "Admin"], ["Ouch it was painful!", "Carefully"], [0, 0], 1),
               false,
               new InventoryGiver(0, 0),
               new MandatoryChoice([1], [1])
               ));
            text.Add(new Replics(
               new Script(["", ""], ["Thanks", "Good luck!"], [0, 0], 2),
               false,
               new InventoryGiver(0, 0),
               new MandatoryChoice([], [])
               ));

            List<Choice> ch = new List<Choice>();
            ch.Add(new Choice(["Get item", "Move forward"], -1));
            ch.Add(new Choice(["Move", "Use knife"], 2));
            bool checkout = true;


            int index = 0;
            for (int j = 0; j < text.Count(); j++)
            {

                for (int i = 0; i < text[j].Length(); i++)
                {
                    if (!checkNeedness(text[j].getChoices())) { break; }
                    if (text[j].getItem().ItemId > 0) { inventory.Add(text[j].getItem().ItemId + 1); }
                    i = showConsole(text[j].getReplic(i), text[j].getName(i), i);
                }
                if (text[j].getNextChoice())
                {
                    int c = showConsole(ch[index]);
                    choices.Add(c - 1);
                    index++;
                }
            }
        }
        void what() { }
        public bool checkInventory(int[] a)
        {
            return a.All(item => inventory.Contains(item));
        }
        public int showConsole(string r, string n, int index)
        {
            const int windowWidth = 120;
            Console.Clear();
            Console.WriteLine("╔" + new string('═', windowWidth - 2) + "╗");
            Console.WriteLine("║" + n.PadRight(windowWidth - 6) + "║");
            Console.WriteLine("║" + new string('═', windowWidth - 2) + "║");
            Console.WriteLine("║  " + r.PadRight(windowWidth - 6) + "  ║");
            Console.WriteLine("║" + new string(' ', windowWidth - 2) + "║");

            // Draw bottom border
            Console.WriteLine("╚═" + " 1-Save ══ 2-Load ══ 3-Previous ══ 4-Menu " + new string('═', windowWidth - 45) + "╝");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int saveNumber) && saveNumber <= 4 && saveNumber >= 1)
            {
                switch (saveNumber)
                {
                    case 1: Save(); index--; break;
                    case 2: LoadMenu(); break;
                    case 3: if (index != 0) { index--; }; break;
                    case 4: AreYouSure(); break;
                    default: break;
                }
            }

            return index;
        }

        public int showConsole(Choice c)
        {
            const int windowWidth = 120;
            while (true)
            {

                Console.Clear();
                Console.WriteLine("╔" + new string('═', windowWidth - 2) + "╗");
                Console.WriteLine("║" + new string(' ', windowWidth - 2) + "║");
                for (int i = 0; i < c.getChoices().Count(); i++)
                {
                    if (i != c.getChoices().Count() - 1 || c.getInventories() == -1)
                    {
                        Console.WriteLine("║  " + (i + 1) + " " + c.getChoices()[i].PadRight(windowWidth - 6) + "  ║");
                    }
                    else if (inventory.Contains(c.getInventories()))
                    {
                        Console.WriteLine("║  " + (i + 1) + " " + c.getChoices()[i].PadRight(windowWidth - 6) + "  ║");
                    }
                }
                Console.WriteLine("║" + new string(' ', windowWidth - 2) + "║");

                // Draw bottom border
                Console.WriteLine("╚═" + " 1-Save ══ 2-Load ══ 3-Previous ══ 4-Menu " + new string('═', windowWidth - 45) + "╝");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int saveNumber) && saveNumber <= c.getChoices().Count() && saveNumber >= 1)
                {
                    return saveNumber;
                }
            }

        }

        public bool checkNeedness(MandatoryChoice a)
        {
            for (int i = 0; i < a.Length(); i++)
            {
                if (choices[a.index[i]] != a.value[i])
                {
                    return false;
                }
            }
            return true;
        }
        void EnterName()
        {
            Console.Clear();
            Console.Write("Enter your name: ");
            if (this.name != null || this.choices != null || this.inventory != null)
            {
                this.choices = [];
                this.inventory = [];
            }
            this.name = Console.ReadLine();
            Console.Write("May luck always be with you");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
        }

        public void addInventory(int g)
        {
            inventory.Add(g);
        }
        public void addChoice(int g)
        { 
            choices.Add(g);
        }
        public void AreYouSure()
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to quit? Make sure you made a saving.", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes) {
                Application.Current.Shutdown();
            }

        }
        public void LoadMenu()
        {
            Console.Clear();
            Console.WriteLine($"Choose saving\n");
            Dictionary<string, string> list = openSaveDir();
            foreach (var pair in list)
            {
                Console.WriteLine($"{Path.GetFileNameWithoutExtension(pair.Key)}: {pair.Value}");
            }
            Console.Write("\nEnter the number of the save to load: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int saveNumber) && saveNumber >= 1 && saveNumber <= list.Count)
            {
                Load($"Save{input}.txt");
                Thread.Sleep(2000);
            }
            else
            {
                LoadMenu();
            }
        }
        public void Set(string name, List<int> choices, List<int> inventory)
        {
            this.name = name;
            this.choices = choices;
            this.inventory = inventory;
        }
        public void Load(string fileName)
        {
            string filePath = $"Saves\\{fileName}";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length >= 3)
                {
                    string userName = lines[0];
                    string[] choicesStr = lines[1].Split(' ');
                    string[] inventoryStr = lines[2].Split(' ');

                    List<int> choices = Array.ConvertAll(choicesStr, int.Parse).ToList();
                    List<int> inventory = Array.ConvertAll(inventoryStr, int.Parse).ToList();

                    Console.WriteLine("Data loaded successfully.");
                    /*    Console.WriteLine(userName);
                        Console.WriteLine(string.Join(" ", choices));
                        Console.WriteLine(string.Join(" ", inventory));*/
                    //Console.Clear();
                    Set(name, choices, inventory);
                }
                else
                {
                    Console.WriteLine($"Invalid data in file: {fileName}");
                }
            }
            else
            {
                Console.WriteLine($"File '{fileName}' not found.");
            }
        }

        public void Save()
        {
            try
            {
                Dictionary<string, string> list = openSaveDir();
                int maxSaveNumber = GetMaxSaveNumber(list.Keys);
                string newFileName = $"Saves\\save{maxSaveNumber + 1}.txt";
                using (StreamWriter sw = File.CreateText(newFileName))
                {
                    sw.WriteLine(name);
                    sw.WriteLine(string.Join(" ", choices));
                    sw.WriteLine(string.Join(" ", inventory));
                }
                Console.WriteLine($"Data saved successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error saving data: {e.Message}");
            }
            Thread.Sleep(2000);
        }

        protected Dictionary<string, string> openSaveDir()
        {
            string path = "Saves\\";
            Dictionary<string, string> directoriesAndFiles = new Dictionary<string, string>();

            foreach (string file in Directory.GetFiles(path))
            {
                string fileName = Path.GetFileName(file);
                string name = getNameFromFile(file);
                directoriesAndFiles.Add(fileName, name);
            }

            return directoriesAndFiles;
        }
        protected string getNameFromFile(string name)
        {
            using (StreamReader sr = new StreamReader(name))
            {
                return sr.ReadLine();
            };
        }
        protected int GetMaxSaveNumber(IEnumerable<string> fileNames)
        {
            int maxNumber = 0;
            foreach (string fileName in fileNames)
            {
                string numberString = Path.GetFileNameWithoutExtension(fileName).Replace("save", "");
                if (int.TryParse(numberString, out int number))
                {
                    if (number > maxNumber)
                    {
                        maxNumber = number;
                    }
                }
            }
            return maxNumber;
        }

        public bool CheckAvailability(Replics a)
        {

            if (a.getChoices().index == null || a.getChoices().value == null || a.getChoices() == null)
            {
                return false;
            }
            var c = a.getChoices();

            for (int i = 0; i < c.value.Length; i++)
            {
                if (c.value[i] != choices[c.index[i]])
                {
                    return false;
                }
            }
            return false;
        }
    }
}
