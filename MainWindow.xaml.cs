using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        QuestGame quest = new QuestGame();

        public MainWindow()
        {
            InitializeComponent();
            quest.InitializeMusic();
        }

        
       


        private void btnExit_Click(object sender, EventArgs e)
        {
            quest.Exit();
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            quest.Music();
        }

        private void btnLoadGame_Click(object sender, EventArgs e) { }
        private void btnContinue_Click(object sender, EventArgs e) { }
        private void btnStartNewGame_Click(object sender, RoutedEventArgs e)
        {
            NameDialog nameDialog = new NameDialog();
            nameDialog.Owner = this;

            bool? dialogResult = nameDialog.ShowDialog();

            if (dialogResult == true)
            {
                string userName = nameDialog.UserName;
                quest.addName(userName);
                this.Hide();

                StoryWindow storyWindow = new StoryWindow(quest, this);
                storyWindow.ShowDialog();
            }
            else
            {
            }
        }

    }
}