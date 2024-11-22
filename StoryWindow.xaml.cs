using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Threading;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Threading;

namespace Lab5
{
    /// <summary>
    /// Interaction logic for StoryWindow.xaml
    /// </summary>
    public partial class StoryWindow : Window
    {
        string[] inv = ["", "Cake", "Knife", "Pizza"];
        MainWindow MainWindow;
        private List<Replics> text;
        List<Choice> ch = new List<Choice>();
        int i = 0, tempChoice = 0;
        QuestGame quest = new QuestGame();

        public StoryWindow(QuestGame s, MainWindow mainWindow)
        {
            quest = s;
            this.MainWindow = mainWindow;
            InitializeComponent();
            InitializeStory();
            Story();
        }
        private void InitializeStory()
        {
            text = new List<Replics>
            {
             new Replics(
                new Script(["", "", ""], ["It was a harsh day don't u think?", "Well I don't have a time for replics, so", "Continue?"], [0, 0, 0], 1),
                true,
                new InventoryGiver(0, 0),
                new MandatoryChoice([], [])
                ),
            new Replics(
                new Script(["Monika", "Monika"], ["Okay you've got something", "Here is your knife"], [1, 2], 1),
                false,
                new InventoryGiver(2, 1),
                new MandatoryChoice([0], [0])
                ),
            new Replics(
               new Script(["Monc", "Monc"], ["Okay just another replic", "No item this time"], [1, 1], 2),
               false,
               new InventoryGiver(0, 0),
               new MandatoryChoice([0], [1])
               ),
              new Replics(
               new Script(["Monika", "Monika", "Monika"], ["Wait", "What was that?", "Nevermind"], [1, 3, 2], 1),
               false,
               new InventoryGiver(0, 0),
               new MandatoryChoice([], [])
               ),
            new Replics(
               new Script(["Monc"], ["Control check"], [2], 1),
               true,
               new InventoryGiver(0, 0),
               new MandatoryChoice([], [])
               ),
            new Replics(
               new Script(["Monika", "Monika"], ["Ouch it was painful!", "Carefully"], [3, 3], 1),
               false,
               new InventoryGiver(0, 0),
               new MandatoryChoice([1], [1])
               ),
            new Replics(
               new Script(["Monika", "Monc"], ["Thanks", "Good luck!"], [1, 3], 2),
               false,
               new InventoryGiver(0, 0),
               new MandatoryChoice([], [])
               )
        };

            ch.Add(new Choice(["Get item", "Move forward"], -1));
            ch.Add(new Choice(["Move", "Use knife"], 2));
        }

        public async void Story()
        {
            bool checkout = true;
            int index = 0;
            for (int j = 0; j < text.Count(); j++)
            {
                if (text[j].getReplics().background != 0)
                {
                    string imagePath = $"D:\\LABS_2\\MAPZ\\Lab5\\Lab5\\Images\\{text[j].getReplics().background}.jpg";

                    BitmapImage bitmapImage = new BitmapImage(new Uri(imagePath));
                    Background.Source = bitmapImage;
                }
                for (i = 0; i < text[j].Length(); i++)
                {
                    if (!quest.checkNeedness(text[j].getChoices())) { break; }
                    if (text[j].getItem().ItemId > 0) { quest.addInventory(text[j].getItem().ItemId + 1); }
                    showReplic(text[j].getReplic(i), text[j].getName(i));
                    ShowSprite(text[j].getName(i), text[j].getSprite(i));
                    if (j == 3 && i == 2)
                    {
                        //  CreateAndDeleteElementsWithTimers(20, "D:\\LABS_2\\MAPZ\\Lab5\\Lab5\\Images\\{name}_{sprite}.png");
                        /*   SpecEffectsFactory effectsFactory = new SpecEffectsFactory();
                            SpecEffects firework = effectsFactory.GetFirework("D:\\LABS_2\\MAPZ\\Lab5\\Lab5\\Images\\Firework.gif");
                            createSpecEffect(firework, 100, 100);*/
                        LaunchSpecEffect();
                    }
                    await WaitForKeyDown();
                }
                if (text[j].getNextChoice())
                {
                    showChoice(ch[index]);
                    tempChoice = 0;
                    while (tempChoice == 0)
                    {
                        await WaitForKeyDown();
                   
                    }
                    quest.addChoice(tempChoice - 1);
                    tempChoice = 0;
                    index++;
                }
            }

            this.Close();
            MainWindow.Show();
        }
        public void ShowSprite(string name, int sprite) {
            if (name == "" && sprite == 0)
            {
                CharacterSprite.Source = null;
                return;
            }

            string imagePath = $"D:\\LABS_2\\MAPZ\\Lab5\\Lab5\\Images\\{name}_{sprite}.png";

            BitmapImage bitmapImage = new BitmapImage(new Uri(imagePath));
            CharacterSprite.Source = bitmapImage;
        }

        public async Task LaunchSpecEffect()
        {
            SpecEffectsFactory effectsFactory = new SpecEffectsFactory();
            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int x = random.Next(50, 650);
                int y = random.Next(0, 300);

                // Створення та відображення салюту
                CreateFireworkAsync(effectsFactory, x, y);

                // Затримка в одну секунду перед створенням наступного салюту
                await Task.Delay(2000);
            }
        }

        private async Task CreateFireworkAsync(SpecEffectsFactory effectsFactory, int x, int y)
        {
            SpecEffects firework = effectsFactory.GetFirework($"D:\\LABS_2\\MAPZ\\Lab5\\Lab5\\Images\\Firework.gif");

            System.Windows.Controls.Image image = firework.Explode(x, y);

            // Додати салют до сітки
            await System.Windows.Application.Current.Dispatcher.InvokeAsync(() =>
            {
                image.Margin = new System.Windows.Thickness(x, y, 0, 0); // Use margin to set the position
                grid.Children.Add(image);
            });

            await Task.Delay(7000);

                grid.Children.Remove(image);
            firework = null;

        }

        public void showReplic(string a, string b)
        {
                    StoryText.Text = a;
                    CharacterName.Text = string.IsNullOrEmpty(b) ? "" : b;
        }

        public async void createSpecEffect(SpecEffects firework, int x, int y)
        {
            System.Windows.Controls.Image image = firework.Explode(x, y);

            Grid.SetColumn(image, x);
            Grid.SetRow(image, y);

            grid.Children.Add(image);
            await Task.Delay(10000);

            grid.Children.Remove(image);
        }

        public void showChoice(Choice c)
        {
            StoryText.Text = string.Empty;
            var choices = c.getChoices();
            for (int i = 0; i < choices.Count; i++)
            {
                if (i != choices.Count() - 1 || c.getInventories() == -1)
                {
                    StoryText.Text += $"{i + 1} {choices[i]}\n";
                }
               else if (quest.user.checkInventory([c.getInventories()]))
                {
                    StoryText.Text += $"{i + 1} {choices[i]}\n";
                }
            }
        }

        public void BackButton_Click(object sender, EventArgs e)
        {
            if (i <= 0)
            {
                i -= 2;
            }
        }

     

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) { }



             if (e.Key >= Key.NumPad1 && e.Key <= Key.NumPad9 && int.Parse(e.Key.ToString().Substring(6)) <= ch.Count)
             {
                 tempChoice = e.Key - Key.NumPad0;
             }
             else if (e.Key >= Key.D1 && e.Key <= Key.D9 && int.Parse(e.Key.ToString().Substring(1)) <= ch.Count)
             {
                 tempChoice = e.Key - Key.D0;
             }
             KeyDown -= Window_KeyDown;
             keyPressTaskCompletionSource.SetResult(true);
          
        }

        private TaskCompletionSource<bool> keyPressTaskCompletionSource;

        private Task WaitForKeyDown()
        {
            keyPressTaskCompletionSource = new TaskCompletionSource<bool>();
            KeyDown += Window_KeyDown;
            Focus();
            return keyPressTaskCompletionSource.Task;
        }
    }
}
