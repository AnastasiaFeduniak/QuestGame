using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab5
{
    public interface ICommand
    {
        void Execute();
    }

    public class ShowDialogueCommand : ICommand
    {
        NameDialog e = new NameDialog();
        MessageBoxResult result;

        public ShowDialogueCommand(string question, string a)
        {
            result = MessageBox.Show(question, a, MessageBoxButton.YesNo, MessageBoxImage.Question);
        }

        public void Execute()
        {
            if(result == MessageBoxResult.Yes)
            {

            } else { }
        }
    }

    public class GiveItemCommand : ICommand
    {
        private QuestGame quest;
        private int itemId;

        public GiveItemCommand(QuestGame quest, int itemId)
        {
            this.quest = quest;
            this.itemId = itemId;
        }

        public void Execute()
        {
            // Code to give item to the player
            quest.addInventory(itemId);
        }
    }

    public class MoveToStory : ICommand
    {
        private StoryWindow storyWindow;

        public MoveToStory(StoryWindow storyWindow)
        {
            this.storyWindow = storyWindow;
        }

        public void Execute()
        {
            // Code to move to the next part of the story
            
            storyWindow.Story();
        }
    }

    public class CommandInvoker
    {
        private Queue<ICommand> commandQueue = new Queue<ICommand>();

        public void AddCommand(ICommand command)
        {
            commandQueue.Enqueue(command);
        }

        public void ExecuteCommands()
        {
            while (commandQueue.Count > 0)
            {
                ICommand command = commandQueue.Dequeue();
                command.Execute();
            }
        }
    }
}
