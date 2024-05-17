using System.Collections.Generic;
using MyThirdAvaloniaApp.Models;

namespace MyThirdAvaloniaApp.ViewModels;
public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        MyNews =
        [
            new("Yesterday", "From what I researched goats or sheep are better to keep lawns trimmed. " +
            "Alpacas can have some finicky health problems and are happier in herds. They can get costly to maintain " +
            "if you aren't planning on selling wool or breeding. If you are okay giving them their worm shots yourself you " +
            "can save money but there is a little bit more maintenance with alpacas then goats or sheep. Also need to sheer" +
            " them down every year or two but sheep will have the same task. If you ever plan on getting goats don't pen them with alpacas."),
        new("1 week ago", "Alpacas wouldn’t be my first suggestion for your situation, as there are some lower-maintenance/cost " +
        "livestock out there. However, for a beginner, they are pretty easygoing temperament wise (from those i’ve been around) " +
        "and if you get one from a good owner/breeder, you could certainly have them live up to your expectations! best of luck to you!"),
        ];
        MyNote = [new("Alpaca", "Tags:\tTag1\tTag2\tTag3\tTag4",
            "The Alpaca is a domestic hoofed mammal that originated in South America. Its closest relatives are the domestic llama, the wild vicuna, and guanaco. Researchers believe that humans bred these modern day animals from vicunas.\n" +
            "       Alpacas and llamas look quite similar, but Alpacas are significantly smaller than llamas. There are just two breeds of Alpaca: the Huacaya and the Suri. Read on to learn about the Alpaca.\n" +
            "       Description of the Alpaca\n" +
            "       These fluffy animals stand about 3.5 ft. tall at the shoulder. They are relatively small compared to the other members of their family, and weigh about 130 lbs. on average. They have long legs, long necks, and long ears.\n" +
            "       Their fur is long and dense, and varies in color from white to black, and many different shades of brown or tan. Some Alpacas have solid colored coats, while others have spots or patches of different color.\n" +
            "       These are furry, charismatic animals that humans breed in many different parts of the world. Learn more about what makes them unique below.\n" +
            "       * Camelidae – Just like llamas, vicunas, and guanacos, Alpacas are members of the Camelidae family. Within the camel family, humans have domesticated 4 of the 7 different species. Of the domestic Camelids, which also include the Bactrian camel, Dromedary camel, and llama, the Alpaca is the smallest.\n" +
            "       * Closest Relatives – Within the family, this animal is genetically quite similar to the llama. In fact, they are so closely related that they can interbreed. A hybrid between a llama and an Alpaca is a “huarizo.” Just like mules, which are hybrids of horses and donkeys, Huarizos usually cannot reproduce.\n" +
            "       * Spitting – Like llamas, Alpacas can “spit” if they feel threatened. However, this spit is not actually saliva, but a sticky glob of whatever happens to be in their stomach at the time. It is never a good idea to agitate one of these animals, but don’t think distance will keep you safe! Their spitting radius is about 10 feet!\n")
            ];
    }

    public List<News> MyNews { get; set; }
    public List<Notes> MyNote { get; set; }    
}
 