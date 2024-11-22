using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Lab5
{
    public interface IStoryState
    {
        void Handle(StoryWindow context);
    }

    public class IntroductionState : IStoryState
    {
        public void Handle(StoryWindow context)
        {

        }
    }

    public class ChoiceSelectionState : IStoryState
    {
        public void Handle(StoryWindow context)
        {
      
        }
    }

    public class ConclusionState : IStoryState
    {
        public void Handle(StoryWindow context)
        {
  
        }
    }

}
