using FlyWeight.AfterFlyWeight;
using FlyWeight.BeforeFlyWeight;



string path = "book.txt";




//викорисатння пам'яті = 35,45 МБ


Console.WriteLine("AfterFlyWeight");
LightHTMLFly htmlFly = new LightHTMLFly(path);
//викорисатння пам'яті = 34,96 МБ

/*InstricTagFactory.ShowDictCount();*/ //Метод для перегляду створених InstricTag 